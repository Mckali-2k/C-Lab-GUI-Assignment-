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
    public partial class ProductCard : UserControl
    {

       
        //private string price;

        private string price;
        private string title;
        private string desc;


        public string PRICE
        {
            get { return price;  }
            set { price = value; lbl_price.Text = value; }
        }

        public string TITLE
        {
            get { return title; }
            set { title = value; lbl_title.Text = value; }
        }

        public string DESC
        {
            get { return desc; }
            set { desc = value; lbl_desc.Text = value; }
        }



        public ProductCard()
        {
            InitializeComponent();
        }

        private void lbl_desc_Click(object sender, EventArgs e)
        {

        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
