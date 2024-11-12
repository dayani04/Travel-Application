namespace GUIProject
{
    partial class Thank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thank));
            this.lblThankyou = new System.Windows.Forms.Label();
            this.BtnTYExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThankyou
            // 
            this.lblThankyou.AutoSize = true;
            this.lblThankyou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblThankyou.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankyou.ForeColor = System.Drawing.Color.White;
            this.lblThankyou.Location = new System.Drawing.Point(56, 197);
            this.lblThankyou.Name = "lblThankyou";
            this.lblThankyou.Size = new System.Drawing.Size(834, 63);
            this.lblThankyou.TabIndex = 0;
            this.lblThankyou.Text = "Thank You For Using Our Service";
            // 
            // BtnTYExit
            // 
            this.BtnTYExit.BackColor = System.Drawing.Color.Navy;
            this.BtnTYExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTYExit.ForeColor = System.Drawing.Color.White;
            this.BtnTYExit.Location = new System.Drawing.Point(745, 428);
            this.BtnTYExit.Name = "BtnTYExit";
            this.BtnTYExit.Size = new System.Drawing.Size(135, 49);
            this.BtnTYExit.TabIndex = 3;
            this.BtnTYExit.Text = "Exit";
            this.BtnTYExit.UseVisualStyleBackColor = false;
            this.BtnTYExit.Click += new System.EventHandler(this.BtnTYExit_Click);
            // 
            // Thank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.BtnTYExit);
            this.Controls.Add(this.lblThankyou);
            this.DoubleBuffered = true;
            this.Name = "Thank";
            this.Text = "Thank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThankyou;
        private System.Windows.Forms.Button BtnTYExit;
    }
}