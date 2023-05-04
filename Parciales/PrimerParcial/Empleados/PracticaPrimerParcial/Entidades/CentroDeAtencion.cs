using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentroDeAtencion
    {
        private string nombre;
        private int cantRacsPorSuper;
        private List<Empleado> empleados;

        public CentroDeAtencion(string nombre, int cantRacsPorSuper)
        {
            this.nombre = nombre;
            this.empleados = new List<Empleado>();
            this.cantRacsPorSuper = cantRacsPorSuper;

            /*
            int cantidadRacs = 0;
            foreach (Empleado emp in empleados)
            {
                if (emp is Rac)
                {
                    cantidadRacs++;
                }
            }*/

        }

        public List<Empleado> Empleados
        {
            get { return this.empleados; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string ImprimirNomina()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***** EMPLEADOS *****");
            foreach(Empleado emp in this.Empleados) 
            {
                sb.AppendLine(emp.ToString());
            }

            return sb.ToString();
        }

        private bool ValidaCantidadDeRacs()
        {
            int cantidadRacs = 0;

            foreach (Empleado emp in this.Empleados)
            {
                if (emp is Rac)
                {
                    cantidadRacs++;
                }
            }

            if (cantidadRacs > 5)
            {
                return true;
            }
            else { return false; }
        }

        public static bool operator ==(CentroDeAtencion c, Empleado e)
        {
            bool returnAux = false;
            foreach (Empleado empleado in c.empleados)
            {
                if (empleado == e) 
                {
                    returnAux = true;
                    break;
                }
            }

            return returnAux;
        }

        public static bool operator !=(CentroDeAtencion c, Empleado e)
        {
            return !(c == e);
        }

        public static bool operator +(CentroDeAtencion c, Empleado e)
        {
            bool returnAux = false; 
            if (c != e)
            {
                if (e is Supervisor)
                {
                    if (!c.ValidaCantidadDeRacs())
                    {
                        c.empleados.Add(e);
                        returnAux = true;
                    }
                }
                else 
                {
                    c.empleados.Add(e);
                    returnAux = true;
                }
            }

            return returnAux;
        }

        public static string operator -(CentroDeAtencion c, Empleado e)
        {
            if(c != e) { return "Empleado no encontrado"; }
            else
            {
                e.HoraEgreso = DateTime.Now.TimeOfDay;
                c.empleados.Remove(e);
                return e.EmitirFactura();

            }
        }



    }
}
