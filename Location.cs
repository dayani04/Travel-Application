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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void BtnLocationSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"data source=DESKTOP-5KSG9EL; initial catalog=TravelEase1; integrated security=True";
                SqlConnection conobj = new SqlConnection(connectionString);
                conobj.Open();

                if (!string.IsNullOrEmpty(txtEnterLocationNumber.Text) && !string.IsNullOrEmpty(txtEnterLocationName.Text) && !string.IsNullOrEmpty(txtLocationEmail.Text))
                {
                    string sql = "insert into TravelEase_Location1 (Location_NO, Location_Name, Cus_Email) values (@Number, @Name, @Email)";
                    SqlCommand command = new SqlCommand(sql, conobj);
                    command.Parameters.AddWithValue("@Number", txtEnterLocationNumber.Text);
                    command.Parameters.AddWithValue("@Name", txtEnterLocationName.Text);
                    command.Parameters.AddWithValue("@Email", txtLocationEmail.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("You May Choose Other Services");
                    conobj.Close();

                    Hotel hotel = new Hotel();
                    hotel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Fill in correct data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnLocationClear_Click(object sender, EventArgs e)
        {
            txtLocationEmail.Text = string.Empty;
            txtEnterLocationName.Text = string.Empty;
            txtEnterLocationNumber.Text = string.Empty;
        }

        private void BtnLocationBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Location_Load(object sender, EventArgs e)
        {

        }
    }
}
