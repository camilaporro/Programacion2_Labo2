namespace Ejercicio3
{
    internal class Program
    {
        private static bool EsPrimo(int numero)
        {
            if (numero < 2) {return false;}
            else
            {
                for (int i = 2; i < numero; i++)
                {
                    if ((numero % i) == 0){return false;}
                }
                return true;
              
            }
        }
        
        static void Main(string[] args)
        {
            int numeroIngresado;

            Console.WriteLine("Ingrese un numero:");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            Console.WriteLine($"Los numeros primos hasta el {numeroIngresado} son:"); //considera el numero ingresado
            for (int i = 0; i <= numeroIngresado; i++)
            {
                if (EsPrimo(i)) { Console.WriteLine(i); }
            }
        }
    }
}