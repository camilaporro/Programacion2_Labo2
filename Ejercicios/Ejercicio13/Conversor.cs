using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Conversor
    {
        public static string DecimalBinario (int entero)
        {
            string binario = "";
            int resto;

            while(entero > 0) 
            {
                resto = entero % 2;
                binario = resto.ToString() + binario;
                entero = entero / 2;
            }

            return binario;
        }

        public static int BinarioDecimal(string binario)
        {
            int entero = 0;
            int exponente = 0;
            int digitoBinario;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                int.TryParse(binario[i].ToString(), out digitoBinario);
                entero += digitoBinario * (int)Math.Pow(2, exponente);
                exponente++;
            }

            return entero;
        }


    }
}
