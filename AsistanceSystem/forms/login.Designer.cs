namespace AsistanceSystem.forms
{
    partial class login
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
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.iconbtnAccept = new FontAwesome.Sharp.IconButton();
            this.iconBtnCancel = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(134, 101);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(188, 23);
            this.txtUsers.TabIndex = 1;
            // 
            // txtAccess
            // 
            this.txtAccess.Location = new System.Drawing.Point(131, 140);
            this.txtAccess.Multiline = true;
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.PasswordChar = '*';
            this.txtAccess.Size = new System.Drawing.Size(191, 22);
            this.txtAccess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de Asistencia ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Powered by @AsistanceSystem. All Rights Reserved\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::AsistanceSystem.Properties.Resources.lamp__1_;
            this.pictureBox3.Location = new System.Drawing.Point(12, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // iconbtnAccept
            // 
            this.iconbtnAccept.IconChar = FontAwesome.Sharp.IconChar.LifeRing;
            this.iconbtnAccept.IconColor = System.Drawing.Color.DarkRed;
            this.iconbtnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAccept.Location = new System.Drawing.Point(87, 234);
            this.iconbtnAccept.Name = "iconbtnAccept";
            this.iconbtnAccept.Size = new System.Drawing.Size(75, 57);
            this.iconbtnAccept.TabIndex = 11;
            this.iconbtnAccept.Text = "Acceptar";
            this.iconbtnAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconbtnAccept.UseVisualStyleBackColor = true;
            this.iconbtnAccept.Click += new System.EventHandler(this.iconbtnAccept_Click);
            // 
            // iconBtnCancel
            // 
            this.iconBtnCancel.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconBtnCancel.IconColor = System.Drawing.Color.Black;
            this.iconBtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancel.Location = new System.Drawing.Point(230, 234);
            this.iconBtnCancel.Name = "iconBtnCancel";
            this.iconBtnCancel.Size = new System.Drawing.Size(75, 57);
            this.iconBtnCancel.TabIndex = 12;
            this.iconBtnCancel.Text = "Cancelar";
            this.iconBtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnCancel.UseVisualStyleBackColor = true;
            this.iconBtnCancel.Click += new System.EventHandler(this.iconBtnCancel_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(87, 92);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 32);
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(87, 130);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(41, 32);
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(393, 422);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconBtnCancel);
            this.Controls.Add(this.iconbtnAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccess);
            this.Controls.Add(this.txtUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconbtnAccept;
        private FontAwesome.Sharp.IconButton iconBtnCancel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}