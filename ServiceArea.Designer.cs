namespace GUIProject
{
    partial class ServiceArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceArea));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSATransportation = new System.Windows.Forms.Button();
            this.BtnSAHotel = new System.Windows.Forms.Button();
            this.BtnSALocation = new System.Windows.Forms.Button();
            this.BtnSABack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(124, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "SERVICE AREA";
            // 
            // BtnSATransportation
            // 
            this.BtnSATransportation.BackColor = System.Drawing.Color.Navy;
            this.BtnSATransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSATransportation.ForeColor = System.Drawing.Color.White;
            this.BtnSATransportation.Location = new System.Drawing.Point(743, 314);
            this.BtnSATransportation.Name = "BtnSATransportation";
            this.BtnSATransportation.Size = new System.Drawing.Size(181, 77);
            this.BtnSATransportation.TabIndex = 10;
            this.BtnSATransportation.Text = "Transportation Service";
            this.BtnSATransportation.UseVisualStyleBackColor = false;
            this.BtnSATransportation.Click += new System.EventHandler(this.BtnSATransportation_Click);
            // 
            // BtnSAHotel
            // 
            this.BtnSAHotel.BackColor = System.Drawing.Color.Navy;
            this.BtnSAHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSAHotel.ForeColor = System.Drawing.Color.White;
            this.BtnSAHotel.Location = new System.Drawing.Point(409, 328);
            this.BtnSAHotel.Name = "BtnSAHotel";
            this.BtnSAHotel.Size = new System.Drawing.Size(184, 77);
            this.BtnSAHotel.TabIndex = 11;
            this.BtnSAHotel.Text = "Hotel Service";
            this.BtnSAHotel.UseVisualStyleBackColor = false;
            this.BtnSAHotel.Click += new System.EventHandler(this.BtnSAHotel_Click);
            // 
            // BtnSALocation
            // 
            this.BtnSALocation.BackColor = System.Drawing.Color.Navy;
            this.BtnSALocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSALocation.ForeColor = System.Drawing.Color.White;
            this.BtnSALocation.Location = new System.Drawing.Point(89, 328);
            this.BtnSALocation.Name = "BtnSALocation";
            this.BtnSALocation.Size = new System.Drawing.Size(183, 76);
            this.BtnSALocation.TabIndex = 12;
            this.BtnSALocation.Text = "Location";
            this.BtnSALocation.UseVisualStyleBackColor = false;
            this.BtnSALocation.Click += new System.EventHandler(this.BtnSALocation_Click);
            // 
            // BtnSABack
            // 
            this.BtnSABack.BackColor = System.Drawing.Color.Navy;
            this.BtnSABack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSABack.ForeColor = System.Drawing.Color.White;
            this.BtnSABack.Location = new System.Drawing.Point(799, 456);
            this.BtnSABack.Name = "BtnSABack";
            this.BtnSABack.Size = new System.Drawing.Size(125, 52);
            this.BtnSABack.TabIndex = 13;
            this.BtnSABack.Text = "Back";
            this.BtnSABack.UseVisualStyleBackColor = false;
            this.BtnSABack.Click += new System.EventHandler(this.BtnSABack_Click);
            // 
            // ServiceArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.BtnSABack);
            this.Controls.Add(this.BtnSALocation);
            this.Controls.Add(this.BtnSAHotel);
            this.Controls.Add(this.BtnSATransportation);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ServiceArea";
            this.Text = "ServiceArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSATransportation;
        private System.Windows.Forms.Button BtnSAHotel;
        private System.Windows.Forms.Button BtnSALocation;
        private System.Windows.Forms.Button BtnSABack;
    }
}