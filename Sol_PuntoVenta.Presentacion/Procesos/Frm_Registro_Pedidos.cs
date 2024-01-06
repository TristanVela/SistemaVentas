using Sol_PuntoVenta.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Procesos
{
    public partial class Frm_Registro_Pedidos : Form
    {
        public Frm_Registro_Pedidos()
        {
            InitializeComponent();
        }

        #region "Mis variables"
        int nCodigo_pv = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_pv()
        {
            dgv_1.Columns[0].Visible = false;
            dgv_1.Columns[1].Width = 350;
            dgv_1.Columns[1].HeaderText = "PUNTOS DE VENTA";

        }
        private void Listado_pv(string cTexto)
        {
            try
            {
                dgv_1.DataSource = N_Registro_Pedidos.Listado_pv(cTexto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_Item_pv()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_1.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_pv.Text = Convert.ToString(dgv_1.CurrentRow.Cells["descripcion_pv"].Value);
                this.nCodigo_pv = Convert.ToInt32(dgv_1.CurrentRow.Cells["codigo_pv"].Value);
            }
        }

        private void Estado_FechaTurno_pv(int nCodigo_pv)
        {
            DataTable Tablax = new DataTable();
            Tablax = N_Registro_Pedidos.Estado_Turno_pv(nCodigo_pv);
            if (Tablax.Rows.Count>0)
            {
                
            }
            else
            {
                Txt_FechTrabajo.Text = "Ninguno";
                Txt_Turno.Text = "Ninguno";
                Txt_Estado.Text = "Ninguno";
                Lbl_Mensaje.Visible = false;
            }

        }
        #endregion

        private void Btn_salir_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void btn_lupa1_Click(object sender, EventArgs e)
        {
            pnl_listado1.Visible = true;
        }

        private void btn_retornar1_Click(object sender, EventArgs e)
        {
            pnl_listado1.Visible = false;
        }
        private void dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_pv();
            this.Estado_FechaTurno_pv(this.nCodigo_pv);
            this.pnl_listado1.Visible = false;
        }

        private void Frm_Registro_Pedidos_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
            Lbl_Mensaje.Text = "El turno del Punto de Venta se encuentra cerrado. Solicite al administrador la apertura de una nueva fecha de trabajo y/o turno.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.nCodigo_pv>0)
            {
                this.Estado_FechaTurno_pv(this.nCodigo_pv);
            }
        }
    }
    }




