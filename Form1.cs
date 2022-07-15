using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string num = txt_number.Text;
            string date = dateTimePicker2.Value.ToString();
            string sku = txt_sku.Text;
            string objName = txt_objName.Text;
            string count = txt_count.Text;
            string price = txt_price.Text;

            Class1 c = new Class1();

            c.NAME = num;
            c.DATE = date;
            c.SKU = sku;
            c.OBJNAME = objName;
            c.COUNT = Convert.ToInt32(count);
            c.PRICE = Convert.ToDouble(price);

            c.save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
