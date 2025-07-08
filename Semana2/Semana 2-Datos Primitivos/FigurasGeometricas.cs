using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2_Datos_Primitivos
{
    public class FigurasGeometricas
    {
        // Método para mostrar datos de un rectángulo
        public void MostrarRectangulo(Rectangulo r)
        {
            Console.WriteLine("🔲 RECTÁNGULO 🔲");
            Console.WriteLine("Ancho: " + r.GetAncho());
            Console.WriteLine("Alto: " + r.GetAlto());
            Console.WriteLine("Área: " + r.CalcularArea());
            Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
            Console.WriteLine("----------------------------------");
        }

        // Método para mostrar datos de un triángulo
        public void MostrarTriangulo(Triangulo t)
        {
            Console.WriteLine("🔺 TRIÁNGULO 🔻");
            Console.WriteLine("Base: " + t.GetBase());
            Console.WriteLine("Altura: " + t.GetAltura());
            Console.WriteLine("Área: " + t.CalcularArea());
            Console.WriteLine("Perímetro: " + t.CalcularPerimetro());
            Console.WriteLine("----------------------------------");
        }
    }
}