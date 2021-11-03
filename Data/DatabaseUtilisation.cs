using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProductList
{
    public class DatabaseUtilisation
    {
        private const string _connectionString = ("Server = localhost; Port = 5432; Database = Products; User Id = postgres; Password =***** ;");
       

        public static void LoadProduct(GridView dgw)
        {
            var conn = new NpgsqlConnection(_connectionString);
            string query = "SELECT * FROM Product";

            try
            {

                conn.Open();
                var cmd = new NpgsqlCommand(query, conn);
                var da = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();

                da.Fill(dt);
                dgw.DataSource = dt;
                dgw.DataBind();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SaveProduct(Product product)
        {
            var conn = new NpgsqlConnection(_connectionString);
            string query = "INSERT INTO product(name, description, category, manufacturer, supplier, price) VALUES ('" + product.Name + "','" + product.Descripteion + "','" + product.Category + "','" + product.Manufacturer + "','" + product.Supplier + "'," + product.Price.ToString() + ")";

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string IsNameExist(string name)
        {
            var conn = new NpgsqlConnection(_connectionString);
            string query = "SELECT * FROM product WHERE (name='"+name+"')";
            
            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand(query, conn);
                var result=cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                conn.Close();
                return "";
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static void UpdateProduct(Product  product)
        {
            var conn = new NpgsqlConnection(_connectionString);
            string query = "UPDATE product SET name='" + product.Name + "', description='" + product.Descripteion + "', category='" + product.Category + "', manufacturer='" + product.Manufacturer + "', supplier='" + product.Supplier + "', price=" + product.Price.ToString() + "  WHERE (Name = '"+product.Name+"')";

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}