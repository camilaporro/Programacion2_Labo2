using System.Text;

namespace HolaWindowsFrm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMaterias.Items.Add("Programacion I");
            comboBoxMaterias.Items.Add("Laboratorio de Computación I");
            comboBoxMaterias.Items.Add("Sistema de procesamiento de datos");
            comboBoxMaterias.Items.Add("Inglés I");
            comboBoxMaterias.Items.Add("Matemática");
            comboBoxMaterias.Items.Add("Programación II");
            comboBoxMaterias.Items.Add("Laboratorio de Computación II");
            comboBoxMaterias.Items.Add("Inglés II");
            comboBoxMaterias.Items.Add("Metodología de la investigación");
            comboBoxMaterias.Items.Add("Arquitectura y sistemas operativos");
            comboBoxMaterias.Items.Add("Estadística");
            comboBoxMaterias.SelectedIndex = 0;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            if(Validar())
            {
                string titulo = "¡Hola, Windows Forms!";
                string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {comboBoxMaterias.SelectedItem}";

                Form formMensaje = new Form2(titulo, mensaje);
                formMensaje.ShowDialog();
            }
            


        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos: ");

            if(String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;

        }


    }
}