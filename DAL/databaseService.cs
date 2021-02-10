using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class databaseService
    {
        static void Main(string[] args)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; Database=gym; Uid=root; pwd=;");

            try
            {
                conexion.Open();
                Console.WriteLine("conecatada");
                conexion.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("no conectada, ");
            }
        }
    }
}
