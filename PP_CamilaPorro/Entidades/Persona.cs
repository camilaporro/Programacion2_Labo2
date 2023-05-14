using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        protected int dni;

        protected Persona(int dni)
        {
            this.dni = dni;
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public abstract string Informacion { get; }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();

        }

        public override bool Equals(object? obj)
        {
            if (obj is Persona otraPersona)
            {
                return this == otraPersona;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return dni.GetHashCode() ;
        }

        public static bool operator ==(Persona personaA, Persona personaB)
        {
            return personaA.dni == personaB.dni;
        }


        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }


    }

}
