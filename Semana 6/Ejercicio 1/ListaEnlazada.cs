using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class ListaEnlazada
    {
        private Nodo cabeza; // nodo de incio de la lista
                             // agrega un nuevo nodo al final de la lista
        public void AgregarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }
        // despliega los valores de la lista en pantalla
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
        // este método invierte los valores de la lista
        public void Invertir()
        {
            // verifica si la lista está vacía o tiene un solo nodo
            if (cabeza == null || cabeza.Siguiente == null)
            {
                Console.WriteLine("La lista no se puede invertir ya que está vacía o tiene un solo nodo.");
                return;
            }
            Nodo anterior = null;
            Nodo actual = cabeza; // nodo con el que estamos trabajando
            Nodo siguiente = null; // el siguiente nodo con el que se trabajará
                                   // recorre la lista e invierte los enlaces
            while (actual != null)
            {
                siguiente = actual.Siguiente; // guarda la referencia del siguiente nodo
                actual.Siguiente = anterior;  // invierte el enlace (apuntando hacia atrás)
                anterior = actual;
                actual = siguiente;
            }
            // apunta el "anterior" hacia la primera posición
            cabeza = anterior;
            Console.WriteLine("La lista fue sido invertida exitosamente.");
        }
    }
}
