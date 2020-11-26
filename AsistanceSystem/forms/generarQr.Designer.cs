namespace AsistanceSystem.forms
{
    partial class generarQr
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenerar = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSaveQr = new System.Windows.Forms.Button();
            this.imgQr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sistema de Asistencia ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(278, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "General Codigo QR";
            // 
            // txtGenerar
            // 
            this.txtGenerar.Location = new System.Drawing.Point(156, 137);
            this.txtGenerar.Multiline = true;
            this.txtGenerar.Name = "txtGenerar";
            this.txtGenerar.Size = new System.Drawing.Size(150, 49);
            this.txtGenerar.TabIndex = 12;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(156, 212);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(55, 44);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSaveQr
            // 
            this.btnSaveQr.Location = new System.Drawing.Point(251, 212);
            this.btnSaveQr.Name = "btnSaveQr";
            this.btnSaveQr.Size = new System.Drawing.Size(55, 44);
            this.btnSaveQr.TabIndex = 25;
            this.btnSaveQr.Text = "Guardar";
            this.btnSaveQr.UseVisualStyleBackColor = true;
            this.btnSaveQr.Click += new System.EventHandler(this.btnSaveQr_Click);
            // 
            // imgQr
            // 
            this.imgQr.Location = new System.Drawing.Point(337, 137);
            this.imgQr.Name = "imgQr";
            this.imgQr.Size = new System.Drawing.Size(145, 119);
            this.imgQr.TabIndex = 13;
            this.imgQr.TabStop = false;
            // 
            // generarQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 352);
            this.Controls.Add(this.btnSaveQr);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.imgQr);
            this.Controls.Add(this.txtGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "generarQr";
            this.Text = "generarQr";
            this.Load += new System.EventHandler(this.generarQr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenerar;
        private System.Windows.Forms.PictureBox imgQr;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSaveQr;
    }
}