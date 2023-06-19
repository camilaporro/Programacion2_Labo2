namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double ladoCuadrado = 4;
            const double baseTriangulo = 4;
            const double alturaTriangulo = 8;
            const double radioCirculo = 5;

            double areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);
            double areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
            double areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);

            Console.WriteLine($"El area de un cuadrado de lado {ladoCuadrado}cm es de {areaCuadrado}cm cubicos ");
            Console.WriteLine($"El area de un triangulo de base {baseTriangulo}cm y altura {alturaTriangulo} es de {areaTriangulo}cm cubicos");
            Console.WriteLine("El area de un circulo de radio {0,0}cm es de {1,0:#.##}cm cubicos", radioCirculo, areaCirculo);

        }
    }
}