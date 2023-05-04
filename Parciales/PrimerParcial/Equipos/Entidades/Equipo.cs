using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntiacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre 
        {
            get { return this.nombre; }
        }

        public int PE
        {
            get { return this.partidosEmpatados; }
            set { this.partidosEmpatados = value; }
        }

        public int PG
        {
            get { return this.partidosGanados; }
            set { this.partidosGanados = value; }
        }

        public int PJ
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }

        public int PP
        {
            get { return this.partidosPerdidos; }
            set { this.partidosPerdidos = value; }
        }

        public int Puntuacion
        {
            get { return this.puntiacion; }
            set { this.puntiacion = value; }
        }

        public string Tipo 
        { 
            get { return this.GetType().Name; }
        }

        public abstract int GetDificultad();

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool returnAux = false;

            if (equipoA.Equals(equipoB))
            {
                equipoA.PJ++;
                equipoB.PJ++;
                returnAux = true;

                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.PG ++;
                    equipoA.Puntuacion += 3;
                    equipoB.PP++;

                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                    equipoA.PP++;
                }
                else
                {
                    equipoA.PE++;
                    equipoA.Puntuacion += 1;
                    equipoB.PE++;
                    equipoB.Puntuacion += 1;
                }
            }

            return returnAux;
                
        }

        public override bool Equals(object? obj)
        {
            if (obj is Equipo otroEquipo)
            {
                return this.Tipo == otroEquipo.Tipo;
            }
            else
            {
                return false;
            }
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del equipo : {this.Nombre}");

            return sb.ToString();
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return (equipoA.Equals(equipoB) && equipoA.Nombre == equipoB.Nombre);
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }


    }
}