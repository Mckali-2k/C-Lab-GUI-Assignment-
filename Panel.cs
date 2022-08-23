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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            panelIndicator.Top = 76;

            flowLayoutPanel1.BackColor = Color.Green;
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            panelIndicator.Top = 240;
            flowLayoutPanel1.BackColor = Color.Yellow;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            panelIndicator.Top = 390;
            flowLayoutPanel1.BackColor = Color.Red;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void card_click(object o, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            List<Product> products = Product.getAll();

            flowLayoutPanel1.Controls.Clear();

            foreach (var item in products)
            {
                ProductCard p = new ProductCard();

                p.PRICE = "PRICE: " + item.PRICE;
                p.TITLE = "NAME: " + item.OBJNAME;
                p.DESC = "INVENTORY NO: " + item.INVENTORYNUMBER;
                p.Click += (object obj, EventArgs ev) =>
                {
                    DetailPage dp = new DetailPage(item);
                    dp.Show();
                };

                flowLayoutPanel1.Controls.Add(p);

            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
