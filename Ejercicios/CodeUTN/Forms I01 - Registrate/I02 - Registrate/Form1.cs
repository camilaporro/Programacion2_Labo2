using Biblioteca;
using System.Text;

namespace I02___Registrate
{
    public partial class Form1 : Form
    {
        RadioButton generoSeleccionado = new RadioButton();
        string[] cursosSeleccionados = new string[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxPaises.Items.Add("Argentina");
            listBoxPaises.Items.Add("Uruguay");
            listBoxPaises.Items.Add("Chile");
            listBoxPaises.SelectedIndex = 0;
        }



        private void btIngresar_Click(object sender, EventArgs e)
        {
            Ingresante alumno = new Ingresante(txtNombre.Text, txtDireccion.Text, generoSeleccionado.Text, listBoxPaises.SelectedItem.ToString(), cursosSeleccionados, (int)numericEdad.Value);
            Form form = new Form2(alumno.Mostrar());
            form.ShowDialog();
        }

        private void gbGenero_Leave(object sender, EventArgs e)
        {
            if (rbFemenino.Checked) { generoSeleccionado = rbFemenino; }
            else if (rbMasculino.Checked) { generoSeleccionado = rbMasculino; }
            else { generoSeleccionado = rbNobinario; }
        }

        private void gbCursos_Leave(object sender, EventArgs e)
        {
            List<string> cursos = new List<string>();

            //controls me devuelve una coleccion de todos los tipos de controles en el group box
            //ofType filtra el tipo de control que quiero que me devuelva <>
            foreach (CheckBox checkBox in gbCursos.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked) { cursos.Add(checkBox.Text); }
            }

            cursosSeleccionados = cursos.ToArray();
        }
    }
}