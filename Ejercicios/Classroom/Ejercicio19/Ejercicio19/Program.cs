using Entidades;

namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador();
            Sumador sum2 = new Sumador(2);

            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)}  - Sumador {sum2.GetCantidad()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Mundo")} -- Sumador {sum.GetCantidad()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
        }
    }
}