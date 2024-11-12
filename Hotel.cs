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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void BtnHotelServicesPay_Click(object sender, EventArgs e)
        {
            {
                string connectionString = @"data source=DESKTOP-5KSG9EL; initial catalog=TravelEase1; integrated security=True";
                SqlConnection conobj = new SqlConnection(connectionString);

                try
                {
                    conobj.Open();

                    if (!string.IsNullOrEmpty(txtHotelName.Text) && !string.IsNullOrEmpty(txtHotelEmail.Text) && !string.IsNullOrEmpty(cmbSelectHotel.Text))
                    {
                        string sql = "insert into TravelEase_Hotel2 (Hotel_Name, Cus_Email, Cus_Name) values (@HName, @Email, @Name)";
                        SqlCommand command = new SqlCommand(sql, conobj);
                        command.Parameters.AddWithValue("@HName", cmbSelectHotel.Text);
                        command.Parameters.AddWithValue("@Email", txtHotelEmail.Text);
                        command.Parameters.AddWithValue("@Name", txtHotelName.Text);

                        command.ExecuteNonQuery();
                        conobj.Close();

                        Payment payment = new Payment();
                        payment.Show();
                        this.Hide();

                        double totalBill = 0;
                        int HotelSelct = cmbSelectHotel.SelectedIndex;
                        int DayStay = 0;

                        if (int.TryParse(txtHotelDayStay.Text, out DayStay))
                        {
                            if (HotelSelct == 1 || HotelSelct == 5 || HotelSelct == 9 || HotelSelct == 13 ||
                                HotelSelct == 17 || HotelSelct == 21 || HotelSelct == 25 || HotelSelct == 29)
                            {
                                totalBill = 100000 * DayStay;
                            }
                            else if (HotelSelct == 2 || HotelSelct == 6 || HotelSelct == 10 || HotelSelct == 14 ||
                                     HotelSelct == 18 || HotelSelct == 22 || HotelSelct == 26 || HotelSelct == 30)
                            {
                                totalBill = 150000 * DayStay;
                            }
                            else
                            {
                                totalBill = 130000 * DayStay;
                            }

                            MessageBox.Show("Your Hotel Price is " + totalBill.ToString("C")); 
                        }
                        else
                        {
                            MessageBox.Show("Please provide a valid number of days.");
                        }
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


        }

        private void BtnHSClear_Click(object sender, EventArgs e)
        {
            txtHotelDayStay.Text = string.Empty;
            txtHotelEmail.Text = string.Empty;
            txtHotelName.Text = string.Empty;
            cmbSelectHotel.Text = string.Empty;
        }

        private void BtnHotelServiceBack_Click(object sender, EventArgs e)
        {
            ServiceArea serviceArea = new ServiceArea();
            serviceArea.Show();
            this.Hide();
        }
    }
}
