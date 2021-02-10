using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class producto
    {
        public int Id_producto { get; set; }
        public string Nombre { get; set; }
        public string Tipo_producto { get; set; }
        public int Valor { get; set; }


        public producto() { }

        public producto(int id_producto, string nombre, string tipo_producto, int valor)
        {
            Id_producto = id_producto;
            Nombre = nombre;
            Tipo_producto = tipo_producto;
            Valor = valor;
        }
    }
}
