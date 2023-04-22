using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if(nota1 > 4 && nota2 > 4) 
            {
                Random numeroRandom = new Random();
                this.notaFinal = numeroRandom.Next(nota1, nota2);
            }
            else { this.notaFinal = -1; }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string retornoAux = $"Alumno/a: {this.apellido}, {this.nombre} -- Legajo: {this.legajo} ";

            if(this.notaFinal != -1)
            {
                retornoAux += $"-- La nota final es {this.notaFinal}";
            }
            else { retornoAux += "-- Alumno/a Desaprobado/a";  }

            return retornoAux;
        }
        
    }
}
