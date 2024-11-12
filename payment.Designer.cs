namespace GUIProject
{
    partial class Payment
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblPMethord = new System.Windows.Forms.Label();
            this.lblPEmail = new System.Windows.Forms.Label();
            this.cmbPMethord = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.BtnPBack = new System.Windows.Forms.Button();
            this.BtnPpay = new System.Windows.Forms.Button();
            this.lblPName = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.BtnPExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPayment.Location = new System.Drawing.Point(254, 22);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(446, 95);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "PAYMENT";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.White;
            this.lblAccountNumber.Location = new System.Drawing.Point(62, 385);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(254, 29);
            this.lblAccountNumber.TabIndex = 17;
            this.lblAccountNumber.Text = "Enter Account Number";
            // 
            // lblPMethord
            // 
            this.lblPMethord.AutoSize = true;
            this.lblPMethord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMethord.ForeColor = System.Drawing.Color.White;
            this.lblPMethord.Location = new System.Drawing.Point(62, 238);
            this.lblPMethord.Name = "lblPMethord";
            this.lblPMethord.Size = new System.Drawing.Size(275, 29);
            this.lblPMethord.TabIndex = 18;
            this.lblPMethord.Text = "Select Payment Methord";
            // 
            // lblPEmail
            // 
            this.lblPEmail.AutoSize = true;
            this.lblPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEmail.ForeColor = System.Drawing.Color.White;
            this.lblPEmail.Location = new System.Drawing.Point(62, 165);
            this.lblPEmail.Name = "lblPEmail";
            this.lblPEmail.Size = new System.Drawing.Size(74, 29);
            this.lblPEmail.TabIndex = 19;
            this.lblPEmail.Text = "Email";
            // 
            // cmbPMethord
            // 
            this.cmbPMethord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPMethord.FormattingEnabled = true;
            this.cmbPMethord.Items.AddRange(new object[] {
            "EPay",
            "Card Payment"});
            this.cmbPMethord.Location = new System.Drawing.Point(381, 230);
            this.cmbPMethord.Name = "cmbPMethord";
            this.cmbPMethord.Size = new System.Drawing.Size(450, 37);
            this.cmbPMethord.TabIndex = 20;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(381, 382);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(450, 34);
            this.txtAccountNumber.TabIndex = 22;
            // 
            // txtPEmail
            // 
            this.txtPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPEmail.Location = new System.Drawing.Point(381, 162);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(450, 34);
            this.txtPEmail.TabIndex = 24;
            // 
            // BtnPBack
            // 
            this.BtnPBack.BackColor = System.Drawing.Color.Navy;
            this.BtnPBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPBack.ForeColor = System.Drawing.Color.White;
            this.BtnPBack.Location = new System.Drawing.Point(399, 475);
            this.BtnPBack.Name = "BtnPBack";
            this.BtnPBack.Size = new System.Drawing.Size(338, 52);
            this.BtnPBack.TabIndex = 25;
            this.BtnPBack.Text = "Choice Other Services";
            this.BtnPBack.UseVisualStyleBackColor = false;
            this.BtnPBack.Click += new System.EventHandler(this.BtnPBack_Click);
            // 
            // BtnPpay
            // 
            this.BtnPpay.BackColor = System.Drawing.Color.Navy;
            this.BtnPpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPpay.ForeColor = System.Drawing.Color.White;
            this.BtnPpay.Location = new System.Drawing.Point(191, 475);
            this.BtnPpay.Name = "BtnPpay";
            this.BtnPpay.Size = new System.Drawing.Size(125, 52);
            this.BtnPpay.TabIndex = 26;
            this.BtnPpay.Text = "Pay";
            this.BtnPpay.UseVisualStyleBackColor = false;
            this.BtnPpay.Click += new System.EventHandler(this.BtnPpay_Click);
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.White;
            this.lblPName.Location = new System.Drawing.Point(62, 107);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(78, 29);
            this.lblPName.TabIndex = 27;
            this.lblPName.Text = "Name";
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(381, 107);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(450, 34);
            this.txtPName.TabIndex = 28;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.ForeColor = System.Drawing.Color.White;
            this.lblBankName.Location = new System.Drawing.Point(62, 316);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(138, 29);
            this.lblBankName.TabIndex = 29;
            this.lblBankName.Text = "Bank Name";
            // 
            // txtBankName
            // 
            this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Location = new System.Drawing.Point(381, 311);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(450, 34);
            this.txtBankName.TabIndex = 30;
            // 
            // BtnPExit
            // 
            this.BtnPExit.BackColor = System.Drawing.Color.Navy;
            this.BtnPExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPExit.ForeColor = System.Drawing.Color.White;
            this.BtnPExit.Location = new System.Drawing.Point(815, 475);
            this.BtnPExit.Name = "BtnPExit";
            this.BtnPExit.Size = new System.Drawing.Size(125, 52);
            this.BtnPExit.TabIndex = 31;
            this.BtnPExit.Text = "Exit";
            this.BtnPExit.UseVisualStyleBackColor = false;
            this.BtnPExit.Click += new System.EventHandler(this.BtnPExit_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.BtnPExit);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.BtnPpay);
            this.Controls.Add(this.BtnPBack);
            this.Controls.Add(this.txtPEmail);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.cmbPMethord);
            this.Controls.Add(this.lblPEmail);
            this.Controls.Add(this.lblPMethord);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblPayment);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblPMethord;
        private System.Windows.Forms.Label lblPEmail;
        private System.Windows.Forms.ComboBox cmbPMethord;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Button BtnPBack;
        private System.Windows.Forms.Button BtnPpay;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Button BtnPExit;
    }
}