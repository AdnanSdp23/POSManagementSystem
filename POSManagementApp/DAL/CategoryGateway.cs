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
    class CategoryGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["shopConString"].ConnectionString;
        public List<Category> GetAllCategories()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_category";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Category> categories = new List<Category>();

            while (reader.Read())
            {
                //Designation designation = new Designation();
                Category category = new Category();

                category.Id = int.Parse(reader["Id"].ToString());
                //designation.Code = int.Parse(reader["Code"].ToString());
                category.Name = reader["Category_Name"].ToString();


                categories.Add(category);
            }
            reader.Close();
            connection.Close();

            return categories;
        }
    }
}
