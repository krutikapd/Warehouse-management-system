using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshopmanagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            dashBoard dashboard = new dashBoard();
            dashboard.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
