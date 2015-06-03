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
    class BrandGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["shopConString"].ConnectionString;
        public List<Brand> GetAllBrands()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_brand";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Brand> brands = new List<Brand>();

            while (reader.Read())
            {
                //Designation designation = new Designation();
                Brand brand = new Brand();

                brand.Id = int.Parse(reader["Id"].ToString());
                //designation.Code = int.Parse(reader["Code"].ToString());
                brand.Name = reader["Brand_Name"].ToString();


                brands.Add(brand);
            }
            reader.Close();
            connection.Close();

            return brands;
        }
    }
}
