namespace AsistanceSystem.forms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PaginaPrincipal = new System.Windows.Forms.Panel();
            this.iconBtnGenerarQr = new FontAwesome.Sharp.IconButton();
            this.iconBtnAsistencia = new FontAwesome.Sharp.IconButton();
            this.iconBtnReportes = new FontAwesome.Sharp.IconButton();
            this.iconBtnEmpleados = new FontAwesome.Sharp.IconButton();
            this.iconScanearQR = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconBtnSignIn = new FontAwesome.Sharp.IconButton();
            this.logged = new FontAwesome.Sharp.IconPictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PaginaPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logged)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaginaPrincipal
            // 
            this.PaginaPrincipal.BackColor = System.Drawing.Color.MidnightBlue;
            this.PaginaPrincipal.Controls.Add(this.iconBtnGenerarQr);
            this.PaginaPrincipal.Controls.Add(this.iconBtnAsistencia);
            this.PaginaPrincipal.Controls.Add(this.iconBtnReportes);
            this.PaginaPrincipal.Controls.Add(this.iconBtnEmpleados);
            this.PaginaPrincipal.Controls.Add(this.iconScanearQR);
            this.PaginaPrincipal.Controls.Add(this.iconButton1);
            this.PaginaPrincipal.Controls.Add(this.panel1);
            this.PaginaPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaginaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PaginaPrincipal.Name = "PaginaPrincipal";
            this.PaginaPrincipal.Size = new System.Drawing.Size(161, 450);
            this.PaginaPrincipal.TabIndex = 0;
            // 
            // iconBtnGenerarQr
            // 
            this.iconBtnGenerarQr.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnGenerarQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnGenerarQr.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnGenerarQr.ForeColor = System.Drawing.Color.White;
            this.iconBtnGenerarQr.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.iconBtnGenerarQr.IconColor = System.Drawing.Color.Teal;
            this.iconBtnGenerarQr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnGenerarQr.IconSize = 44;
            this.iconBtnGenerarQr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnGenerarQr.Location = new System.Drawing.Point(0, 282);
            this.iconBtnGenerarQr.Name = "iconBtnGenerarQr";
            this.iconBtnGenerarQr.Size = new System.Drawing.Size(161, 43);
            this.iconBtnGenerarQr.TabIndex = 11;
            this.iconBtnGenerarQr.Text = "Generar QR";
            this.iconBtnGenerarQr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnGenerarQr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnGenerarQr.UseVisualStyleBackColor = true;
            this.iconBtnGenerarQr.Click += new System.EventHandler(this.iconBtnGenerarQr_Click);
            // 
            // iconBtnAsistencia
            // 
            this.iconBtnAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAsistencia.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAsistencia.ForeColor = System.Drawing.Color.White;
            this.iconBtnAsistencia.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconBtnAsistencia.IconColor = System.Drawing.Color.Teal;
            this.iconBtnAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAsistencia.IconSize = 44;
            this.iconBtnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAsistencia.Location = new System.Drawing.Point(0, 239);
            this.iconBtnAsistencia.Name = "iconBtnAsistencia";
            this.iconBtnAsistencia.Size = new System.Drawing.Size(161, 43);
            this.iconBtnAsistencia.TabIndex = 10;
            this.iconBtnAsistencia.Text = " Asistencia";
            this.iconBtnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAsistencia.UseVisualStyleBackColor = true;
            this.iconBtnAsistencia.Click += new System.EventHandler(this.iconBtnAsistencia_Click);
            // 
            // iconBtnReportes
            // 
            this.iconBtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnReportes.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnReportes.ForeColor = System.Drawing.Color.White;
            this.iconBtnReportes.IconChar = FontAwesome.Sharp.IconChar.Perbyte;
            this.iconBtnReportes.IconColor = System.Drawing.Color.Teal;
            this.iconBtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnReportes.IconSize = 44;
            this.iconBtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnReportes.Location = new System.Drawing.Point(0, 196);
            this.iconBtnReportes.Name = "iconBtnReportes";
            this.iconBtnReportes.Size = new System.Drawing.Size(161, 43);
            this.iconBtnReportes.TabIndex = 9;
            this.iconBtnReportes.Text = "Reportes";
            this.iconBtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnReportes.UseVisualStyleBackColor = true;
            this.iconBtnReportes.Click += new System.EventHandler(this.iconBtnReportes_Click);
            // 
            // iconBtnEmpleados
            // 
            this.iconBtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEmpleados.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.iconBtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.iconBtnEmpleados.IconColor = System.Drawing.Color.Teal;
            this.iconBtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnEmpleados.IconSize = 44;
            this.iconBtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEmpleados.Location = new System.Drawing.Point(0, 153);
            this.iconBtnEmpleados.Name = "iconBtnEmpleados";
            this.iconBtnEmpleados.Size = new System.Drawing.Size(161, 43);
            this.iconBtnEmpleados.TabIndex = 8;
            this.iconBtnEmpleados.Text = "Empleados";
            this.iconBtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnEmpleados.UseVisualStyleBackColor = true;
            this.iconBtnEmpleados.Click += new System.EventHandler(this.iconBtnEmpleados_Click);
            // 
            // iconScanearQR
            // 
            this.iconScanearQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconScanearQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconScanearQR.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconScanearQR.ForeColor = System.Drawing.Color.White;
            this.iconScanearQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.iconScanearQR.IconColor = System.Drawing.Color.Teal;
            this.iconScanearQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconScanearQR.IconSize = 44;
            this.iconScanearQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconScanearQR.Location = new System.Drawing.Point(0, 110);
            this.iconScanearQR.Name = "iconScanearQR";
            this.iconScanearQR.Size = new System.Drawing.Size(161, 43);
            this.iconScanearQR.TabIndex = 7;
            this.iconScanearQR.Text = "Scanear QR";
            this.iconScanearQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconScanearQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconScanearQR.UseVisualStyleBackColor = true;
            this.iconScanearQR.Click += new System.EventHandler(this.iconBtnScanear_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.iconButton1.IconColor = System.Drawing.Color.DarkCyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 49;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 110);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(149, 43);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Sign In";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 110);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.iconBtnSignIn);
            this.panel2.Controls.Add(this.logged);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(161, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 57);
            this.panel2.TabIndex = 1;
            // 
            // iconBtnSignIn
            // 
            this.iconBtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSignIn.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSignIn.ForeColor = System.Drawing.Color.White;
            this.iconBtnSignIn.IconChar = FontAwesome.Sharp.IconChar.Schlix;
            this.iconBtnSignIn.IconColor = System.Drawing.Color.Teal;
            this.iconBtnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSignIn.IconSize = 44;
            this.iconBtnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSignIn.Location = new System.Drawing.Point(391, 8);
            this.iconBtnSignIn.Name = "iconBtnSignIn";
            this.iconBtnSignIn.Size = new System.Drawing.Size(153, 43);
            this.iconBtnSignIn.TabIndex = 7;
            this.iconBtnSignIn.Text = "Cerrar Sesion";
            this.iconBtnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSignIn.UseVisualStyleBackColor = true;
            this.iconBtnSignIn.Click += new System.EventHandler(this.iconBtnSignIn_Click_1);
            // 
            // logged
            // 
            this.logged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logged.BackColor = System.Drawing.Color.Navy;
            this.logged.ForeColor = System.Drawing.Color.Teal;
            this.logged.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.logged.IconColor = System.Drawing.Color.Teal;
            this.logged.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logged.IconSize = 42;
            this.logged.Location = new System.Drawing.Point(592, 12);
            this.logged.Name = "logged";
            this.logged.Size = new System.Drawing.Size(44, 42);
            this.logged.TabIndex = 0;
            this.logged.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(161, 57);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(639, 393);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(138, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sistema de Asistencia ";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PaginaPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PaginaPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logged)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaginaPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton iconBtnReportes;
        public FontAwesome.Sharp.IconButton iconBtnEmpleados;
        public FontAwesome.Sharp.IconButton iconScanearQR;
        public FontAwesome.Sharp.IconPictureBox logged;
        public FontAwesome.Sharp.IconButton iconBtnAsistencia;
        public FontAwesome.Sharp.IconButton iconBtnGenerarQr;
        private FontAwesome.Sharp.IconButton iconBtnSignIn;
    }
}