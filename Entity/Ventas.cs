using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Ventas
    {
        public int Id_ventas { get; set; }
        public int Id_producto { get; set; }
        public int Id_deportista { get; set; }
        public int Cantidad { get; set; }
        public float Valor { get; set; }

        public Ventas() { }
        public Ventas(int id_ventas, int id_productos, int id_deportista, int conductor, float valor)
        {
            Id_ventas = id_ventas;
            Id_producto = id_productos;
            Id_deportista = id_deportista;
            Cantidad = Cantidad;
            Valor = valor;
        }
    }
}
