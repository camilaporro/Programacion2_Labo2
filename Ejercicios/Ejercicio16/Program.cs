namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno[] alumnos = new Alumno[3];
            int legajo;
            byte notaUno;
            byte notaDos;

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write("\nIngrese el apellido del alumno/a: ");
                string? apellido = Console.ReadLine();

                Console.Write("Ingrese el nombre del alumno/a: ");
                string? nombre = Console.ReadLine();

                Console.Write("Ingrese el numero de legajo del alumno/a: ");
                int.TryParse(Console.ReadLine(), out legajo);

                alumnos[i] = new Alumno(apellido, nombre, legajo);

                Console.Write($"Ingrese la primer nota de {apellido}, {nombre}: ");
                byte.TryParse(Console.ReadLine(), out notaUno);

                Console.Write($"Ingrese la segunda nota de {apellido}, {nombre}: ");
                byte.TryParse(Console.ReadLine(), out notaDos);

                alumnos[i].Estudiar(notaUno, notaDos);
            }

            foreach (Alumno alumno in alumnos)
            {
                alumno.CalcularFinal();
                Console.WriteLine("\n"+alumno.Mostrar());
            }
        }
    }
}