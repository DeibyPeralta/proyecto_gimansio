using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Planes
    {
        public int Id_plan { get; set; }
        public string Nombre { get; set; }
        public string Por_tiempo { get; set; }
        public int Numero_repeticiones { get; set; }
        public float Valor { get; set; }
        public string Descripcion { get; set; }

        public Planes() { }


        public Planes(int id_plan, string nombre, string por_tiempo, int numero_repeticiones, float valor, string descripcion)
        {
            Id_plan = id_plan;
            Nombre = nombre;
            Por_tiempo = por_tiempo;
            Numero_repeticiones = numero_repeticiones;
            Valor = valor;
            Descripcion = descripcion;
        }
    }
}
