using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Class1
    {
        private string name, date, objName, sku;
        private  int count;
        private double price;

        public string NAME
        {
            set { name = value; }
            get { return name; }
        }

        public string DATE
        {
            set { date = value; }
            get { return date; }
        }

        public string OBJNAME
        {
            set { objName = value; }
            get { return objName; }
        }

        public string SKU
        {
            set { sku = value; }
            get { return sku; }
        }

        public int COUNT
        {
            set { count = value; }
            get { return count; }
        }

        public double PRICE
        {
            set { price = value; }
            get { return price; }
        }


        public Class1(string name, string date, string objName, string sku, int count, double price)
        {
            this.name = name;
            this.date = date;
            this.objName = objName;
            this.sku = sku;
            this.count = count;
            this.price = price;
        }

        public Class1() { }

        public void save()
        {
            MessageBox.Show("Succesfully Added");
        }
    }
}
