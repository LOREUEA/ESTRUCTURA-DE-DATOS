using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01ParentesisBalanceados
{
    public class VerificadorBalanceo
    {
        public static bool EstaBalanceada(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char caracter in expresion)
            {
                if (caracter == '(' || caracter == '{' || caracter == '[')
                    pila.Push(caracter);
                else if (caracter == ')' || caracter == '}' || caracter == ']')
                {
                    if (pila.Count == 0) return false;

                    char tope = pila.Pop();
                    if (!EsParCoincidente(tope, caracter)) return false;
                }
            }

            return pila.Count == 0;
        }

        private static bool EsParCoincidente(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }
    }
}