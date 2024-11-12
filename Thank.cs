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
    public partial class Thank : Form
    {
        public Thank()
        {
            InitializeComponent();
        }

        private void BtnTYExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
