using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class ServiceArea : Form
    {
        public ServiceArea()
        {
            InitializeComponent();
        }

       

        private void BtnSAHotel_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Show();
            this.Hide();
        }

        private void BtnSATransportation_Click(object sender, EventArgs e)
        {
            Transportation transportation = new Transportation();
            transportation.Show();
            this.Hide();
        }

        private void BtnSABack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BtnSALocation_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Show();
            this.Hide();
        }
    }
}
