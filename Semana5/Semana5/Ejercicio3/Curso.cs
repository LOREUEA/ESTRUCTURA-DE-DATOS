using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio3
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
                if (!double.TryParse(Console.ReadLine(), out double nota))
                {
                    Console.WriteLine("⚠️ Nota inválida. Se asignará 0 por defecto.");
                    nota = 0.0;
                }
                asignatura.Nota = nota;
            }
        }

        public void EliminarAprobadas()
        {
            listaAsignaturas.RemoveAll(a => a.Nota >= 7.0);
        }

        public void MostrarReprobadas()
        {
            Console.WriteLine("\n Asignaturas que debes repetir:");
            if (listaAsignaturas.Count == 0)
            {
                Console.WriteLine("¡Felicidades! No tienes materias reprobadas.");
            }
            else
            {
                foreach (var asignatura in listaAsignaturas)
                {
                    Console.WriteLine($"- {asignatura.Nombre}");
                }
            }
        }
    }
}