namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese un numero:");
            int.TryParse(Console.ReadLine(), out altura);

            for (int i = 0; i <= altura; i++)
            {
                for (int j = 0; j <= i*2-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}