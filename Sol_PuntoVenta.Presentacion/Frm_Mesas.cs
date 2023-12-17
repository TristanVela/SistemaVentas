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
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Mesas : Form
    {
        public Frm_Mesas()
        {
            InitializeComponent();
        }

        #region "Mis variables"
        int nCodigo = 0;
        int nCodigo_fa =0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_sf()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText="CODIGO_SF";
            Dgv_Listado.Columns[1].Width = 250;
            Dgv_Listado.Columns[1].HeaderText="SUBFAMILIAS";
            Dgv_Listado.Columns[2].Width = 250;
            Dgv_Listado.Columns[2].HeaderText = "FAMILIAS";
            Dgv_Listado.Columns[3].Visible = false;
        }

        private void Formato_fa()
        {
            dgv_1.Columns[0].Visible = false;
            dgv_1.Columns[1].Width = 350;
            dgv_1.Columns[1].HeaderText = "FAMILIAS";
     
        }

        private void Listado_sf(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_SubFamilias.Litado_sf(cTexto);
                this.Formato_sf();
                lbl_totalregistros.Text= "Total registros: "+Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listado_fa(string cTexto)
        {
            try
            {
                dgv_1.DataSource = N_SubFamilias.Litado_fa(cTexto);
                this.Formato_fa();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void LimpiarTexto()
        {
            txtDescripcion.Text = "";
            txtPuntoVenta.Text = "";
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado;
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }

        private void Estado_Texto(bool lEstado)
        {
            txtDescripcion.ReadOnly = !lEstado;
        }

        private void Estado_BotonesProcesos(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;
            btn_lupa1.Visible = Lestado;
        }

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value);
                txtDescripcion.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value);
                txtPuntoVenta.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_fa"].Value);
                this.nCodigo_fa = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value);
            }
        }

        private void Selecciona_Item_fa()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_1.CurrentRow.Cells["codigo_fa"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                txtPuntoVenta.Text = Convert.ToString((dgv_1.CurrentRow.Cells["descripcion_fa"].Value));
                this.nCodigo_fa = Convert.ToInt32((dgv_1.CurrentRow.Cells["codigo_fa"].Value));
            }
        }
        #endregion


        private void Frm_Mesas_Load(object sender, EventArgs e)
        {
            this.Listado_sf("%");
            this.Listado_fa("%");
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            Tbc_principal.SelectedIndex = 0;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Estadoguarda = 1;
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.LimpiarTexto();
            this.Estado_Texto(true);
            Tbc_principal.SelectedIndex = 1;
            btn_lupa1.Focus();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarTexto();
            this.Estado_Texto(false);
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tbc_principal.SelectedIndex = 0;
        }



        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text == String.Empty|| 
                    txtPuntoVenta.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else {
                    string rpta = "";
                    E_SubFamilias oPropiedad = new E_SubFamilias();
                    oPropiedad.Codigo_sf = this.nCodigo;
                    oPropiedad.Descripcion_sf = txtDescripcion.Text.Trim();
                    oPropiedad.Codigo_fa = this.nCodigo_fa;
                    rpta = N_SubFamilias.Guardar_sf(this.Estadoguarda, oPropiedad);
                   if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente",
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        this.LimpiarTexto();
                        this.Estado_Texto(false);
                        this.Estado_BotonesPrincipales(true);
                        this.Estado_BotonesProcesos(false);
                        this.Estadoguarda = 0;
                      //this.nCodigo = 0;
                        this.nCodigo_fa = 0;
                        this.Listado_sf("%");
                        Tbc_principal.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show(rpta, "Aviso del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0) 
            {
                this.Estadoguarda = 2;
                this.Estado_BotonesPrincipales(false);
                this.Estado_BotonesProcesos(true);
                this.Estado_Texto(true);
                this.LimpiarTexto();
                this.Selecciona_Item();
                Tbc_principal.SelectedIndex = 1;
                btn_lupa1.Focus();
            }
        }


        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Estadoguarda == 0)
            {
                this.Selecciona_Item();
                this.Estado_BotonesProcesos(false);
                Tbc_principal.SelectedIndex = 1;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                DialogResult option;
                option = MessageBox.Show("¿Estas seguro de eliminar el registro seleccionado?",
                    "Aviso del sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    string rpta = "";
                    this.Selecciona_Item();
                    rpta = N_SubFamilias.Eliminar_sf(this.nCodigo);
                    if (rpta.Equals("OK"))
                    {
                        this.Listado_sf("%");
                        MessageBox.Show("El registro a sido eliminado correctamente",
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        this.nCodigo = 0;
                    }
                    else
                    {
                        MessageBox.Show(rpta,
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    this.LimpiarTexto();
                }
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_sf(txtBuscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count>0)
            {
             //  Reportes.Frm_Rpt_SubFamilias oRpt_sf = new Reportes.Frm_Rpt_SubFamilias();
             //  oRpt_sf.txt_p1.Text = txtBuscar.Text.Trim();
              // oRpt_sf.ShowDialog(); 
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_retornar1_Click(object sender, EventArgs e)
        {
            pnl_listado1.Visible=false;
        }

        private void btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_fa(txtBuscar.Text.Trim());
        }

        private void btn_lupa1_Click(object sender, EventArgs e)
        {
            pnl_listado1.Location = btn_lupa1.Location;
            pnl_listado1.Visible = true;
            txtBuscar.Focus();
        }

        private void dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_fa();
            pnl_listado1.Visible = false;
            txtDescripcion.Focus();
        }
    }
}
