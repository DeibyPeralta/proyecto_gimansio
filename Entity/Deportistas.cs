using System;

namespace Entity
{
    public class Deportistas
    {
        public string Identificacion { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Fecha_inscripcion { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }

        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }

        public Deportistas() { }

        public Deportistas(string identificacion, string apellido, string nombre, string direccion, string fecha_inscripcion, string genero, string telefono)
        {
            Identificacion = identificacion;
            Apellido = apellido;
            Nombre = nombre;
            Fecha_inscripcion = fecha_inscripcion;
            Direccion = direccion;
            Genero = genero;
            Telefono = telefono;
        }
    }
}
