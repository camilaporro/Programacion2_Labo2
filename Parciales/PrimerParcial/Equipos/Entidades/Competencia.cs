using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        private Competencia(string nombre) : this(nombre, 5)
        {
            this.nombre = nombre;
        }

        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.equipos = new List<Equipo>();
        }

        public int CantidadCompetidores
        {
            get {  return cantidadCompetidores; } 
            set { this.cantidadCompetidores = value; }
        }

        public List<Equipo> Equipos
        {
            get { return this.equipos; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***** COMPETENCIA *****");
            sb.AppendLine($"Nombre: {torneo.Nombre}");
            sb.AppendLine($"Cantidad de competidores: {torneo.CantidadCompetidores}");
            sb.AppendLine("** Lista de competidores:**");

            foreach (Equipo equipo in torneo.Equipos)
            {
                sb.AppendLine($"{equipo.ToString()}");
            }

            return sb.ToString();
        }

        public static implicit operator Competencia(string nombre)
        {
            Competencia c = new Competencia(nombre);
            return c;
        }

        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            bool returnAux = false;
            foreach (Equipo e in torneo.Equipos)
            {
                if (equipo.Equals(e))
                {
                    returnAux = true;
                }
            }

            return returnAux;

        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if (torneo != equipo && torneo.Equipos.Count <= torneo.CantidadCompetidores)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }
    }
}
