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
using System.Xml.Linq;

namespace GUIProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"data source=DESKTOP-5KSG9EL; initial catalog=TravelEase1; integrated security=True";
                SqlConnection conobj = new SqlConnection(connectionString);
                conobj.Open();

                if (!string.IsNullOrEmpty(txtLNIC.Text) && !string.IsNullOrEmpty(txtLName.Text) && !string.IsNullOrEmpty(txtLEmail.Text))
                {
                    string sql = "insert into TravelEase_Login1 (Cus_NIC ,Cus_Name,Cus_Email) values (@NIC, @Name, @Email)";
                    SqlCommand command = new SqlCommand(sql, conobj);
                    command.Parameters.AddWithValue("@NIC", txtLNIC.Text);
                    command.Parameters.AddWithValue("@Name", txtLName.Text);
                    command.Parameters.AddWithValue("@Email", txtLEmail.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Welcome To Our Service!");
                    conobj.Close();

                    ServiceArea serviceArea = new ServiceArea();
                    serviceArea.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login is not successful. Please fill in all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnLclear_Click(object sender, EventArgs e)
        {
            txtLEmail.Text = String.Empty;
            txtLNIC.Text = String.Empty;
            txtLName.Text = String.Empty;
            
        }

        private void BtnLBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
