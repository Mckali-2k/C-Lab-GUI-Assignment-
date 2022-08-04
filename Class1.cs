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
        private string name, date, objName, inventoryNumber;
        private  string count;
        private string price;
        private bool isAvailable;
        private bool discount;
        private bool storeCredit;
        private bool delivery;
        private bool coupon;
        private string options = "";
        private bool telebir;

        static List<Class1> class1s = new List<Class1>(); // 1 instance

        public string OPTIONS
        {
            set { options = value; }
            get { return options; }
        }

        public bool ISAVILABLE
        {
            set { isAvailable = value; }
            get { return isAvailable; }
        }
        public bool STORECREDIT
        {
            set { storeCredit = value; }
            get { return storeCredit; }
        }
        public bool DELIVERY
        {
            set { delivery = value; }
            get { return delivery; }
        }
        public bool COUPON
        {
            set { coupon = value; }
            get { return coupon; }
        }
        public bool DISCOUNT
        {
            set { discount = value; }
            get { return discount; }
        }


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

        public string INVENTORYNUMBER
        {
            set { inventoryNumber = value; }
            get { return inventoryNumber; }
        }

        public string COUNT
        {
            set { count = value; }
            get { return count; }
        }

        public string PRICE
        {
            set { price = value; }
            get { return price; }
        }


        public Class1(string name, string date, string objName, string inventoryNumber, string count, string price)
        {
            this.name = name;
            this.date = date;
            this.objName = objName;
            this.inventoryNumber = inventoryNumber;
            this.count = count;
            this.price = price;
        }

        public Class1() { }

        public List<Class1> getAll()
        {
            return class1s;
        }

        public void save()
        {
           /* var products = new List<string>();
            products.Add(this.price);*/

            class1s.Add(this);

     /*       MessageBox.Show("Succesfully Added");*/
        }
    }
}
