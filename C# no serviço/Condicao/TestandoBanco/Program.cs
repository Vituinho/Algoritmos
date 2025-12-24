using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestandoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string connectionString = "Server=sql10.freesqldatabase.com;Port=3306;Database=sql10778373;Uid=sql10778373;Pwd=F57uDeQCxV;";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        Console.WriteLine("Tentando conectar...");
                        conn.Open();
                        Console.WriteLine("✅ Conexão bem-sucedida!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Erro na conexão:");
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }


