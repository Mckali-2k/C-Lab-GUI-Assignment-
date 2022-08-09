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
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form =  this.ActiveMdiChild; // datatype is form

            // if(form != null)
            // {
            //     form.Close();
            // }
            // Mdi is short for Multiple Document Interface

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Form1 form1 = new Form1();
            form1.MdiParent = this; // this tells from1 that this is the parent 
            form1.Show();

        }
    }
}
