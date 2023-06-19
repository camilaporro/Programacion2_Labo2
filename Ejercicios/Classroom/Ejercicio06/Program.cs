namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYear;
            int endingYear;


            static bool IsLeapYear(int year)
            {
                if(year % 4 == 0 && (year % 100 !=0 || year % 400 == 0))
                {
                    return true;
                }
                else { return false; }
            }

            Console.WriteLine("Ingrese el año de inicio: ");
            int.TryParse(Console.ReadLine(), out startYear);
            Console.WriteLine("Ingrese el año de finalizacion: ");
            int.TryParse(Console.ReadLine(), out endingYear);

            Console.WriteLine($"Los años bisiestos entre {startYear} y {endingYear} son: ");

            Console.WriteLine(IsLeapYear(startYear));

            
            for (int year = startYear; year <= endingYear; year++)
            {
                if(IsLeapYear(year)) { Console.WriteLine(year); }
            }

        }
    }
}