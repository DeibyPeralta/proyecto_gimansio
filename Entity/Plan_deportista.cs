using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Plan_deportista
    {
        public string Id_deportistaplan { get; set; }
        public string Identificacion { get; set; }
        public string Fecha_compra { get; set; }
        public string Fecha_vencimiento { get; set; }
        public string Dias_restantes { get; set; }
        public string Id_plan { get; set; }
        public string Dias_bonos { get; set; }
        public string Codigo_descuento { get; set; }


        public Plan_deportista() { }

        public Plan_deportista(string id_deportistaplan, string dias_bonos, string codigo_descuento, string identificacion, string fecha_compra, string fecha_vencimiento, string dias_restantes, string id_plan)
        {
            Id_deportistaplan = id_deportistaplan;
            Identificacion = identificacion;
            Fecha_compra = fecha_compra;
            Fecha_vencimiento = fecha_vencimiento;
            Dias_restantes = dias_restantes;
            Id_plan = id_plan;
            Dias_bonos = dias_restantes;
            Codigo_descuento = codigo_descuento;
        }
    }
}
