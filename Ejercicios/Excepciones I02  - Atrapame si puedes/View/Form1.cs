using Entidades;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtKilometros.Text == "" || this.txtLitros.Text == "")
                {
                    throw new ParametrosVaciosException("No puede dejar campos vacios.");
                }

                int resultado = Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text));
                this.richTextBox1.Text = $"km / hs: {resultado}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}