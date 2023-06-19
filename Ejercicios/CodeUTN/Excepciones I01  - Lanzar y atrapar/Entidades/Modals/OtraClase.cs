using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades.Modals
{
    public class OtraClase
    {
        public void MetodoInstancia() 
        {
            try 
            {
                new MiClase(1504);
            } 
            catch (Exception ex) 
            {
                throw new MiExcepcion("Excepcion otra clase", ex);
            }
        }
    }
}
