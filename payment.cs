using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void BtnPBack_Click(object sender, EventArgs e)
        {
            ServiceArea serviceArea = new ServiceArea();
            serviceArea.Show();
            this.Hide();
        }

        private void BtnPpay_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"data source=DESKTOP-5KSG9EL; initial catalog=TravelEase1; integrated security=True";
                SqlConnection conobj = new SqlConnection(connectionString);
                conobj.Open();

                if (!string.IsNullOrEmpty(txtPName.Text) && !string.IsNullOrEmpty(txtPEmail.Text) && !string.IsNullOrEmpty(cmbPMethord.Text) && !string.IsNullOrEmpty(txtBankName.Text) && !string.IsNullOrEmpty(txtAccountNumber.Text))
                {
                    string sql = "insert into TravelEase_Payment1 (Cus_Name, Cus_Email, Payment_Methord, Bank_Name, Account_Number) values (@Name, @Email, @Methord, @Bank, @Account)";
                    SqlCommand command = new SqlCommand(sql, conobj);
                    command.Parameters.AddWithValue("@Name", txtPName.Text);
                    command.Parameters.AddWithValue("@Email", txtPEmail.Text);
                    command.Parameters.AddWithValue("@Methord", cmbPMethord.Text);
                    command.Parameters.AddWithValue("@Bank", txtBankName.Text);
                    command.Parameters.AddWithValue("@Account", txtAccountNumber.Text);

                    command.ExecuteNonQuery();
                    conobj.Close();

                    MessageBox.Show("Your Payment Is Successful!");

                    Thank thank = new Thank();
                    thank.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnPExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
