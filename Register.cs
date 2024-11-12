using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUIProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"data source=DESKTOP-5KSG9EL; initial catalog=TravelEase1; integrated security=True";
                SqlConnection conobj = new SqlConnection(connectionString);
                conobj.Open();

                if (!string.IsNullOrEmpty(txtNIC.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text)
                    && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtCountry.Text))
                {
                    string sql = "insert into TravelEase_Registered  values (@NIC, @Name, @Email, @Phone, @Country)";
                    SqlCommand command = new SqlCommand(sql, conobj);
                    command.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@Country", txtCountry.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Welcome To Our Service!");
                    conobj.Close();

                    ServiceArea serviceArea = new ServiceArea();
                    serviceArea.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration is not successful. Please fill in all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
           
        }

        private void btnRBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
