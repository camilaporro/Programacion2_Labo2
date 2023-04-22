namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingresoUsuario;
            double numeroIngresado;
            double numeroAlCubo;
            double numeroAlCuadrado;

            Console.WriteLine("Ingrese un numero: ");
            ingresoUsuario = Console.ReadLine();

            while(!(double.TryParse(ingresoUsuario, out numeroIngresado)) || numeroIngresado <= 0 )
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un numero: ");
                ingresoUsuario = Console.ReadLine();
                double.TryParse(ingresoUsuario, out numeroIngresado);
            }

            numeroAlCubo = Math.Pow(numeroIngresado, 3);
            numeroAlCuadrado = Math.Pow(numeroIngresado, 2);

            Console.WriteLine($"{numeroIngresado} elevado al cuadrado es {numeroAlCuadrado}");
            Console.WriteLine($"{numeroIngresado} elevado al cubo es {numeroAlCubo}");

        }
    }
}