using System.Drawing;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b) 
        {
            cantidadSumas += 1;
            
            return string.Format(a, b);
        }

        //Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int(Sumador s) 
        {
            return s.cantidadSumas;
        }

        //Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor.
        public static long operator +(Sumador s1, Sumador s2) 
        {
            return (int)s1 + (int)s2; //conversor int devuleve la cantidad de sumas
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if ((int)s1 == (int)s2) { return true; }

            return false;
        }

        public int GetCantidad()
        {
            return this.cantidadSumas;
        }
    }
}