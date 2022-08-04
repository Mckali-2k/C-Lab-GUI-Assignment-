using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1(string uName)
        {

            InitializeComponent();
            lbl_logedInUser.Text = uName;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string num = txt_number.Text;
            string date = dateTimePicker1.Value.ToString();
            string inventoryNumber = txt_inventory.Text;
            string objName = txt_objName.Text;
            string count = txt_count.Text;
            string price = txt_price.Text;
            string options;
           


            Class1 c = new Class1();

            c.NAME = num;
            c.DATE = date;
            c.INVENTORYNUMBER= inventoryNumber;
            c.OBJNAME = objName;
            c.COUNT = count;
            c.PRICE = price;

            foreach(var item in chk_options.CheckedItems)
            {
                c.OPTIONS += item.ToString();
            }
          

            c.save();

            dt_products.DataSource = null;
            dt_products.DataSource = c.getAll();
            MessageBox.Show(c.OPTIONS);


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dt_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void txt_number_Validating(object sender, CancelEventArgs e)
        {
            Regex nameCheck = new Regex(@"^ [a-z] || [A-Z]$");
            Regex numbercheck = new Regex(@"^ [0-9]{3}-[0-9]{3}-[0-9]{4}$");
            Regex inventorycheck = new Regex(@"^ [0-9]{3}-[0-9]{3}$");
            Regex priceAndCountCheck = new Regex(@"^ [0-9]$");

            if(!string.IsNullOrEmpty(txt_number.Text) || string.IsNullOrEmpty(txt_inventory.Text) || string.IsNullOrEmpty(txt_objName.Text) || string.IsNullOrEmpty(txt_count.Text) || string.IsNullOrEmpty(txt_price.Text))
            {
                if (!numbercheck.IsMatch(txt_number.Text))
                {
                    errorProvider1.SetError(txt_number, "The Number Format should be ***-***-****");
                }

                if (!inventorycheck.IsMatch(txt_inventory.Text))
                {
                    errorProvider1.SetError(txt_inventory, "The Number Format sould be ***-***");
                }

                if (!nameCheck.IsMatch(txt_objName.Text))
                {
                    errorProvider1.SetError(txt_objName, "The input should be a letter");
                }

                if (!priceAndCountCheck.IsMatch(txt_price.Text)){
                    errorProvider1.SetError(txt_price, "The price should only be a Number");
                }

                if (!priceAndCountCheck.IsMatch(txt_count.Text))
                {
                    errorProvider1.SetError(txt_count, "The count should only be a Number");
                }
            }

            else
            {
                errorProvider1.Clear();
            }

            //if (txt_objName.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txt_objName, "Must not be Empty");

            //}
            //else
            //{
            //    errorProvider1.SetError(txt_objName, "");
            //}

            //if (txt_sku.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txt_sku, "Must not be Empty");

            //}
            //else
            //{
            //    errorProvider1.SetError(txt_sku, "");
            //}

            //if (txt_number.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txt_number, "Must not be Empty");

            //}
            //else
            //{
            //    errorProvider1.SetError(txt_number, "");
            //}
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_telebir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_logedInUser_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
