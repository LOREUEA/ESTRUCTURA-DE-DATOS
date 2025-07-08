using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2_Datos_Primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear figuras
            Rectangulo rectangulo = new Rectangulo(8, 6);
            Triangulo triangulo = new Triangulo(6, 4, 2, 2, 2);

            // Crear el gestor de figuras
            FigurasGeometricas gestor = new FigurasGeometricas();

            // Mostrar información de ambas figuras
            gestor.MostrarRectangulo(rectangulo);
            gestor.MostrarTriangulo(triangulo);
        }
    }
}