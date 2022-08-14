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
       

        public Form1()
        {

            InitializeComponent();
           // lbl_logedInUser.Text = uName;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string num = txt_number.Text;
            string date = dateTimePicker1.Value.ToString();
            string inventoryNumber = txt_inventory.Text;
            string objName = txt_objName.Text;
            string count = txt_count.Text;
            string price = txt_price.Text;
            bool paypal = rb_payPal.Checked;
            bool telebir = rb_telebir.Checked;


            Product c = new Product();

            c.NAME = num;
            c.DATE = date;
            c.INVENTORYNUMBER= inventoryNumber;
            c.OBJNAME = objName;
            c.COUNT = count;
            c.PRICE = price;
            c.PAYPAL = paypal;
            c.TELEBIR = telebir;

            foreach(var item in chk_options.CheckedItems)
            {
                c.OPTIONS += item.ToString();
            }

            if (chk_options.CheckedItems.Count != 0)
            {
                foreach (var payment in gb_payment.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name)
                {
                    c.PAYMENT += payment.ToString();
                }
            }

            if (chk_options.CheckedItems.Count != 0)
            {
                foreach (var delivery in gb_delivery.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name)
                {
                    c.PAYMENT += delivery.ToString();
                }
            }

            c.save();

            dt_products.DataSource = null;
            dt_products.DataSource = Product.getAll();
            //MessageBox.Show(c.OPTIONS);


            //foreach(var item in Product.getAll()) 
            //{
            //    ProductCard p = new ProductCard();
            //    p.PRICE += "Price: " + item.PRICE;
            //    p.TITLE = item.OBJNAME;
            //    p.DESC = item.INVENTORYNUMBER;

            //    productCard2.Controls.Add(p);
            //}

            productCard2.TITLE = "Name: " + objName;
            productCard2.PRICE = "Price: " + price; 
            productCard2.DESC = "Desc: " + inventoryNumber; 


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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {

            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                txt_search.Text = "";
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if (rb_byName.Checked)
            {
                try
                {
                    Product i = Product.SearchByName(txt_search.Text);
                    MessageBox.Show($"Object Name = {i.OBJNAME}\nCount = {i.COUNT}\nInventory Number = {i.INVENTORYNUMBER}\nPrice = {i.PRICE}");
                }
                catch (Exception c)
                {
                    MessageBox.Show("No results found!");
                }
            }
            else if (rb_invNo.Checked)
            {
                    try
                    {
                        Product i = Product.SearchByInventoryNumber(txt_search.Text);
                        MessageBox.Show($"Object Name = {i.OBJNAME}\nCount = {i.COUNT}\nInventory Number = {i.INVENTORYNUMBER}\nPrice = {i.PRICE}");
                    }
                    catch (Exception c)
                    {
                        MessageBox.Show("No results found!");
                    }
            }
            else if (rb_price.Checked)
            {
                try
                {
                    List<Product> i = Product.searchByPrice(txt_search.Text);

                    foreach (Product item in i)
                    {
                        MessageBox.Show($"Object Name = {item.OBJNAME}\nCount = {item.COUNT}\nInventory Number = {item.INVENTORYNUMBER}\nPrice = {item.PRICE}");
                    }


                }

                catch (Exception c)
                {
                    MessageBox.Show("No results found!");
                }
            }
        
            else
            {
                MessageBox.Show("Please Choose The Option");
            }
                

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}


