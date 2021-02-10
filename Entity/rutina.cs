using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class rutina
    {
        public int Cod_actividad { get; set; }
        public string Descripcion { get; set; }
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miercoles { get; set; }
        public string Jueves { get; set; }
        public string Viernes { get; set; }
        public string Sabado { get; set; }

        public rutina() { }
        public rutina(int cod_actividad, string descripcion, string lunes, string martes, string miercoles, string jueves, string viernes, string sabado)
        {
            Cod_actividad = cod_actividad;
            Descripcion = descripcion;
            Lunes = lunes;
            Martes = martes;
            Miercoles = miercoles;
            Jueves = jueves;
            Viernes = viernes;
            Sabado = sabado;
        }
    }
}
