namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double resultado;
            char operacion;
            bool continuarCarga;


            do
            {
                Console.Write("Ingrese el primer numero: ");
                double.TryParse(Console.ReadLine(), out numero1);

                Console.Write("\nIngrese el segundo numero: ");
                double.TryParse(Console.ReadLine(), out numero2);

                Console.Write("\nIngrese el la operacion (+, -, * o /): ");
                char.TryParse(Console.ReadLine(), out operacion);

                resultado = Calculadora.Calcular(numero1, numero2, operacion);

                Console.WriteLine($"\n\nEl resultado de la operacion es {resultado}");

                Console.WriteLine("\n\nDesea realizar otra operacion? (si - no)");
                string respuesta = Console.ReadLine();
                continuarCarga = respuesta == "si";
            }
            while(continuarCarga);

            

        }
    }
}