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
    public partial class Form2 : Form
    {
        //public static string userName;

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;

            if ( txt_userName.Text == "admin" && txt_pswd.Text == "admin")
            {
                this.Hide();

                Form1 f1 = new Form1(userName);
                f1.Show();
            }
                
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }
    }
}
