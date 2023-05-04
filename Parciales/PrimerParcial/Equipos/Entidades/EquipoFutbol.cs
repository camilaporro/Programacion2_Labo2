using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas = false;

        public EquipoFutbol(string nombre) : base(nombre) { }

        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : this(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }

        public override int GetDificultad()
        {
            Random random = new Random();
            int dificultad = random.Next(7, 10);

            if (this.jugadoresEstrellas)
            {
                dificultad *= 2;
            }

            return dificultad;

        }

        protected override string MostrarDatos()
        {
            return $"Futbol - {base.MostrarDatos()}";
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
