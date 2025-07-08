using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio2
{
    internal class Curso
    {
        private List<Asignaturas> listaAsignaturas;

        public Curso()
        {
            listaAsignaturas = new List<Asignaturas>()
            {
                new Asignaturas("Matemáticas"),
                new Asignaturas("Física"),
                new Asignaturas("Química"),
                new Asignaturas("Historia"),
                new Asignaturas("Lengua")
            };
        }

        public void RegistrarNotas()
        {
            foreach (var asignatura in listaAsignaturas)
            {
                Console.Write($"Ingrese la nota de {asignatura.Nombre}: ");
                string entrada = Console.ReadLine();
                double nota;
                if (double.TryParse(entrada, out nota))
                {
                    asignatura.Nota = nota;
                }
                else
                {
                    Console.WriteLine("⚠️ Nota inválida. Se asignará 0 por defecto.");
                    asignatura.Nota = 0.0;
                }
            }
        }

        public void MostrarNotas()
        {
            Console.WriteLine("\n📋 Notas registradas:");
            foreach (var asignatura in listaAsignaturas)
            {
                Console.WriteLine($"En {asignatura.Nombre} has sacado {asignatura.Nota}");
            }
        }
    }
}
