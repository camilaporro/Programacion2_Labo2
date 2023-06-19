namespace Ejercio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosPerfectos = 0;
            int numeroEvaluado = 1;
            int sumaDeDivisores = 0;

            while (numerosPerfectos < 4)
            {
                for (int divisor = 1; divisor < numeroEvaluado; divisor++)
                {
                    if(numeroEvaluado % divisor == 0)
                    {
                        sumaDeDivisores += divisor;
                    }
                }

                if(sumaDeDivisores == numeroEvaluado)
                {
                    Console.WriteLine(numeroEvaluado);
                    numerosPerfectos++;
                }

                sumaDeDivisores = 0;
                numeroEvaluado++;
            }
        }
    }
}