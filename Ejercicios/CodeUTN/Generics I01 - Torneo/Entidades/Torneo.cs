using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        

        private Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre) : this() 
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre;}

        public static bool operator ==(Torneo<T> torneo, T nuevoEquipo)
        {
            foreach (Equipo equipo in torneo.equipos)
            {
                if (equipo == nuevoEquipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T nuevoEquipo)
        {
            return !(torneo == nuevoEquipo);
        }

        public static bool operator +(Torneo<T> torneo, T nuevoEquipo)
        {
            if (torneo != nuevoEquipo)
            {
                torneo.equipos.Add(nuevoEquipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {this.nombre}");
            foreach (T equipo in this.equipos)
            {
                sb.AppendLine(equipo.Ficha());
            }

            return sb.ToString(); 
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random r = new Random();
            return $"{equipo1.Nombre}{r.Next(0,10)} - {equipo2.Nombre}{r.Next(0, 10)}";
        }

    }
}