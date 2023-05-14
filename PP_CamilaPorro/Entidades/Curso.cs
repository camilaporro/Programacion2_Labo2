using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Persona> alumnos;
        private Materia.EMateria materia;
        private Persona profesor;

        public Curso(Profesor profesor) 
        {
            this.materia = profesor.Materia;
            this.profesor = profesor;
            alumnos = new List<Persona>(); //this.alumnos
        }

        public List<Persona> Alumnos
        {
            get { return this.alumnos; }
        }

        public Profesor Profesor
        {
            get { return (Profesor)profesor; }
            set { this.profesor = value; }
        }

        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (Alumno alumno in curso.Alumnos)
            {
                alumno.RendirExamen(curso.materia);
            }
        }

        public string InscribirAlumno(Alumno alumno)
        {
            string mensaje;

            /*
            if (this == alumno && (alumno + this.materia)) //operador + en alumno chequea que no haya sido inscripto
            {
                mensaje = $"Ya inscripto o no se pudo inscribir el alumno a la materia {this.materia}";
            }
            else
            {
                this.alumnos.Add(alumno);
                mensaje = $"Se inscribio al alumno a la materia {this.materia}\n{alumno.Informacion}";
            }*/

            //forma correcta es esta, mal la logica de arriba y no agregaba la materia al alumno
            if (this != alumno && (alumno + this.materia)) //operador + en alumno chequea que no haya sido inscripto
            {
                this.alumnos.Add(alumno);
                mensaje = $"Se inscribio al alumno a la materia {this.materia}\n{alumno.Informacion}";
                
            }
            else
            {
                mensaje = $"Ya inscripto o no se pudo inscribir el alumno a la materia {this.materia}";                
            }
             
            

            return mensaje;
        }

        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(curso.ToString());
            sb.AppendLine($"Profesor: {curso.Profesor}");
            sb.AppendLine($"Lista de alumnos:");

            foreach (Alumno alumno in curso.alumnos)
            {
                sb.AppendLine(alumno.Informacion);
            }

            return sb.ToString();

        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            bool returnAux = false;

            //tambien se podia usar el contains que por detras utiliza el Equals que se sobrecargo antes
            // si no se sobrecarga el equals hay que usar el ==

            foreach (Alumno a in curso.Alumnos)
            {
                if (a == alumno)
                {
                    returnAux = true;
                    break;
                }
            }

            return returnAux;
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }

        public override string ToString()
        {
            return $"Curso de - {this.materia}";
        }



    }
}
