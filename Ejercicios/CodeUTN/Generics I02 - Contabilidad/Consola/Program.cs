using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(1);
            Factura factura2 = new Factura(2);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Documento d in contabilidad.egresos)
            {
                Console.WriteLine(d.Numero);
            }
            foreach (Documento d in contabilidad.ingresos)
            {
                Console.WriteLine(d.Numero);
            }


        }
    }
}