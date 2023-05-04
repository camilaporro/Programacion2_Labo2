using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supervisor : Empleado
    {
        private static float valorHora;

        static Supervisor()
        {
            Supervisor.valorHora = 1025.50F;
        }

        private Supervisor(string legajo) : this(legajo, "n/a", (new TimeSpan(09, 00, 00)))
        {

        }

        public Supervisor(string legajo, string nombre, TimeSpan horaIngreso) 
            : base(legajo, nombre, horaIngreso)
        {

        }

        public float ValorHora
        {
            get { return Supervisor.valorHora; }
            set
            {
                if (value > 0) { Supervisor.valorHora = value; } 
            }
        }

        public override string EmitirFactura()
        {
            return $"Factura de: {this.ToString()}\nImporte a facturar: {this.Facturar()}";
        }

        protected override double Facturar()
        {
            return base.Facturar() * this.ValorHora;
        }

        public static implicit operator Supervisor(string legajo)
        {
            return new Supervisor(legajo);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {base.Legajo} - {base.Nombre}";
        }

    }
}
