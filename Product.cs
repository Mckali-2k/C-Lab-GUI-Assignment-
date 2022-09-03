using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public class Product
    {

        private string number, date, objName, inventoryNumber;
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

        public string NUMBER
        {
            set { number = value; }
            get { return number; }
        }

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


        public Product(string number, string date, string objName, string inventoryNumber, string count, string price)
        {
            this.number = number;
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
            return getAll().FindAll(p => p.price == price);
        }


        public Product() { }

        public void save()
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NUDAC26\SQLEXPRESS;Initial Catalog=product;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into Products values({this.number},'{this.date}',{this.inventoryNumber},'{this.objName}',{this.count},{this.price})", con);
                cmd.ExecuteReader();

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public static List<Product> getAll()
        {
            List<Product> products = new List<Product>();
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NUDAC26\SQLEXPRESS;Initial Catalog=product;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand($"select * from Products", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    products.Add(new Product()
                    {
                        number = dr["pNumber"].ToString(),
                        date = dr["pDate"].ToString(),
                        inventoryNumber = dr["pInventoryNumber"].ToString(),
                        objName = dr["pObjectName"].ToString(),
                        count = dr["pCount"].ToString(),
                        price = dr["pPrice"].ToString(),
                    }
                    );
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }
    }
}
