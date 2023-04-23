using Entidades;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            string dibujoAzul;
            string dibujoRojo;
                    
            boligrafoAzul.Pintar(50, out dibujoAzul);
            Console.ForegroundColor = boligrafoAzul.GetColor();
            Console.WriteLine(dibujoAzul);
                       
            boligrafoRojo.Pintar(50, out dibujoRojo);
            Console.ForegroundColor = boligrafoRojo.GetColor();
            Console.WriteLine(dibujoRojo);

            boligrafoRojo.Pintar(10, out dibujoRojo);
            Console.ForegroundColor = boligrafoRojo.GetColor();
            Console.WriteLine(dibujoRojo);



        }
    }
}