using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2_Datos_Primitivos
{
    public class Triangulo
    {
        // Atributos privados
        private double baseT, altura;
        private double lado1, lado2, lado3;

        // Constructor que recibe base, altura y lados
        public Triangulo(double baseT, double altura, double lado1, double lado2, double lado3)
        {
            this.baseT = baseT;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        // Devuelve la base del triángulo
        public double GetBase()
        {
            return baseT;
        }

        // Devuelve la altura del triángulo
        public double GetAltura()
        {
            return altura;
        }

        // Calcula y devuelve el área usando (base * altura) / 2
        public double CalcularArea()
        {
            return (baseT * altura) / 2;
        }

        // Calcula y devuelve el perímetro sumando sus lados
        public double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }
}