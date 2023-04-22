namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombreEmpleado;
            int antiguedad;
            int horasTrabajadas;
            const int valorAntiguedad = 150;
            const double porcentajeDescuento = 0.13;
            double descuento;
            bool continuaCarga = true;
            double sueldoBruto;
            double sueldoNeto;

            while (continuaCarga) 
            {
                Console.WriteLine("Ingrese el nombre y apellido:");
                nombreEmpleado = Console.ReadLine();

                Console.WriteLine($"Ingrese las horas trabajadas de {nombreEmpleado}");
                int.TryParse(Console.ReadLine(), out horasTrabajadas);

                Console.WriteLine($"Ingrese el valor de las horas trabajadas de {nombreEmpleado}");
                int.TryParse(Console.ReadLine(), out valorHora);

                Console.WriteLine($"Ingrese la antiguedad en años de {nombreEmpleado}");
                int.TryParse(Console.ReadLine(), out antiguedad);

                sueldoBruto = (valorHora * horasTrabajadas) + (valorAntiguedad * antiguedad);
                descuento = sueldoBruto * porcentajeDescuento;
                sueldoNeto = sueldoBruto - descuento;

                Console.WriteLine("\n==============================================================");
                Console.WriteLine($"Nombre: {nombreEmpleado} -- Antigüedad: {antiguedad} -- Valor hora: ${valorHora}");
                Console.WriteLine($"Sueldo bruto: ${sueldoBruto} -- Descuentos: ${descuento} -- Sueldo neto: ${sueldoNeto}");
                Console.WriteLine("==============================================================");

                Console.WriteLine("\n\nDesea cargar otro empleado? (si - no)");
                string respuesta = Console.ReadLine();
                continuaCarga = respuesta == "si";

            }


        }
    }
}