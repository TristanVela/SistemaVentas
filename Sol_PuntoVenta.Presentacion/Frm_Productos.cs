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
using System.IO;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        #region "Mis variables"
        int nCodigo = 0;
        int nCodigo_ma =0;
        int nCodigo_um =0;
        int nCodigo_sf =0;
        int nCodigo_ad =0;
        int Estadoguarda = 0;
        DataTable DTdetalle = new DataTable();
        #endregion

        #region "Mis metodos"
        private void Formato_pr()
        {
            Dgv_Listado.Columns[0].Width = 80;
            Dgv_Listado.Columns[0].HeaderText="CODIGO_PR";
            Dgv_Listado.Columns[1].Width = 260;
            Dgv_Listado.Columns[1].HeaderText="PRODUCTO";
            Dgv_Listado.Columns[2].Width = 150;
            Dgv_Listado.Columns[2].HeaderText = "MARCA"; 
            Dgv_Listado.Columns[3].Width = 100;
            Dgv_Listado.Columns[3].HeaderText = "MEDIDA"; 
            Dgv_Listado.Columns[4].Width = 150;
            Dgv_Listado.Columns[4].HeaderText = "SUBFAMILIA"; 
            Dgv_Listado.Columns[5].Width = 110;
            Dgv_Listado.Columns[5].HeaderText = "PRECIO UNITARIO";
            Dgv_Listado.Columns[6].Width = 150;
            Dgv_Listado.Columns[6].HeaderText = "AREA DE DESPACHO";
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;
            Dgv_Listado.Columns[11].Visible = false;
        }

        private void Formato_ma()
        {
            dgv_1.Columns[0].Visible = false;
            dgv_1.Columns[1].Width = 350;
            dgv_1.Columns[1].HeaderText = "MARCA";
     
        }

        private void Formato_um()
        {
            dgv_2.Columns[0].Visible = false;
            dgv_2.Columns[1].Width = 350;
            dgv_2.Columns[1].HeaderText = "MEDIDA";

        }

        private void Formato_sf()
        {
            dgv_3.Columns[0].Visible = false;
            dgv_3.Columns[1].Width = 350;
            dgv_3.Columns[1].HeaderText = "SUBFAMILIAS";
            dgv_3.Columns[2].Width = 350;
            dgv_3.Columns[2].HeaderText = "FAMILIAS";
            dgv_3.Columns[3].Visible = false;
        }
        private void Formato_ad()
        {
            dgv_4.Columns[0].Visible = false;
            dgv_4.Columns[1].Width = 350;
            dgv_4.Columns[1].HeaderText = "SUBFAMILIAS";
        }
        private void Listado_pr(string cTexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Productos.Litado_pr(cTexto);
                this.Formato_pr();
                lbl_totalregistros.Text= "Total registros: "+Convert.ToString(Dgv_Listado.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listado_ma(string cTexto)
        {
            try
            {
                dgv_1.DataSource = N_Productos.Listado_ma(cTexto);
                this.Formato_ma();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listado_um(string cTexto)
        {
            try
            {
                dgv_2.DataSource = N_Productos.Listado_um(cTexto);
                this.Formato_um();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listado_sf(string cTexto)
        {
            try
            {
                dgv_3.DataSource = N_Productos.Listado_sf(cTexto);
                this.Formato_sf();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_ad(string cTexto)
        {
            try
            {
                dgv_4.DataSource = N_Productos.Listado_ad(cTexto);
                this.Formato_ad();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void LimpiarTexto()
        {
            txt_descripcion_pr.Text = "";
            txt_descripcion_ma.Text = "";
            txt_descripcion_um.Text = "";
            txt_descripcion_sf.Text = "";
            txt_precio_unitario.Text = "0.00";
            txt_descripcion_ad.Text = "";
            txt_observacion.Text = "";
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
            txt_descripcion_pr.ReadOnly = lEstado;
            txt_precio_unitario.ReadOnly = lEstado;
            txt_observacion.ReadOnly = lEstado;
        }

        private void Estado_BotonesProcesos(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;
            Btn_ma.Visible = Lestado;
            btn_um.Visible = Lestado;
            Btn_sf.Visible = Lestado;
            Btn_ad.Visible = Lestado;
            btn_agregar_img.Visible = Lestado;
        }

        private void Mostrar_img(int nCodigo_pr)
        {
            Byte[] bImagen = new Byte[0];
            bImagen = N_Productos.Mostrar_img(nCodigo_pr);
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image=System.Drawing.Image.FromStream(ms);
        }      
        private void Mostrar_img_prod_pred()
        {
            Byte[] bImagen = new Byte[0];
            bImagen = N_Productos.Mostrar_img_prod_pred();
            MemoryStream ms = new MemoryStream(bImagen);
            Pct_imagen.Image=System.Drawing.Bitmap.FromStream(ms);
        }

        private void Crear_Tabla_pv()
        {
            this.DTdetalle = new DataTable("Detalle");
            this.DTdetalle.Columns.Add("Descripcion_pv", System.Type.GetType("System.String"));
            this.DTdetalle.Columns.Add("OK", System.Type.GetType("System.Boolean"));
            this.DTdetalle.Columns.Add("Codigo_pv", System.Type.GetType("System.Int32"));

            dgv_puntos_ventas.DataSource = this.DTdetalle;

            dgv_puntos_ventas.Columns[0].Width = 220;
            dgv_puntos_ventas.Columns[0].HeaderText = "PUNTO DE VENTA";
            dgv_puntos_ventas.Columns[0].ReadOnly = true;
            dgv_puntos_ventas.Columns[1].Width = 45;
            dgv_puntos_ventas.Columns[1].HeaderText = "Ok";
            dgv_puntos_ventas.Columns[1].ReadOnly = true;
            dgv_puntos_ventas.Columns[2].Visible = false;
        }

        private void Agregar_pv(string Descripcion_pv, bool OK, int nCodigo_pv) 
        {
            DataRow Fila = DTdetalle.NewRow();
            Fila["Descripcion_pv"] = Descripcion_pv;
            Fila["OK"] = OK;
            Fila["Codigo_pv"] = nCodigo_pv;
            this.DTdetalle.Rows.Add(Fila);
        }

        private void Puntos_Ventas_Ok(int nOpcion, int nCodigo_pr)
        {
            try
            {
                DataTable TablaTemp = new DataTable();
                TablaTemp = N_Productos.Puntos_Ventas_OK(nOpcion, nCodigo_pr);
                DTdetalle.Clear();
                for (int nFila = 0; nFila <= TablaTemp.Rows.Count - 1; nFila++)
                {
                    this.Agregar_pv(Convert.ToString(TablaTemp.Rows[nFila][0]),
                                   Convert.ToBoolean(TablaTemp.Rows[nFila][1]),
                                   Convert.ToInt32(TablaTemp.Rows[nFila][2]));
                }
                dgv_puntos_ventas.DataSource = DTdetalle;

                if (nOpcion >= 1)
                {
                    dgv_puntos_ventas.Columns["OK"].ReadOnly = false;
                }
                else
                {
                    dgv_puntos_ventas.Columns["OK"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value);
                txt_descripcion_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_pr"].Value);
                txt_descripcion_ma.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ma"].Value);
                txt_descripcion_um.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_um"].Value);
                txt_descripcion_sf.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sf"].Value);
                txt_precio_unitario.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["precio_unitario"].Value);
                txt_descripcion_ad.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ad"].Value);
                txt_observacion.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["observacion"].Value);
                this.nCodigo_ma = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ma"].Value);
                this.nCodigo_um = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_um"].Value);
                this.nCodigo_sf = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sf"].Value);
                this.nCodigo_ad = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ad"].Value);
                this.Mostrar_img(this.nCodigo);
                this.Puntos_Ventas_Ok(this.Estadoguarda, this.nCodigo);
            }
        }

        private void Selecciona_Item_ma()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_1.CurrentRow.Cells["codigo_ma"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_descripcion_ma.Text = Convert.ToString((dgv_1.CurrentRow.Cells["descripcion_ma"].Value));
                this.nCodigo_ma = Convert.ToInt32((dgv_1.CurrentRow.Cells["codigo_ma"].Value));
            }
        }

        private void Selecciona_Item_um()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_2.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_descripcion_um.Text = Convert.ToString((dgv_2.CurrentRow.Cells["descripcion_um"].Value));
                this.nCodigo_um = Convert.ToInt32((dgv_2.CurrentRow.Cells["codigo_um"].Value));
            }
        }

        private void Selecciona_Item_sf()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_3.CurrentRow.Cells["codigo_sf"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_descripcion_sf.Text = Convert.ToString((dgv_3.CurrentRow.Cells["descripcion_sf"].Value));
                this.nCodigo_sf = Convert.ToInt32((dgv_3.CurrentRow.Cells["codigo_sf"].Value));
            }
        }
        private void Selecciona_Item_ad()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_4.CurrentRow.Cells["codigo_ad"].Value)))
            {
                MessageBox.Show("Por favor selecciona un registro",
                    "Aviso del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_descripcion_ad.Text = Convert.ToString((dgv_4.CurrentRow.Cells["descripcion_ad"].Value));
                this.nCodigo_ad = Convert.ToInt32((dgv_4.CurrentRow.Cells["codigo_ad"].Value));
            }
        }
        #endregion


        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_pr("%");
            this.Listado_ma("%");
            this.Listado_um("%");
            this.Listado_sf("%");
            this.Listado_ad("%");
            this.Crear_Tabla_pv();
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
            this.Puntos_Ventas_Ok(this.Estadoguarda,this.nCodigo);
            this.Mostrar_img_prod_pred();
            Tbc_principal.SelectedIndex = 1;
            txt_descripcion_pr.Focus();
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
                if (txt_descripcion_pr.Text == String.Empty|| 
                    txt_descripcion_ma.Text == String.Empty|| 
                    txt_descripcion_um.Text == String.Empty|| 
                    txt_descripcion_sf.Text == String.Empty|| 
                    txt_descripcion_ad.Text == String.Empty|| 
                    txt_precio_unitario.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)",
                        "Aviso del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else {
                    string rpta = "";
                    E_Productos oPropiedad = new E_Productos();
                    oPropiedad.Codigo_pr = this.nCodigo;
                    oPropiedad.Descripcion_pr = txt_descripcion_pr.Text.Trim();
                    oPropiedad.Codigo_ma = this.nCodigo_ma;
                    oPropiedad.Codigo_um = this.nCodigo_um;
                    oPropiedad.Codigo_sf = this.nCodigo_sf;
                    oPropiedad.Codigo_ad = this.nCodigo_ad;
                    oPropiedad.Precio_unitario = Convert.ToDecimal(txt_precio_unitario.Text);
                    oPropiedad.Observacion = this.txt_observacion.Text.Trim();
                    MemoryStream ms = new MemoryStream();
                    Pct_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    oPropiedad.imagen = ms.GetBuffer();
                    rpta = N_Productos.Guardar_pr(this.Estadoguarda, oPropiedad, DTdetalle);
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
                        this.nCodigo = 0;
                        this.nCodigo_ma = 0;
                        this.nCodigo_um = 0;
                        this.nCodigo_sf = 0;
                        this.nCodigo_sf = 0;
                        this.nCodigo_ad = 0;
                        this.Listado_pr("%");
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
            if (Dgv_Listado.Rows.Count>0) 
            {
                this.Estadoguarda = 2;
                this.Estado_BotonesPrincipales(false);
                this.Estado_BotonesProcesos(true);
                this.Estado_Texto(true);
                this.LimpiarTexto();
                this.Selecciona_Item();
                Tbc_principal.SelectedIndex = 1;
                txt_descripcion_pr.Focus();
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
                    rpta = N_Productos.Eliminar_pr(this.nCodigo);
                    if (rpta.Equals("OK"))
                    {
                        this.Listado_pr("%");
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
            this.Listado_pr(txtBuscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count>0)
            {
                Reportes.Frm_Rpt_Productos oRpt_pr = new Reportes.Frm_Rpt_Productos();
                oRpt_pr.txt_p1.Text = txtBuscar.Text.Trim();
                oRpt_pr.ShowDialog(); 
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
            this.Listado_ma(txtBuscar.Text.Trim());
        }

        private void btn_lupa1_Click(object sender, EventArgs e)
        {
            pnl_listado1.Location = Btn_ma.Location;
            pnl_listado1.Visible = true;
            txtBuscar1.Focus();
        }

        private void dgv_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_ma();
            pnl_listado1.Visible = false;
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            pnl_listado2.Location = btn_um.Location;
            pnl_listado2.Visible = true;
            txtBuscar2.Focus();
        }
        private void Btn_sf_Click(object sender, EventArgs e)
        {
            pnl_listado3.Location = btn_um.Location;
            pnl_listado3.Visible = true;
            txtBuscar3.Focus();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            this.Listado_um(txtBuscar2.Text.Trim());
        }

        private void dgv_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_um();
            pnl_listado2.Visible = false;
        }

        private void btn_buscar3_Click(object sender, EventArgs e)
        {
            this.Listado_sf(txtBuscar3.Text.Trim());
        }

        private void dgv_3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_sf();
            pnl_listado3.Visible = true;
            txt_precio_unitario.Focus();       
        }
        private void btn_retornar2_Click(object sender, EventArgs e)
        {
            pnl_listado2.Visible = false;
        }
        private void btn_retornar3_Click(object sender, EventArgs e)
        {
            pnl_listado3.Visible = false;
        }

        private void btn_retornar4_Click(object sender, EventArgs e)
        {
            pnl_listado4.Visible = false;
        }

        private void btn_buscar4_Click(object sender, EventArgs e)
        {
            this.Listado_ad(txtBuscar4.Text.Trim());
        }

        private void dgv_4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_ad();
            pnl_listado4.Visible = true;
            txt_observacion.Focus();
        }

        private void Btn_ad_Click(object sender, EventArgs e)
        {
            pnl_listado4.Location = btn_um.Location;
            pnl_listado4.Visible = true;
            txtBuscar4.Focus();
        }

        private void btn_agregar_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Image files(*.jpg,*.jpe,*.jfif,*.png) | *.jpg;*.jpe;*.jfif;*.png";
            if (Foto.ShowDialog() == DialogResult.OK)
            {
                Pct_imagen.Image = Image.FromFile(Foto.FileName);
            }
        }
    }
}

