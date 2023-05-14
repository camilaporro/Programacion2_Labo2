using Entidades;
using static Entidades.Materia;

namespace PrimerParicial
{
    public partial class IngresoAlumnos : Form
    {
        private Persona alumno;
        private Persona profesorProgra;
        private Curso cursoProgramacion;
        private Persona profesorLabo;
        private Curso cursoLaboratorio;



        public IngresoAlumnos()
        {
            InitializeComponent();
            profesorLabo = new Profesor(99000123, "profesorLabo @email.com", EMateria.Laboratorio);
            profesorProgra = new Profesor(99000123, "profesorProgra @email.com", EMateria.Programacion);
            cursoProgramacion = new Curso((Profesor)profesorProgra);
            cursoLaboratorio = new Curso((Profesor)profesorLabo);

        }

        private void IngresoAlumnos_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            alumno = (Alumno)this.txtDni.Text;
            alumno.Nombre = this.txtNombre.Text;
            alumno.Apellido = this.txtApellido.Text;
            this.lstAlumnosCreados.Items.Add(alumno);
        }

        private void ActualizarIncriptos()
        {
            this.lstAlumnosInscriptosLaboratorio.DataSource = null;
            this.lstAlumnosInscriptosProgramacion.DataSource = null;
            this.lstAlumnosInscriptosLaboratorio.DataSource =
            this.cursoLaboratorio.Alumnos;
            this.lstAlumnosInscriptosProgramacion.DataSource =
            this.cursoProgramacion.Alumnos;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            EMateria materia = (EMateria)this.cmbMaterias.SelectedItem;
            string mensaje = string.Empty;
            if (materia == EMateria.Programacion)
            {
                mensaje = cursoProgramacion.InscribirAlumno((Alumno)alumno);
            }
            else
            {
                mensaje = cursoLaboratorio.InscribirAlumno((Alumno)alumno);
            }

        }
    }
}