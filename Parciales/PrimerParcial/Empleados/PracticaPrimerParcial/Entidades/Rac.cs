using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rac : Empleado
    {
        public enum EGrupo { CALL_IN, CALL_OUT, RRSS};
        private EGrupo grupo = EGrupo.CALL_IN;
        private static double valorHora;

        static Rac()
        {
            Rac.valorHora = 875.90F; //estatic, lo llama el clr
        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso) 
            :base(legajo, nombre, horaIngreso)
        {

        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo grupo)
            : this(legajo, nombre, horaIngreso)
        {
            this.grupo = grupo;
        }

        public EGrupo Grupo
        {
            get { return grupo; }
        }

        public double ValorHora
        {
            get { return Rac.valorHora; }
            set 
            { 
                if (value > 0)
                {
                    Rac.valorHora = value;
                }
            }
        }

        private double CalcularBonoDeGrupo()
        {
            double returnAux = 1;

            switch (grupo)
            {
                case EGrupo.CALL_IN:
                    {
                        returnAux = 0;
                        break;
                    }
                case EGrupo.CALL_OUT: 
                    { 
                        returnAux = 0.1; 
                        break;
                    }
                case EGrupo.RRSS:
                    {
                        returnAux = 0.2;
                        break;
                    }
            }

            return returnAux;
        }

        public override string EmitirFactura()
        {
            return $"Factura de {this.ToString()}\n Importa a facturar: {this.Facturar()}";
        }

        protected double Facturar()
        {
            double salario = base.Facturar() * this.ValorHora;
            double bono = salario * this.CalcularBonoDeGrupo();
            return salario + bono;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.grupo} - {base.Legajo} - {base.Nombre}";
        }

    }
}
