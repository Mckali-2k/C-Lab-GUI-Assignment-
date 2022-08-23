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
    public partial class DetailPage : Form
    {

        private void DetailPage_Load(object sender, EventArgs e)
        {
           
        }

        public DetailPage()
        {
            InitializeComponent();
        }

        public DetailPage(Product items)
        {
            InitializeComponent();

            lbl_numberDisplay.Text = items.NUMBER;
            lbl_dateDisplay.Text = items.DATE;
            lbl_inventoryNumberDisplay.Text = items.INVENTORYNUMBER;
            lbl_objectNameDisplay.Text = items.OBJNAME;
            lbl_countDisplay.Text = items.COUNT;
            lbl_priceDisplay.Text = items.PRICE;
        }

    }
}
