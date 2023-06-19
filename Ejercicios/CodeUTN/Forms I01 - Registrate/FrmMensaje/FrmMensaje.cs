namespace FrmMensaje
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje(string mensaje)
        {
            InitializeComponent();
            lblInformacion.Text = mensaje;

        }
    }
}