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

            if ( txt_userName.Text == "admin" && txt_pswd.Text == "admin")
            {
                login();
            }
                
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txt_pswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                login();
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                reset();
            }
        }

       private void login()
        {
            string userName = txt_userName.Text;

            Hide();

            Form1 f1 = new Form1();
            f1.Show();
        }

        private void reset()
        {
            txt_pswd.Text = "";
            txt_userName.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
// is mdi( from property)
