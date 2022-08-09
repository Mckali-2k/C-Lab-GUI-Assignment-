using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Product
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
        private string payments = "";
        private bool telebir;
        private bool payPal;

        static List<Product> products = new List<Product>(); // 1 instance


        public string PAYMENT
        {
            set { payments = value; }
            get { return payments; }
        }


        public bool TELEBIR
        {
            set { telebir = value; }
            get { return telebir; }
        }

        public bool PAYPAL
        {
            set { payPal = value; }
            get { return payPal; }
        }

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


        public Product(string name, string date, string objName, string inventoryNumber, string count, string price)
        {
            this.name = name;
            this.date = date;
            this.objName = objName;
            this.inventoryNumber = inventoryNumber;
            this.count = count;
            this.price = price;
        }


        public static Product SearchByName(string s)
        {
            return getAll().Find(item => item.objName == s);
        }

        public static Product SearchByInventoryNumber(string inventoryNumber)
        {
            return getAll().Find(x => x.inventoryNumber == inventoryNumber);
        }

        public static List<Product> searchByPrice(string price)
        {
            return products.FindAll(p => p.price == price);
        }


        public Product() { }

        public static List<Product> getAll()
        {
            return products;
        }

        public void save()
        {
            products.Add(this);
        }
    }
}


