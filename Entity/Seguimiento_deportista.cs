using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Seguimiento_deportista
    {
        public int Id_seguimiento { get; set; }
        public string Identificacion { get; set; }
        public string Fecha_ingreso { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string IMC { get; set; }
        public string Braso { get; set; }
        public string Pierna { get; set; }
        public string Cintura { get; set; }
        public string Abdomen { get; set; }
        public string Pecho { get; set; }
        public string Meta { get; set; }

        public Seguimiento_deportista() { }

        public Seguimiento_deportista(int id_seguimiento, string identificacion, string fecha_ingreso, string peso, string altura, string Imc, string braso, string pierna, string cintura, string abdomen, string pecho, string meta)
        {
            Id_seguimiento = id_seguimiento;
            Identificacion = identificacion;
            Fecha_ingreso = fecha_ingreso;
            Peso = peso;
            Altura = altura;
            IMC = Imc;
            Braso = braso;
            Pierna = pierna;
            Cintura = cintura;
            Abdomen = abdomen;
            Pecho = pecho;
            Meta = meta;
        }
    }
}
