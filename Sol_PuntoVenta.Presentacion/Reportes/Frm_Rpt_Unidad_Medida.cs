using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_PuntoVenta.Presentacion.Reportes
{
    public partial class Frm_Rpt_Unidad_Medida : Form
    {
        public Frm_Rpt_Unidad_Medida()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Unidad_Medida_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_umTableAdapter.Fill(this.dataSet_DatosMaestros.USP_Listado_um, cTexto: txt_p1.Text.Trim());
            this.reportViewer1.RefreshReport();
        }
    }
}
