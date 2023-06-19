using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public string Nombre { get => nombre;}

        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            if (equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        public string Ficha()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion.ToString()}";
        }
    }
}
