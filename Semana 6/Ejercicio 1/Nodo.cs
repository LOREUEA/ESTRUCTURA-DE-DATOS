using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Nodo
{
    public int Valor; // almacena el valor del nodo
    public Nodo Siguiente; // indica el siguiente nodo
    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}