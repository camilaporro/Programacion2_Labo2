namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            int daysLived;

            Console.WriteLine("Ingrese el año de su nacimiento:");
            int.TryParse(Console.ReadLine(), out year);

            Console.WriteLine("Ingrese el mes de su nacimiento (1 - 12):");
            int.TryParse(Console.ReadLine(), out month);
            
            Console.WriteLine("Ingrese el dia de su nacimiento (1 - 31):");
            int.TryParse(Console.ReadLine(), out day);

            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            daysLived = (int)(currentDate - birthDate).TotalDays;

            Console.WriteLine($"Usted ha vivido {daysLived} dias.");
        }
    }
}