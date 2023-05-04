using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class EquipoBasket : Equipo
    {
        public enum ELiga { NBA, Euroleague, ACB};
        private ELiga liga = ELiga.NBA;

        public EquipoBasket(string nombre) : base(nombre) { }

        public EquipoBasket(string nombre, ELiga liga) : this(nombre) 
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            Random random = new Random();
            int dificultad = 0;

            switch(liga)
            {
                case ELiga.NBA:
                    {
                        dificultad = random.Next(8, 10);
                        break;
                    }

                case ELiga.Euroleague:
                    {
                        dificultad = random.Next(5, 10);
                        break;
                    }

                case ELiga.ACB:
                    {
                        dificultad = random.Next(1, 7);
                        break;
                    }
            }

            return dificultad;

        }

        protected override string MostrarDatos()
        {
            return $"Basket - {base.MostrarDatos()}";
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
