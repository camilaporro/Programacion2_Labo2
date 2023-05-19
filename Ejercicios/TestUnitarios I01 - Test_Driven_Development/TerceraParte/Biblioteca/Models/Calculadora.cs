using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Calculadora
    {

        public int Add(string numeros)
        {
            int returnAux = 0;
            int resultado = 0;


            if (numeros.Contains(','))
            {
                string[] elementos = numeros.Split(',','\n');

                foreach (string numero in elementos)
                {
                    resultado += int.Parse(numero);
                }

                returnAux = resultado;

            }
            else
            {
                int.TryParse(numeros, out resultado);
                returnAux = resultado;
            }


            return returnAux;
                
        }
    }
}
