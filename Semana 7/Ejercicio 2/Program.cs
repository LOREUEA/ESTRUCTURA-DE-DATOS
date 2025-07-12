using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiPilas
{
    public class AppHanoi
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de discos: ");
            int numDiscos = int.Parse(Console.ReadLine());

            for (int i = numDiscos; i >= 1; i--)
                TorresDeHanoi.origen.Push(i);

            Console.WriteLine("\nEstado inicial:");
            TorresDeHanoi.MostrarTorres();

            TorresDeHanoi.Resolver(numDiscos, TorresDeHanoi.origen, TorresDeHanoi.destino, TorresDeHanoi.auxiliar, "Origen", "Destino", "Auxiliar");

            Console.WriteLine("¡Todos los discos se han movido exitosamente!");
        }
    }
}
