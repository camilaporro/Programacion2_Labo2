namespace Clase_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Ingresar 5 números por consola, guardándolos en una variable escalar.
            //Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            Console.Title = "Ejercicio 1 - Camila Porro";

            int numero = 0;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            int contador;
            string? numeroIngresado;
            float promedio = 0f;
            int intentos = 5;

            for (contador = 0; contador < intentos; contador++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = Console.ReadLine();

                while (!(int.TryParse(numeroIngresado, out numero)))
                {
                    Console.WriteLine("Hubo un error. Reingrese el numero: ");
                    numeroIngresado = Console.ReadLine();
                }

                acumulador += numero;

                if (contador == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                    }
                }

            }

            promedio = ((float)acumulador/ intentos);
            Console.WriteLine("El numero mayor fue {0} y el menor {1}", maximo, minimo);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadKey();


        }
    }
}