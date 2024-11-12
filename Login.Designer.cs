namespace GUIProject
{
    partial class Login
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
            this.txtLEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtLNIC = new System.Windows.Forms.TextBox();
            this.lblLLogin = new System.Windows.Forms.Label();
            this.lblLEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLNIC = new System.Windows.Forms.Label();
            this.BtnLBack = new System.Windows.Forms.Button();
            this.BtnLLogin = new System.Windows.Forms.Button();
            this.BtnLclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLEmail
            // 
            this.txtLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLEmail.Location = new System.Drawing.Point(340, 280);
            this.txtLEmail.Name = "txtLEmail";
            this.txtLEmail.Size = new System.Drawing.Size(323, 34);
            this.txtLEmail.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(340, 225);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(323, 34);
            this.txtLName.TabIndex = 1;
            // 
            // txtLNIC
            // 
            this.txtLNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLNIC.Location = new System.Drawing.Point(340, 176);
            this.txtLNIC.Name = "txtLNIC";
            this.txtLNIC.Size = new System.Drawing.Size(323, 34);
            this.txtLNIC.TabIndex = 2;
            // 
            // lblLLogin
            // 
            this.lblLLogin.AutoSize = true;
            this.lblLLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLLogin.Location = new System.Drawing.Point(278, 28);
            this.lblLLogin.Name = "lblLLogin";
            this.lblLLogin.Size = new System.Drawing.Size(306, 95);
            this.lblLLogin.TabIndex = 3;
            this.lblLLogin.Text = "LOGIN";
            // 
            // lblLEmail
            // 
            this.lblLEmail.AutoSize = true;
            this.lblLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLEmail.ForeColor = System.Drawing.Color.White;
            this.lblLEmail.Location = new System.Drawing.Point(137, 286);
            this.lblLEmail.Name = "lblLEmail";
            this.lblLEmail.Size = new System.Drawing.Size(74, 29);
            this.lblLEmail.TabIndex = 4;
            this.lblLEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(137, 228);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblLNIC
            // 
            this.lblLNIC.AutoSize = true;
            this.lblLNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNIC.ForeColor = System.Drawing.Color.White;
            this.lblLNIC.Location = new System.Drawing.Point(137, 176);
            this.lblLNIC.Name = "lblLNIC";
            this.lblLNIC.Size = new System.Drawing.Size(60, 29);
            this.lblLNIC.TabIndex = 6;
            this.lblLNIC.Text = "NIC ";
            // 
            // BtnLBack
            // 
            this.BtnLBack.BackColor = System.Drawing.Color.Navy;
            this.BtnLBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLBack.ForeColor = System.Drawing.Color.White;
            this.BtnLBack.Location = new System.Drawing.Point(716, 412);
            this.BtnLBack.Name = "BtnLBack";
            this.BtnLBack.Size = new System.Drawing.Size(125, 52);
            this.BtnLBack.TabIndex = 7;
            this.BtnLBack.Text = "Back";
            this.BtnLBack.UseVisualStyleBackColor = false;
            this.BtnLBack.Click += new System.EventHandler(this.BtnLBack_Click);
            // 
            // BtnLLogin
            // 
            this.BtnLLogin.BackColor = System.Drawing.Color.Navy;
            this.BtnLLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLLogin.Location = new System.Drawing.Point(225, 412);
            this.BtnLLogin.Name = "BtnLLogin";
            this.BtnLLogin.Size = new System.Drawing.Size(125, 52);
            this.BtnLLogin.TabIndex = 8;
            this.BtnLLogin.Text = "Login";
            this.BtnLLogin.UseVisualStyleBackColor = false;
            this.BtnLLogin.Click += new System.EventHandler(this.BtnLLogin_Click);
            // 
            // BtnLclear
            // 
            this.BtnLclear.BackColor = System.Drawing.Color.Navy;
            this.BtnLclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLclear.ForeColor = System.Drawing.Color.White;
            this.BtnLclear.Location = new System.Drawing.Point(472, 412);
            this.BtnLclear.Name = "BtnLclear";
            this.BtnLclear.Size = new System.Drawing.Size(125, 52);
            this.BtnLclear.TabIndex = 9;
            this.BtnLclear.Text = "Clear";
            this.BtnLclear.UseVisualStyleBackColor = false;
            this.BtnLclear.Click += new System.EventHandler(this.BtnLclear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.BtnLclear);
            this.Controls.Add(this.BtnLLogin);
            this.Controls.Add(this.BtnLBack);
            this.Controls.Add(this.lblLNIC);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLEmail);
            this.Controls.Add(this.lblLLogin);
            this.Controls.Add(this.txtLNIC);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtLEmail);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtLNIC;
        private System.Windows.Forms.Label lblLLogin;
        private System.Windows.Forms.Label lblLEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLNIC;
        private System.Windows.Forms.Button BtnLBack;
        private System.Windows.Forms.Button BtnLLogin;
        private System.Windows.Forms.Button BtnLclear;
    }
}