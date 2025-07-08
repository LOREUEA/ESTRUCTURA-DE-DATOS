using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ListaEnlazada
    {
        private Nodo cabeza;
        private int count;

        public int Count { get { return count; } }

        // Agrega un elemento al inicio de la lista
        public void AgregarAlInicio(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
            count++;
        }

        // Imprime la lista
        public void Imprimir()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // Compara esta lista con otra
        public bool SonIguales(ListaEnlazada otraLista)
        {
            // Primero comparamos tamaños
            if (this.count != otraLista.count)
                return false;

            Nodo actual1 = this.cabeza;
            Nodo actual2 = otraLista.cabeza;

            while (actual1 != null && actual2 != null)
            {
                if (actual1.Valor != actual2.Valor)
                    return false;

                actual1 = actual1.Siguiente;
                actual2 = actual2.Siguiente;
            }

            return true;
        }
    }
}
