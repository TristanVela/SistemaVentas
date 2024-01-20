namespace Sol_PuntoVenta.Presentacion.Procesos
{
    partial class Frm_Registro_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro_Pedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Titulo_Form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pnl_Titulos_Mesas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Txt_pv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.btn_lupa1 = new System.Windows.Forms.Button();
            this.Txt_FechTrabajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Turno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Mensaje = new System.Windows.Forms.Label();
            this.pnl_listado1 = new System.Windows.Forms.Panel();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.btn_retornar1 = new System.Windows.Forms.Button();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Titulo_Form.SuspendLayout();
            this.Pnl_Titulos_Mesas.SuspendLayout();
            this.pnl_listado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Titulo_Form
            // 
            this.Pnl_Titulo_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(111)))), ((int)(((byte)(219)))));
            this.Pnl_Titulo_Form.Controls.Add(this.label3);
            this.Pnl_Titulo_Form.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo_Form.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Titulo_Form.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo_Form.Name = "Pnl_Titulo_Form";
            this.Pnl_Titulo_Form.Size = new System.Drawing.Size(984, 33);
            this.Pnl_Titulo_Form.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "REGISTRAR PEDIDOS";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addNew.png");
            this.imageList1.Images.SetKeyName(1, "update.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "reports.png");
            this.imageList1.Images.SetKeyName(4, "exit.png");
            this.imageList1.Images.SetKeyName(5, "searchmagnifierinterfacesymbol1_79893.png");
            this.imageList1.Images.SetKeyName(6, "4213475-arrow-back-left-return_115409.png");
            // 
            // Pnl_Titulos_Mesas
            // 
            this.Pnl_Titulos_Mesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(128)))), ((int)(((byte)(169)))));
            this.Pnl_Titulos_Mesas.Controls.Add(this.label1);
            this.Pnl_Titulos_Mesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulos_Mesas.Location = new System.Drawing.Point(0, 173);
            this.Pnl_Titulos_Mesas.Name = "Pnl_Titulos_Mesas";
            this.Pnl_Titulos_Mesas.Size = new System.Drawing.Size(984, 40);
            this.Pnl_Titulos_Mesas.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = ":::MESAS:::";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 246);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1089, 639);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // Txt_pv
            // 
            this.Txt_pv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pv.Location = new System.Drawing.Point(12, 57);
            this.Txt_pv.Name = "Txt_pv";
            this.Txt_pv.ReadOnly = true;
            this.Txt_pv.Size = new System.Drawing.Size(202, 26);
            this.Txt_pv.TabIndex = 0;
            this.Txt_pv.Text = "Punto de Venta X";
            this.Txt_pv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(111)))), ((int)(((byte)(219)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageKey = "exit.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(876, 31);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(72, 67);
            this.Btn_salir.TabIndex = 11;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_lupa1
            // 
            this.btn_lupa1.ImageKey = "searchmagnifierinterfacesymbol1_79893.png";
            this.btn_lupa1.ImageList = this.imageList1;
            this.btn_lupa1.Location = new System.Drawing.Point(230, 53);
            this.btn_lupa1.Name = "btn_lupa1";
            this.btn_lupa1.Size = new System.Drawing.Size(32, 32);
            this.btn_lupa1.TabIndex = 12;
            this.btn_lupa1.UseVisualStyleBackColor = true;
            this.btn_lupa1.Click += new System.EventHandler(this.btn_lupa1_Click);
            // 
            // Txt_FechTrabajo
            // 
            this.Txt_FechTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechTrabajo.Location = new System.Drawing.Point(310, 63);
            this.Txt_FechTrabajo.Name = "Txt_FechTrabajo";
            this.Txt_FechTrabajo.ReadOnly = true;
            this.Txt_FechTrabajo.Size = new System.Drawing.Size(149, 22);
            this.Txt_FechTrabajo.TabIndex = 14;
            this.Txt_FechTrabajo.Text = "Fecha de trabajo X";
            this.Txt_FechTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de trabajo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Turno
            // 
            this.Txt_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Turno.Location = new System.Drawing.Point(477, 63);
            this.Txt_Turno.Name = "Txt_Turno";
            this.Txt_Turno.ReadOnly = true;
            this.Txt_Turno.Size = new System.Drawing.Size(121, 22);
            this.Txt_Turno.TabIndex = 16;
            this.Txt_Turno.Text = "Turno X";
            this.Txt_Turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Turno";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.Location = new System.Drawing.Point(614, 63);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.Size = new System.Drawing.Size(121, 22);
            this.Txt_Estado.TabIndex = 18;
            this.Txt_Estado.Text = "Estado X";
            this.Txt_Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Mensaje
            // 
            this.Lbl_Mensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Mensaje.Location = new System.Drawing.Point(0, 117);
            this.Lbl_Mensaje.Name = "Lbl_Mensaje";
            this.Lbl_Mensaje.Size = new System.Drawing.Size(984, 23);
            this.Lbl_Mensaje.TabIndex = 16;
            this.Lbl_Mensaje.Text = "MENSAJE";
            this.Lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_listado1
            // 
            this.pnl_listado1.Controls.Add(this.dgv_1);
            this.pnl_listado1.Controls.Add(this.btn_retornar1);
            this.pnl_listado1.Location = new System.Drawing.Point(114, 6);
            this.pnl_listado1.Name = "pnl_listado1";
            this.pnl_listado1.Size = new System.Drawing.Size(385, 134);
            this.pnl_listado1.TabIndex = 10;
            this.pnl_listado1.Visible = false;
            // 
            // dgv_1
            // 
            this.dgv_1.AllowUserToAddRows = false;
            this.dgv_1.AllowUserToDeleteRows = false;
            this.dgv_1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_1.ColumnHeadersHeight = 35;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_1.Location = new System.Drawing.Point(12, 10);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.ReadOnly = true;
            this.dgv_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_1.Size = new System.Drawing.Size(309, 121);
            this.dgv_1.TabIndex = 10;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            this.dgv_1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellDoubleClick);
            // 
            // btn_retornar1
            // 
            this.btn_retornar1.ImageKey = "4213475-arrow-back-left-return_115409.png";
            this.btn_retornar1.ImageList = this.imageList1;
            this.btn_retornar1.Location = new System.Drawing.Point(340, 7);
            this.btn_retornar1.Name = "btn_retornar1";
            this.btn_retornar1.Size = new System.Drawing.Size(34, 30);
            this.btn_retornar1.TabIndex = 11;
            this.btn_retornar1.UseVisualStyleBackColor = true;
            this.btn_retornar1.Click += new System.EventHandler(this.btn_retornar1_Click);
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Pnl_Superior.Controls.Add(this.pnl_listado1);
            this.Pnl_Superior.Controls.Add(this.Lbl_Mensaje);
            this.Pnl_Superior.Controls.Add(this.label6);
            this.Pnl_Superior.Controls.Add(this.Txt_Estado);
            this.Pnl_Superior.Controls.Add(this.label5);
            this.Pnl_Superior.Controls.Add(this.Txt_Turno);
            this.Pnl_Superior.Controls.Add(this.label4);
            this.Pnl_Superior.Controls.Add(this.Txt_FechTrabajo);
            this.Pnl_Superior.Controls.Add(this.btn_lupa1);
            this.Pnl_Superior.Controls.Add(this.Btn_salir);
            this.Pnl_Superior.Controls.Add(this.label2);
            this.Pnl_Superior.Controls.Add(this.Txt_pv);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 33);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(984, 140);
            this.Pnl_Superior.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Registro_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Pnl_Titulos_Mesas);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.Pnl_Titulo_Form);
            this.Name = "Frm_Registro_Pedidos";
            this.Text = "Frm_Registro_Pedidos";
            this.Load += new System.EventHandler(this.Frm_Registro_Pedidos_Load);
            this.Pnl_Titulo_Form.ResumeLayout(false);
            this.Pnl_Titulo_Form.PerformLayout();
            this.Pnl_Titulos_Mesas.ResumeLayout(false);
            this.Pnl_Titulos_Mesas.PerformLayout();
            this.pnl_listado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Titulo_Form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pnl_Titulos_Mesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Txt_pv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button btn_lupa1;
        private System.Windows.Forms.TextBox Txt_FechTrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Turno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_Mensaje;
        private System.Windows.Forms.Panel pnl_listado1;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button btn_retornar1;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Timer timer1;
    }
}