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
            int numero1;
            int numero2;

            if (numeros.Contains(','))
            {
                string[] elementos = numeros.Split(',');
                int.TryParse(elementos[0], out numero1);
                int.TryParse(elementos[1], out numero2);

                returnAux = numero1 + numero2;
            }
            else
            {
                int.TryParse(numeros, out numero1);
                returnAux = numero1;
            }


            return returnAux;
                
        }
    }
}
