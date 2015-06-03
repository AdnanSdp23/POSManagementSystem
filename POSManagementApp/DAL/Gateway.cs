using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSManagementApp.Model;

namespace POSManagementApp.DAL
{
    class Gateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["shopConString"].ConnectionString;
        public int InsertCategory(Category aCategory)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_category VALUES('" + aCategory.Name + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public int InsertBrand(Brand aBrand)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_brand VALUES('" + aBrand.Name + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public int InsertProduct(product aProduct)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_product VALUES('" + aProduct.Unit + "', '" + aProduct.Price + "', '" + aProduct.Total_Price + "', '" + aProduct.Category_Id + "','" + aProduct.Brand_Id + "')";
            //insert student
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public List<AllProducts> AllProducs()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM BrandCategoryProduct";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<AllProducts> allProductses = new List<AllProducts>();

            while (reader.Read())
            {
                AllProducts product = new AllProducts();
            
               product.SerialNo = int.Parse(reader["Id"].ToString());
             //   product.Purchase_No = reader["Purchase_No"].ToString();
              //  product.DateTime = int.Parse(reader["DateTime"].ToString());
                product.ProductCategory = reader["Category_Name"].ToString();
                product.ProductBrand = reader["Brand_Name"].ToString();
                product.TotalNumberOfUnit = int.Parse(reader["Unit"].ToString());
               // student.DepartmentId = reader["DepartmentId"].ToString() == "" ? (int?)null : int.Parse(reader["DepartmentId"].ToString());
              //  products.Add(product);
                allProductses.Add(product);
            }
            reader.Close();
            connection.Close();

            return allProductses;
        }
    }
}
