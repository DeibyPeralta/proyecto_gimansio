using System;
using System.Collections.Generic;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class databaseDeportista
    {
        IList<Deportistas> ListDeportista = new List<Deportistas>();
        private MySqlConnection conexxion;
        MySqlCommand comando;

        public databaseDeportista(MySqlConnection conexion)
        {
            conexxion = conexion;
        }
        public void Guardar(Deportistas deportista)
        {
            string query = "INSERT INTO Deportistas {Identificacion, Nombre, Apellido, Direccion, Fecha_inscripcion, Telefono, Genero} values{'" + deportista.Identificacion + "','" + deportista.Nombre + "','" + deportista.Apellido  + "','" + deportista.Direccion + "','" + deportista.Fecha_inscripcion + "','" + deportista.Telefono + "','" + deportista.Genero+"');";
        }
    }
}

/*  using (var comando = conexxion.CreateCommand())
              {
                  comando.CommandText = "Insert into Deportista Values(@Identificacion, @Nombre, @Apellido, @Direccion, @Fecha_inscripcion, @Telefono, @Genero)";

                      comando.Parameters.AddWithValue("@Identificacion", deportista.Identificacion);
                      comando.Parameters.AddWithValue("@Nombre", deportista.Nombre);
                      comando.Parameters.AddWithValue("@Apellido", deportista.Apellido);
                      comando.Parameters.AddWithValue("@Direccion", deportista.Direccion);
                      comando.Parameters.AddWithValue("@Fecha_inscripcion", deportista.Fecha_inscripcion);
                      comando.Parameters.AddWithValue("@Telefono", deportista.Telefono);
                      comando.Parameters.AddWithValue("@Genero", deportista.Genero);

                      comando.ExecuteNonQuery();
              }*/