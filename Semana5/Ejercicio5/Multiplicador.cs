using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO.Ejercicio5
{
    internal class Multiplicador
    {
        private List<List<int>> A;
        private List<List<int>> B;

        private int filasA, columnasA, filasB, columnasB;

        public void CapturarMatrices()
        {
            Console.WriteLine(" MATRIZ A:");
            Console.Write("Número de filas: ");
            filasA = int.Parse(Console.ReadLine());
            Console.Write("Número de columnas: ");
            columnasA = int.Parse(Console.ReadLine());

            A = LeerMatriz(filasA, columnasA, "A");

            Console.WriteLine("\n MATRIZ B:");
            Console.Write("Número de filas: ");
            filasB = int.Parse(Console.ReadLine());
            Console.Write("Número de columnas: ");
            columnasB = int.Parse(Console.ReadLine());

            if (columnasA != filasB)
            {
                Console.WriteLine("\n No se puede multiplicar: columnas de A ≠ filas de B.");
                Environment.Exit(0);
            }

            B = LeerMatriz(filasB, columnasB, "B");
        }

        private List<List<int>> LeerMatriz(int filas, int columnas, string nombre)
        {
            var matriz = new List<List<int>>();
            for (int i = 0; i < filas; i++)
            {
                List<int> fila = new List<int>();
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingresa el valor [{i + 1},{j + 1}] de matriz {nombre}: ");
                    fila.Add(int.Parse(Console.ReadLine()));
                }
                matriz.Add(fila);
            }
            return matriz;
        }

        public List<List<int>> Multiplicar()
        {
            var resultado = new List<List<int>>();

            for (int i = 0; i < filasA; i++)
            {
                List<int> filaResultado = new List<int>();
                for (int j = 0; j < columnasB; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        suma += A[i][k] * B[k][j];
                    }
                    filaResultado.Add(suma);
                }
                resultado.Add(filaResultado);
            }

            return resultado;
        }

        public void MostrarResultado(List<List<int>> matriz)
        {
            Console.WriteLine("\n Resultado de A × B:");
            foreach (var fila in matriz)
            {
                foreach (var valor in fila)
                {
                    Console.Write(valor + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}