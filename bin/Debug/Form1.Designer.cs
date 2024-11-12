namespace GUIProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTravelEase = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegisterForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTravelEase
            // 
            this.lblTravelEase.AutoSize = true;
            this.lblTravelEase.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelEase.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTravelEase.Location = new System.Drawing.Point(154, 133);
            this.lblTravelEase.Name = "lblTravelEase";
            this.lblTravelEase.Size = new System.Drawing.Size(658, 132);
            this.lblTravelEase.TabIndex = 0;
            this.lblTravelEase.Text = "TravelEase";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Navy;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLogin.Location = new System.Drawing.Point(611, 347);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(214, 57);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegisterForm1
            // 
            this.BtnRegisterForm1.BackColor = System.Drawing.Color.Navy;
            this.BtnRegisterForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegisterForm1.ForeColor = System.Drawing.Color.White;
            this.BtnRegisterForm1.Location = new System.Drawing.Point(142, 347);
            this.BtnRegisterForm1.Name = "BtnRegisterForm1";
            this.BtnRegisterForm1.Size = new System.Drawing.Size(214, 57);
            this.BtnRegisterForm1.TabIndex = 2;
            this.BtnRegisterForm1.Text = "Register";
            this.BtnRegisterForm1.UseVisualStyleBackColor = false;
            this.BtnRegisterForm1.Click += new System.EventHandler(this.BtnRegisterForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.BtnRegisterForm1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.lblTravelEase);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTravelEase;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegisterForm1;
    }
}

