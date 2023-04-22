namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;
            char respuesta;

            do 
            {
                Console.Write("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                acumulador += numeroIngresado;

                Console.Write("Continuar? (S/N): ");
                char.TryParse(Console.ReadLine(), out respuesta);
            }
            while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine($"\nLa suma de los numeros ingresados es {acumulador}");
            Console.ReadKey();
        }
    }
}