using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Lab_Assignment_4.Model
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Hawariaw" && txt_password.Text == "hawa701")
            {
                MessageBox.Show("Login Successful!");
                InventoryPage ip = new InventoryPage( txt_username.Text );
                ip.Show();
                Hide();
            }
            else
                MessageBox.Show("Incorrect username or password!");

        }
    }
}
