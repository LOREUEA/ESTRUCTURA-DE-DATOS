using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista1 = new ListaEnlazada();
            ListaEnlazada lista2 = new ListaEnlazada();

            Console.WriteLine("=== Carga de la primera lista ===");
            CargarLista(lista1, "primera");

            Console.WriteLine("\n=== Carga de la segunda lista ===");
            CargarLista(lista2, "segunda");

            Console.WriteLine("\n=== Listas ingresadas ===");
            Console.Write("Lista 1: ");
            lista1.Imprimir();
            Console.Write("Lista 2: ");
            lista2.Imprimir();

            Console.WriteLine("\n=== Resultado de la comparación ===");
            CompararListas(lista1, lista2);
        }

        static void CargarLista(ListaEnlazada lista, string nombreLista)
        {
            Console.WriteLine($"Ingrese los números enteros para la {nombreLista} lista (ingrese 'fin' para terminar):");

            while (true)
            {
                Console.Write($"Elemento {lista.Count + 1}: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "fin")
                    break;

                if (int.TryParse(input, out int valor))
                {
                    lista.AgregarAlInicio(valor);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número entero o 'fin' para terminar.");
                }
            }
        }

        static void CompararListas(ListaEnlazada lista1, ListaEnlazada lista2)
        {
            bool mismoTamano = lista1.Count == lista2.Count;
            bool mismoContenido = lista1.SonIguales(lista2);

            if (mismoTamano && mismoContenido)
            {
                Console.WriteLine("a. Las listas son iguales en tamaño y en contenido.");
            }
            else if (mismoTamano)
            {
                Console.WriteLine("b. Las listas son iguales en tamaño pero no en contenido.");
            }
            else
            {
                Console.WriteLine("c. No tienen el mismo tamaño ni contenido.");
            }
        }
    }
}
