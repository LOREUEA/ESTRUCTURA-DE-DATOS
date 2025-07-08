using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio1
{
    internal class Asignaturas
    {
        private List<string> materias;

        public Asignaturas()
        {
            materias = new List<string>()
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua",
                "Inglés",
                "Educación Física",
                "Emprendimiento",
            };
        }

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Estas son las materias que recibirás en 1° BGU:");
            for (int i = 0; i < materias.Count; i++)
            {
                Console.WriteLine("- " + materias[i]);
            }
        }
    }
}

