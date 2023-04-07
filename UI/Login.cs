using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restrictor.UI;
using Restrictor.Properties;
using Restrictor;

namespace Restrictor.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "12345689123";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Restrictor main = new Restrictor();
            main.Show();
            this.Hide();
        }
    }
}
