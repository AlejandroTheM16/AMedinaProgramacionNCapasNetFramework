using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Class1
    {
        static void main() {

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = ".",
                    UserID = "sa",
                    Password = "pass@word1",
                    InitialCatalog = "AMedinaProgramacionNCapas"
                };

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    Console.WriteLine("-Conexion establecida-");
                    string query = "SELECT Id_Usuario,Nombre,ApellidoPaterno,ApellidoMaterno,Genero,Edad,Correo,Telefono,FechaDeRegistro,FechaDeNacimiento FROM Usuario";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", "Nombre: " + reader.GetInt32(10), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                                    "|Genero: " + reader.GetString(4), "|Edad: " + reader.GetSqlInt32(5), "|Correo: " + reader.GetString(6),
                                    "|Telefono: " + reader.GetString(7), "|Registro: " + reader.GetDateTime(8), reader.GetDateTime(9));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
