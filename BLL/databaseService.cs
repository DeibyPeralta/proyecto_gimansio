using MySql.Data.MySqlClient;
using System;
using Entity;
using System.Collections.Generic;
using DAL;



namespace BLL
{
    public class databaseService
    {
        MySqlConnection conexion;
        databaseDeportista deportistax;
        //MySqlCommand comando;
        //IList<Deportistas> deportistaLista;
        public databaseService()
        {
            conexion = new MySqlConnection("server=localhost; Database=gym; Uid=root; pwd=;");
        }

        public void conexxion()
        {
            
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

        public string Guardar(Deportistas  deportista)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion.ConnectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO `prueba`.`facturas` (`Version`) VALUES ('3.3')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            {
                return "Error: {0}"+ ex.Message;
            }


           /* try
            {
                conexion.Open();
                deportistax.Guardar(deportista);
                conexion.Close();

                return "Se registro al empleado " + deportista.NombreCompleto;
            }
            catch (Exception ex)
            {
                return "Error de base de datos: " + ex.Message.ToString();
            }*/
        }

    }
}
