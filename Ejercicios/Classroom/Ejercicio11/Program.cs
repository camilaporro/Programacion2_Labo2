using Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            int intentos = 10;
            double promedio;

            for (int i = 0; i < intentos; i++)
            {
                Console.Write($"{i+1} - Ingrese un numnero entre -100 y 100: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                while (!(Validacion.Validar(numeroIngresado, -100, 100)))
                {
                    Console.Write("ERROR. Numero no valido. Ingrese un numero entre -100 y 100: ");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                acumulador += numeroIngresado;

                if (i == 0)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                    else
                    {
                        if (numeroIngresado < minimo)
                        {
                            minimo = numeroIngresado;
                        }
                    }
                }

            }

            promedio = ((double)acumulador / intentos);
            Console.WriteLine("El numero mayor fue {0} y el menor {1}", maximo, minimo);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadKey();


        }
    }
}