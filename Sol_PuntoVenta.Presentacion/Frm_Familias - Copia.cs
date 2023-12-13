﻿using Sol_PuntoVenta.Negocio;
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
    public partial class Frm_Familias : Form
    {
        public Frm_Familias()
        {
            InitializeComponent();
        }

        #region "Mis variables"
        int nCodigo = 0;
        int Estadoguarda = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_fa()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].HeaderText="CODIGO_FA";
            Dgv_Listado.Columns[1].Width = 350;
            Dgv_Listado.Columns[1].HeaderText="FAMILIAS";
        }

        private void Listado_fa(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Familias.Litado_fa(cTexto);
                this.Formato_fa();
                lbl_totalregistros.Text= "Total registros: "+Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void LimpiarTexto()
        {
            txtDescripcion.Text = "";
            
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
        }

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo = Convert.ToInt32((Dgv_Listado.CurrentRow.Cells["codigo_fa"].Value));
                txtDescripcion.Text = Convert.ToString((Dgv_Listado.CurrentRow.Cells["descripcion_fa"].Value));
            }
        }
        #endregion

    
        private void Frm_Familias_Load(object sender, EventArgs e)
        {
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
            txtDescripcion.Focus();
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
                if (txtDescripcion.Text == String.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else {
                    string rpta = "";
                    E_Familias oPropiedad = new E_Familias();
                    oPropiedad.Codigo_fa = this.nCodigo;
                    oPropiedad.Descripcion_fa = txtDescripcion.Text.Trim();
                    rpta = N_Familias.Guardar_fa(this.Estadoguarda, oPropiedad);
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
                        this.Listado_fa("%");
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
                txtDescripcion.Focus();
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
                    rpta = N_Familias.Eliminar_fa(this.nCodigo);
                    if (rpta.Equals("OK"))
                    {
                        this.Listado_fa("%");
                        MessageBox.Show("El registro a sido eliminado correctamente",
                            "Aviso del sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
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
            this.Listado_fa(txtBuscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count>0)
            {
                Reportes.Frm_Rpt_Familia oRpt_fa = new Reportes.Frm_Rpt_Familia();
               oRpt_fa.txt_p1.Text = txtBuscar.Text.Trim();
                oRpt_fa.ShowDialog(); 
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
