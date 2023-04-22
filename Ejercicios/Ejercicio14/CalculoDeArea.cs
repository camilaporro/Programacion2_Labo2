using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }

        public static double CalcularTriangulo (double lado, double altura) //lado = base(palabra reservada)
        {
            return (lado * altura) / 2;
        }

        public static double CalcularCirculo (double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
