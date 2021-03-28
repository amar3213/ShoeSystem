using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeBackOffice
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "p2521296" && txtPassword.Text == "isright12")
            {
                StockManagement form = new StockManagement();
                form.Show();
                this.Hide();
            }
        }
    }
}
