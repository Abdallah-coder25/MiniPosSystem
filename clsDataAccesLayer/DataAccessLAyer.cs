using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace clsDataAccesLayer
{
    public class clsDAL
    {
        //Users
      
        public static bool AddNewUser(string username,string password)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Insert into Users(Username , Password) Values (@name,@pass)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", username);
            command.Parameters.AddWithValue("@pass", password);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    isSuccess = true;
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool IsFoundByNameAndPassword(string username , string password)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = "SELECT 1 FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            try
            { 
                connection.Open();
                object result = command.ExecuteScalar();
                isfound = (result != null);
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return isfound;
        }

        //Products
        public static bool AddNewProducts(string name, decimal price,int quantity,string ImagePath = "")
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Insert into Products(Name , Price , QuantityInStock,ImagePath) Values (@name,@price,@quantity,@image)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@image", ImagePath);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    isSuccess = true;
            }
            catch 
            {
               //
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool IsFoundById(int id,ref string name,ref decimal price,ref int quantity,ref string ImagePath)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = "SELECT Name,Price,QuantityInStock,ImagePath FROM Products WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isfound = true;
                    reader.Read();
                    name = reader["Name"].ToString();
                    price = Convert.ToDecimal(reader["Price"]);
                    quantity = Convert.ToInt32(reader["QuantityInStock"]);
                    ImagePath = reader["ImagePath"].ToString();
                }
                reader.Close();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }
        public static DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = "Select * From Products";
            SqlCommand command = new SqlCommand(query, connection);;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetOneProductsById(int id)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = "Select * From Products where id = @id";
            SqlCommand command = new SqlCommand(query, connection); 
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool UpdateProduct(int ID, string Name,decimal price,int quantity, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Update Products set
                                Name = @name,
                                Price = @price,
                                QuantityInStock = @quantity,
                                ImagePath = @image
                             where id = @id
                            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", ID);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@quantity", quantity);
            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@image", ImagePath);
            else
                command.Parameters.AddWithValue("@image", System.DBNull.Value);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static bool DeleteProduct(int id)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Delete From Products where id = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static bool IsProductUsed(int prodId)
        {
            bool isUsed = false;
            SqlConnection con = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Select top 1 1 from InvoiceDetails where ProductId = @pId";
            SqlCommand cmn = new SqlCommand(query, con);
            cmn.Parameters.AddWithValue("@pId", prodId);
            try
            {
                con.Open();
                object result = cmn.ExecuteScalar();
                isUsed = (result != null);
            }
            catch
            {
                //
            }
            finally
            {
                con.Close();
            }
            return isUsed;
        }
        public static decimal GetPrice(int id)
        {
            decimal price = 0;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Select Price From Products where id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue(@"id", id);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                price = (result != null) ? Convert.ToDecimal(result) : 0;
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return price;
        }
        public static int GetQuantity(int id)
        {
            int qty = 0;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Select QuantityInStock From Products where id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue(@"id", id);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if(result != null)
                    qty = Convert.ToInt32(result);
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return qty;
        }
        public static int UpdateQuantity(int id,int newquantity)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = @"Update Products set
                             QuantityInStock = @qty
                             where id = @id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue(@"qty", newquantity);
            cmd.Parameters.AddWithValue(@"id", id);
            try
            {
                connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return result ;
        }

        //Reports
        public static DataTable GetReports()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSetting.connectionString);
            string query = "Select * From Invoices";
            SqlCommand command = new SqlCommand(query, connection); ;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static int InsertInvoice(DateTime date, decimal total)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(clsDataSetting.connectionString);
            string query = "insert into Invoices(Date,Total) output inserted.id values(@date,@total)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@total", total);
            try
            {
                con.Open();
                id = (int)cmd.ExecuteScalar();
            }
            catch
            {
                //
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public static bool InsertInvoiceDetails(int invoiceId, int productId, int qty, decimal subtotal)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(clsDataSetting.connectionString);
            string query = "insert into InvoiceDetails(InvoioceId,ProductId,Quantity,SubTotal) values(@i,@p,@q,@s)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@i", invoiceId);
            cmd.Parameters.AddWithValue("@p", productId);
            cmd.Parameters.AddWithValue("@q", qty);
            cmd.Parameters.AddWithValue("@s", subtotal);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    result = true;
            }
            catch
            {
                //
            }
            finally {
                con.Close();
            }
            return result;
        }
    }
}
