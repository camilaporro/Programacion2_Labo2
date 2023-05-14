using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades.Modals
{
    public class MiClase
    {


        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (Exception ex)
            {
                //relanzo la excepcion pero pierdo el stack trace
                throw ex;
            }
        }

        public MiClase(int id)
        {
            try
            {
                new MiClase();
            }
            catch (Exception ex) 
            {
                throw new UnaExcepcion("Excepcion en el contructor", ex);
            }
        }

        public static void MetodoEstatico()
        {
            //lanzar una excepcion
            throw new DivideByZeroException("Excepcion en el metodo estatico de MiClase");
        }
    }
}
