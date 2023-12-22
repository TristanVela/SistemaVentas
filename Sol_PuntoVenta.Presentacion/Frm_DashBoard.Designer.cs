namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_DashBoard
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
            this.Pnl_menu = new System.Windows.Forms.Panel();
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.Pnl_Barra_Listado = new System.Windows.Forms.Panel();
            this.Pnl_Contenido = new System.Windows.Forms.Panel();
            this.Pnl_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Pnl_menu.SuspendLayout();
            this.Pnl_Contenido.SuspendLayout();
            this.Pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_menu
            // 
            this.Pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Pnl_menu.Controls.Add(this.Pnl_logo);
            this.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.Pnl_menu.Name = "Pnl_menu";
            this.Pnl_menu.Size = new System.Drawing.Size(230, 611);
            this.Pnl_menu.TabIndex = 0;
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(230, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1054, 75);
            this.Pnl_Titulo.TabIndex = 1;
            // 
            // Pnl_Barra_Listado
            // 
            this.Pnl_Barra_Listado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Pnl_Barra_Listado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Barra_Listado.Location = new System.Drawing.Point(230, 511);
            this.Pnl_Barra_Listado.Name = "Pnl_Barra_Listado";
            this.Pnl_Barra_Listado.Size = new System.Drawing.Size(1054, 100);
            this.Pnl_Barra_Listado.TabIndex = 2;
            // 
            // Pnl_Contenido
            // 
            this.Pnl_Contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.Pnl_Contenido.Controls.Add(this.iconButton1);
            this.Pnl_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contenido.Location = new System.Drawing.Point(230, 75);
            this.Pnl_Contenido.Name = "Pnl_Contenido";
            this.Pnl_Contenido.Size = new System.Drawing.Size(1054, 436);
            this.Pnl_Contenido.TabIndex = 3;
            // 
            // Pnl_logo
            // 
            this.Pnl_logo.Controls.Add(this.pictureBox1);
            this.Pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_logo.Name = "Pnl_logo";
            this.Pnl_logo.Size = new System.Drawing.Size(230, 150);
            this.Pnl_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sol_PuntoVenta.Presentacion.Properties.Resources.reports;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(187, 106);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(100, 30);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "DashBoard";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Frm_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.Pnl_Contenido);
            this.Controls.Add(this.Pnl_Barra_Listado);
            this.Controls.Add(this.Pnl_Titulo);
            this.Controls.Add(this.Pnl_menu);
            this.Name = "Frm_DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DashBoard";
            this.Pnl_menu.ResumeLayout(false);
            this.Pnl_Contenido.ResumeLayout(false);
            this.Pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_menu;
        private System.Windows.Forms.Panel Pnl_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Panel Pnl_Barra_Listado;
        private System.Windows.Forms.Panel Pnl_Contenido;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}