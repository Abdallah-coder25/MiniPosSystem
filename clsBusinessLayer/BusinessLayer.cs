using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using clsDataAccesLayer;


namespace clsBusinessLayer
{
    public class clsBL
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        private clsBL(int id, string name, decimal price, int quantity, string imagePath)
        {
            this.id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.ImagePath = imagePath;
        }
   
        public static bool AddNewUser(string username, string password)
        {
            return clsDAL.AddNewUser(username, password);
        }
        public static bool IsFound(string username, string password)
        {
            return clsDAL.IsFoundByNameAndPassword(username, password);
        }

        //Products
        public static bool IsAdded(string name, decimal price, int quantity,string image)
        {
            return clsDAL.AddNewProducts(name, price, quantity,image);
        }
        public static clsBL Find(int id)
        {
            string Name = "", ImagePath = "";
            decimal Price = 0;
            int Quantity = 0;

            if (clsDAL.IsFoundById(id, ref Name, ref Price, ref Quantity, ref ImagePath))
            {
                return new clsBL(id, Name, Price, Quantity, ImagePath);
            }
            else
                return null;
        }
        public static DataTable GetProducts()
        {
            return clsDAL.GetAllProducts();
        }
        public static DataTable GetOneProducts(int id)
        {
            return clsDAL.GetOneProductsById(id);
        }
        public static bool DeleteProduct(int id)
        {
            return clsDAL.DeleteProduct(id);
        }
        public static bool UsingProduct(int pid)
        {
            return clsDAL.IsProductUsed(pid);
        }
        public static bool UpdateProduct(int id, string name, decimal price, int quantity, string imagePath)
        {
            return clsDAL.UpdateProduct(id, name, price, quantity, imagePath);
        }
        public static Decimal GetPriceOfProduct(int id)
        {
            return clsDAL.GetPrice(id);
        }
        public static int GetQuantity(int id)
        {
            return clsDAL.GetQuantity(id);
        }
        public static int UpdateQty(int id,int qty)
        {
            return clsDAL.UpdateQuantity(id, qty);
        }
      
        //Invoices & IncoicesDetails
        public static DataTable GetAllReports()
        {
            return clsDAL.GetReports();
        }
        public static int  SaveInvoice(DateTime date,decimal total)
        {
            return clsDAL.InsertInvoice(date, total);
        }
        public static bool SaveInvoiceDetails(int InvoiceId,int ProductId,int quantity,decimal SubTotal)
        {
           return clsDAL.InsertInvoiceDetails(InvoiceId, ProductId, quantity, SubTotal);
        }
    }
}
