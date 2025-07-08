using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2_Datos_Primitivos
{
    public class Rectangulo
    {
        // Atributos privados
        private double ancho, alto;

        // Constructor que recibe los valores de ancho y alto
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // Devuelve el valor del ancho
        public double GetAncho()
        {
            return ancho;
        }

        // Devuelve el valor del alto
        public double GetAlto()
        {
            return alto;
        }

        // Calcula y devuelve el área del rectángulo
        public double CalcularArea()
        {
            return ancho * alto;
        }

        // Calcula y devuelve el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }
    }
}