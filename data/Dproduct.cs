using entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class Dproduct
    {
        public static string connectionString = "Data Source=DESKTOP-61H0H45\\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";

        public static List<Product> ListarProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                string query = "ListarProductos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //Leer los datos de cada fila
                                products.Add(new Product
                                {
                                    ProductID = (int)reader["product_id"],
                                    Name = reader["name"].ToString(),
                                    Price = (decimal)reader["price"],
                                    Stock = (int)reader["stock"],
                                    Active = (bool)reader["active"]
                                });
                            }
                        }
                    }
                }
                // Cerrar la conexión
                connection.Close();
            }
            return products;
        }
    }
}
