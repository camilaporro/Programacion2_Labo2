using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private string email;
        private Materia.EMateria materiaAsignada;

        public Profesor(int dni) : base(dni) { }

        public Profesor(int dni, string email) : this(dni)
        {
            this.email = email;
        }

        public Profesor(int dni, string email, Materia.EMateria materiaAsignada) : this(dni, email)
        {
            this.materiaAsignada = materiaAsignada;
        }

        public override string Informacion
        {
            get { return this.MostrarDatos(); }
        }

        public Materia.EMateria Materia
        {
            get { return this.materiaAsignada; }
            set { this.materiaAsignada = value; }
        }

        public bool Evaluar(Alumno alumno)
        {
            if (alumno.RendirExamen(this.Materia))
            {
                return true; //el alumno rindio la materia
            }
            else { return false;  }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Email: {this.email}");

            return sb.ToString();
        }

        public override string ToString() 
        {
            return $"Profesor - {this.materiaAsignada}";
        }
    }
}
