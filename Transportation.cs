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
    public partial class Transportation : Form
    {
        public Transportation()
        {
            InitializeComponent();
        }

        private void BtnTSSubmit_Click(object sender, EventArgs e)
        {
            try

            {
                string connectionString = @"data source=DESKTOP-5KSG9EL; initial catalog=TravelEase1; integrated security=True";
                using (SqlConnection conobj = new SqlConnection(connectionString))
                {
                    conobj.Open();

                    if (!string.IsNullOrEmpty(txtTSName.Text) && !string.IsNullOrEmpty(txtTSEmail.Text) && !string.IsNullOrEmpty(cmbTSMeans.Text) && !string.IsNullOrEmpty(txtDayVehical.Text))
                    {
                        string sql = "INSERT INTO TravelEase_Transportaion (Cus_Name, Cus_Email, Means, No_VDay) VALUES (@Name, @Email, @Means, @NoVDay)";
                        SqlCommand command = new SqlCommand(sql, conobj);
                        command.Parameters.AddWithValue("@Name", txtTSName.Text);
                        command.Parameters.AddWithValue("@Email", txtTSEmail.Text);
                        command.Parameters.AddWithValue("@Means", cmbTSMeans.Text);
                        command.Parameters.AddWithValue("@NoVDay", Convert.ToInt32(txtDayVehical.Text));

                        command.ExecuteNonQuery();

                        double Ttotal = 0;
                        int MeansIndex = cmbTSMeans.SelectedIndex;
                        int NoVDay = Convert.ToInt32(txtDayVehical.Text);

                        if (MeansIndex == 0)
                        {
                            Ttotal = 100000 * NoVDay;
                        }
                        else if (MeansIndex == 1)
                        {
                            Ttotal = 75000 * NoVDay;
                        }
                        else if (MeansIndex == 2)
                        {
                            Ttotal = 50000 * NoVDay;
                        }
                        else if (MeansIndex == 3)
                        {
                            Ttotal = 20000 * NoVDay;
                        }
                        else if (MeansIndex == 4)
                        {
                            Ttotal = 1000 * NoVDay;
                        }
                        MessageBox.Show("Transportation Vehicle price is " + Ttotal);

                        Payment payment = new Payment();
                        payment.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnTSClear_Click(object sender, EventArgs e)
        {
            txtDayVehical.Text = string.Empty;
            txtTSEmail.Text = string.Empty;
            txtTSName.Text = string.Empty;
            cmbTSMeans.Text = string.Empty;
        }

        private void BtnTSBack_Click(object sender, EventArgs e)
        {
            ServiceArea serviceArea = new ServiceArea();
            serviceArea.Show();
            this.Hide();
        }
    }
}
