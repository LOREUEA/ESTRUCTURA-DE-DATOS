using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio4
{
    internal class ContadorVocales
    {
        private string palabra;

        public ContadorVocales(string palabra)
        {
            this.palabra = palabra.ToLower(); // Convertir a minúsculas
        }

        public void ContarVocales()
        {
            Dictionary<char, int> vocales = new Dictionary<char, int>()
            {
                {'a', 0},
                {'e', 0},
                {'i', 0},
                {'o', 0},
                {'u', 0}
            };

            foreach (char letra in palabra)
            {
                if (vocales.ContainsKey(letra))
                {
                    vocales[letra]++;
                }
            }

            Console.WriteLine("\n Frecuencia de vocales:");
            foreach (var kvp in vocales)
            {
                Console.WriteLine($"La vocal '{kvp.Key}' aparece {kvp.Value} vez/veces.");
            }
        }
    }
}