using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_DashBoard : Form
    {
        private IconButton CurrentBtn;
        private Panel LeftBorderBtn;
        public Frm_DashBoard()
        {
            InitializeComponent();
            CustomizeDesign();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 46);
            Pnl_menu.Controls.Add(LeftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Mis Metodos"
        private void Reset()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            Icono_Seleccionado.IconChar = IconChar.Home;
            Icono_Seleccionado.IconColor = Color.Black;
            lbl_Texto_Seleccionado.Text = "Home";
            lbl_Texto_Seleccionado.ForeColor = Color.Black;
        }
        private void CustomizeDesign()
        {
            Pnl_Procesos.Visible = false;
            Pnl_Reportes.Visible = false;
            Pnl_DatosMaestros.Visible = false;
        }
        private void HideSubMenu()
        {
            if (Pnl_Procesos.Visible == true)
                Pnl_Procesos.Visible = false;
            if (Pnl_Reportes.Visible == true)
                Pnl_Reportes.Visible = false;
            if(Pnl_DatosMaestros.Visible == true)
                Pnl_DatosMaestros.Visible =false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible=false;
            }
        }
        
        private void DisableButton()
        {
            if(CurrentBtn != null)
            {
                CurrentBtn.BackColor = Color.FromArgb(44,105,141);
                CurrentBtn.ForeColor = Color.White;
                CurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBtn.IconColor = Color.White;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                CurrentBtn = (IconButton)senderBtn;
                CurrentBtn.BackColor = Color.FromArgb(37);
                CurrentBtn.ForeColor = color;
                CurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentBtn.IconColor = color;
                CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBtn.ImageAlign = ContentAlignment.MiddleRight;

                Icono_Seleccionado.IconChar = CurrentBtn.IconChar;
                Icono_Seleccionado.IconColor = color;
                lbl_Texto_Seleccionado.Text = CurrentBtn.Text;
                lbl_Texto_Seleccionado.ForeColor = color;
            }
        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }

        private Form ActiveForm = null;
        private void OpenForm(Form oForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = oForm;
            oForm.TopLevel = false;
            oForm.FormBorderStyle = FormBorderStyle.None;
            oForm.Size = Pnl_Contenido.Size; // Establecer el tamaño del formulario
            oForm.Location = new Point(0, 0); // Establecer la posición del formulario
            Pnl_Contenido.Controls.Add(oForm);
            Pnl_Contenido.Tag = oForm;
            oForm.BringToFront();
            oForm.Show();
        }

        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState -= FormWindowState.Normal;
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //DRAG FRM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        private void Pnl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void Btn_Procesos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBcolors.color1);
            ShowSubMenu(Pnl_Procesos);
        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
            ShowSubMenu(Pnl_Reportes);
        }

        private void Btn_DatosMaestros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            ShowSubMenu(Pnl_DatosMaestros);
        }

        private void Btn_DashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
            CustomizeDesign();
        }

        private void DM_productos_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Productos());
        }

        private void Pct_Logo_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            Reset();
            CustomizeDesign();
        }

        private void DM_Marcas_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Marcas());
        }

        private void DM_Medidas_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Unidades_Medidas());
        }

        private void DM_SubFamilias_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_SubFamilias());
        }

        private void DM_Familias_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Familias());
        }

        private void DM_PuntoVenta_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Punto_Venta());
        }

        private void DM_Mesas_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Mesas());
        }

        private void DM_AreaDespacho_Click(object sender, EventArgs e)
        {
            OpenForm(new Frm_Area_Despacho());
        }

        private void PR_Registrar_Pedido_Click(object sender, EventArgs e)
        {
            OpenForm(new Procesos.Frm_Registro_Pedidos());
        }
    }
}
