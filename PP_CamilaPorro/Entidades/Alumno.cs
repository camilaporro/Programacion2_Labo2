
using System.Text;

namespace Entidades
{
    public class Alumno : Persona
    {
        private string legajo;
        private Dictionary<Materia.EMateria, List<int>> materiasAsignadas;

        private Alumno(int dni) : base(dni)
        {
            materiasAsignadas = new Dictionary<Materia.EMateria, List<int>>();
        }

        public Alumno(int dni, string legajo) : this(dni)
        {
            this.legajo = legajo;
        }

        public override string Informacion
        {
            get { return this.MostrarDatos(); }
        }



        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Materias asignadas:");


            foreach (Materia.EMateria materia in materiasAsignadas.Keys)
            {
                sb.AppendLine($"{materia}:");

                List<int> notas = this[materia]; //indexador
                if (notas != null)
                {
                    foreach (int nota in notas)
                    {
                        sb.AppendLine($"- {nota}");
                    }
                }
            }

            return sb.ToString();
            
        }

        public bool RendirExamen(Materia.EMateria materia)
        {
            if (!materiasAsignadas.ContainsKey(materia)) //si no esta anotado en la materia
            {
                return false;
            }
            else
            {
                Random random = new Random();
                int nota = random.Next(1, 10);
                materiasAsignadas[materia].Add(nota);
                return true;
            }
        }

        public override string ToString()
        {
            return $"Alumno - {this.legajo}";
        }

        public static implicit operator Alumno(string dni)
        {
            int dniIngresado = 0;
            int.TryParse(dni, out dniIngresado);

            Alumno alumno = new Alumno(dniIngresado); //genero instancia alumno
            alumno.legajo = alumno.GetHashCode().ToString(); //le asigno el hashcode de la instancia

            return alumno;
        }

        public static bool operator ==(Alumno alumno, Materia.EMateria materia)
        {
            return alumno.materiasAsignadas.ContainsKey(materia);
        }

        public static bool operator !=(Alumno alumno, Materia.EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, Materia.EMateria materia)
        {
            if (alumno == materia)
            {
                return false;
            }
            else
            {
                alumno.materiasAsignadas[materia] = new List<int>();
                return true;
            }
        }

        public List<int> this[Materia.EMateria materia]
        {
            get
            {
                if (materiasAsignadas.ContainsKey(materia)) //this == materia; utilizar la sobrecarga
                {
                    return materiasAsignadas[materia]; // this.materiasAsignadas[materia];
                }
                else
                {
                    return null;
                }
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}