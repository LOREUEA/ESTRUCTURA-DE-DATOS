using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_1.ListaEnlazada;

namespace Ejercicio_1
{
    public class Program
    {
        static void Main(string[] args)
        {   
        // crea una nueva lista enlazada
        ListaEnlazada lista = new ListaEnlazada();
        // agrega elementos a la lista
            lista.AgregarAlFinal(1);
            lista.AgregarAlFinal(3);
            lista.AgregarAlFinal(5);
            lista.AgregarAlFinal(7);
            lista.AgregarAlFinal(9);
            // muestra la lista original
            Console.WriteLine("Lista original:");
            lista.Imprimir();
            // inviertela lista
            lista.Invertir();
            // muestra la lista ya invertida
            Console.WriteLine("\n\nLista invertida:");
            lista.Imprimir();
        
        }
    }
}
