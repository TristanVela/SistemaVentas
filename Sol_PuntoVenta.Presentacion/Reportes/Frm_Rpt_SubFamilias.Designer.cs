﻿namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_SubFamilias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSet_DatosMaestros = new Sol_PuntoVenta.Presentacion.Reportes.DataSet_DatosMaestros();
            this.uSPListadosfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Listado_sfTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DataSet_DatosMaestrosTableAdapters.USP_Listado_sfTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.uSPListadosfBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DatosMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadosfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadosfBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_DatosMaestros
            // 
            this.dataSet_DatosMaestros.DataSetName = "DataSet_DatosMaestros";
            this.dataSet_DatosMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadosfBindingSource
            // 
            this.uSPListadosfBindingSource.DataMember = "USP_Listado_sf";
            this.uSPListadosfBindingSource.DataSource = this.dataSet_DatosMaestros;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadosfBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_SubFamilias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Listado_sfTableAdapter
            // 
            this.uSP_Listado_sfTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(70, 64);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // uSPListadosfBindingSource1
            // 
            this.uSPListadosfBindingSource1.DataMember = "USP_Listado_sf";
            this.uSPListadosfBindingSource1.DataSource = this.dataSet_DatosMaestros;
            // 
            // Frm_Rpt_SubFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_SubFamilias";
            this.Text = "Frm_Rpt_SubFamilias";
            this.Load += new System.EventHandler(this.Frm_Rpt_SubFamilias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DatosMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadosfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadosfBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadosfBindingSource;
        private DataSet_DatosMaestros dataSet_DatosMaestros;
        private DataSet_DatosMaestrosTableAdapters.USP_Listado_sfTableAdapter uSP_Listado_sfTableAdapter;
        internal System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.BindingSource uSPListadosfBindingSource1;
    }
}