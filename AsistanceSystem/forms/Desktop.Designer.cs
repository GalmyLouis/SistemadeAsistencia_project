namespace AsistanceSystem.forms
{
    partial class Desktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistema de Asistencia ";
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.Location = new System.Drawing.Point(192, 90);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(75, 61);
            this.btnSaveEmp.TabIndex = 8;
            this.btnSaveEmp.Text = "Agregar empleado";
            this.btnSaveEmp.UseVisualStyleBackColor = true;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Location = new System.Drawing.Point(408, 90);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(75, 61);
            this.btnEditEmp.TabIndex = 9;
            this.btnEditEmp.Text = "Modificar empleado";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(408, 201);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 61);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Generar reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(192, 201);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(75, 61);
            this.btnDeleteEmp.TabIndex = 11;
            this.btnDeleteEmp.Text = "Eliminar empleado";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AsistanceSystem.Properties.Resources.lamp__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Powered by @AsistanceSystem. All Rights Reserved\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 56);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generar codigo QR\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.btnSaveEmp);
            this.Controls.Add(this.label1);
            this.Name = "Desktop";
            this.Text = "Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}