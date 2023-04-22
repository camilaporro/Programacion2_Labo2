namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura de la pirámide: ");
            int.TryParse(Console.ReadLine(), out altura);

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= altura - i; j++) //imprimir los espacios= altura- linea
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}