using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio5
{
    internal class ProgramEj5
    {
        static void Main(string[] args)
        {
            Multiplicador mult = new Multiplicador();

            mult.CapturarMatrices();

            var resultado = mult.Multiplicar();
            mult.MostrarResultado(resultado);

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}