using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01ParentesisBalanceados
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la expresión a evaluar:");
            string expresion = Console.ReadLine();

            bool balanceada = VerificadorBalanceo.EstaBalanceada(expresion);

            Console.WriteLine(balanceada ? "Fórmula balanceada." : "Fórmula NO balanceada.");
        }
    }
}