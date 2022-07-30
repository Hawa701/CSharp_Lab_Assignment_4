using CSharp_Lab_Assignment_4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CSharp_Lab_Assignment_4
{
    public partial class InventoryPage : Form
    {
        public InventoryPage(string username)
        {
            InitializeComponent();
            lbl_welcomeBack.Text += username + "!";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"^[0-9]");
            Regex rg2 = new Regex(@"^[a-zA-Z]");

            errorProvider.Clear();

            //Checking if the inputs are given
            if (string.IsNullOrEmpty(txt_objectName.Text))
                errorProvider.SetError(txt_objectName, "The object name must be provided!");

            else if (string.IsNullOrEmpty(txt_Number.Text))
                errorProvider.SetError(txt_Number, "The number of object must be provided!");

            else if (string.IsNullOrEmpty(txt_count.Text))
                errorProvider.SetError(txt_count, "The count of the object must be provided!");

            else if (string.IsNullOrEmpty(txt_inventoryNumber.Text))
                errorProvider.SetError(txt_inventoryNumber, "The inventory number of the object must be provided!");

            else if (string.IsNullOrEmpty(txt_price.Text))
                errorProvider.SetError(txt_price, "The price of the object must be provided!");
            else if (!rb_Available.Checked && !rb_NotAvailable.Checked)
                errorProvider.SetError(groupBox, "One of the radio buttons must be checked!");

            //Validating the inputs
            else if (!rg2.IsMatch(txt_objectName.Text))
                errorProvider.SetError(txt_objectName, "The Object name must only be words!");

            else if (!rg.IsMatch(txt_Number.Text))
                errorProvider.SetError(txt_Number, "The number must be a numeric type!");

            else if (!rg.IsMatch(txt_count.Text))
                errorProvider.SetError(txt_count, "The count must be a numeric type!");

            else if (!rg.IsMatch(txt_inventoryNumber.Text))
                errorProvider.SetError(txt_inventoryNumber, "The inventory number must be a numeric type!");

            else if (!rg.IsMatch(txt_price.Text))
                errorProvider.SetError(txt_price, "The price must be a numeric type!");

            else
            {
                errorProvider.Clear();
                Product P = new Product
                {
                    Number = Convert.ToInt32(txt_Number.Text),
                    Date = txt_date.Text,
                    InventoryNumber = Convert.ToInt32(txt_inventoryNumber.Text),
                    ObjectName = txt_objectName.Text,
                    Count = Convert.ToInt32(txt_count.Text),
                    Price = Convert.ToDouble(txt_price.Text)
                };

                if (rb_Available.Checked == true)
                    P.Availability = rb_Available.Text;
                else
                    P.Availability = rb_NotAvailable.Text;

                foreach (var Item in chk_colorChoice.CheckedItems)
                    P.CheckedBoxes += Item.ToString() + "\n";

                P.save();

                dvList.DataSource = null;
                dvList.DataSource = Product.GetAllProduct();
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Number.Text = "";
            txt_date.Text = "";
            txt_inventoryNumber.Text = "";
            txt_objectName.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
            rb_Available.Checked = false;
            rb_NotAvailable.Checked = false;
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            Hide();
        }
    }
}
