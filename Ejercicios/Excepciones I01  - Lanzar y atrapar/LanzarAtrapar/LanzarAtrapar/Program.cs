using Entidades.Excepciones;
using Entidades.Modals;

namespace LanzarAtrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase clase = new OtraClase();

            try
            {
                clase.MetodoInstancia();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);  
                }

            }

        }
    }
}