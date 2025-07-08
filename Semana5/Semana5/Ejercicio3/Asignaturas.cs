using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio3
{
    internal class Asignaturas
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Asignaturas(string nombre)
        {
            Nombre = nombre;
            Nota = 0.0;
        }
    }
}