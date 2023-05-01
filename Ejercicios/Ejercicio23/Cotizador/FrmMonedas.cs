using Billetes;

namespace Cotizador
{
    public partial class FrmMonedas : Form
    {
        private Euro euro;
        private Peso peso;
        private Dolar dolar;

        public FrmMonedas()
        {
            InitializeComponent();
        }



        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.txtCotizacionEuro.Text.Equals("") || this.txtCotizacionPeso.Text.Equals(""))
            {
                MessageBox.Show("Ingrese todas la cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.btnLockCotizacion.ImageIndex == 0)
                {
                    this.btnLockCotizacion.ImageIndex = 1; //abierto, editable
                    txtCotizacionEuro.Enabled = true;
                    txtCotizacionPeso.Enabled = true;
                }
                else
                {
                    this.btnLockCotizacion.ImageIndex = 0;// cerrado, no editable
                    txtCotizacionEuro.Enabled = false;
                    txtCotizacionPeso.Enabled = false;
                }
            }



        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double numeroIngresado;
            double.TryParse(this.txtCotizacionEuro.Text, out numeroIngresado);
            Euro.SetCotizacion(numeroIngresado);

        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double numeroIngresado;
            double.TryParse(this.txtCotizacionPeso.Text, out numeroIngresado);
            Peso.SetCotizacion(numeroIngresado);
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            double cantidadIngresada = 0;
            double.TryParse(this.txtDolar.Text, out cantidadIngresada);
            this.dolar = cantidadIngresada;
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {
            double cantidadIngresada = 0;
            double.TryParse(this.txtEuro.Text, out cantidadIngresada);
            this.euro = cantidadIngresada;
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            double cantidadIngresada = 0;
            double.TryParse(this.txtPeso.Text, out cantidadIngresada);
            this.peso = cantidadIngresada;
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(1))
                MessageBox.Show("Debe bolquear las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.txtDolar.Text.Equals(""))
                MessageBox.Show("No se ingreso la cantidad de dolares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.txtDolarADolar.Text = dolar.GetCantidad().ToString();
                this.txtDolarAPeso.Text = (((Peso)dolar).GetCantidad()).ToString(); //me da la cantidad de pesos una vez que fue convertido de dolar a peso
                this.txtDolarAEuro.Text = (((Euro)dolar).GetCantidad()).ToString();
            }

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(1))
                MessageBox.Show("Debe bolquear las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.txtEuro.Text.Equals(""))
                MessageBox.Show("No se ingreso la cantidad de euros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.txtEuroAEuro.Text = euro.GetCantidad().ToString();
                this.txtEuroAPeso.Text = (((Peso)euro).GetCantidad()).ToString("N2"); //muestra solo 2 decimales
                this.txtEuroADolar.Text = (((Dolar)euro).GetCantidad()).ToString("N2");
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex.Equals(1))
                MessageBox.Show("Debe bolquear las cotizaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.txtPeso.Text.Equals(""))
                MessageBox.Show("No se ingreso la cantidad de pesos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.txtPesoAPeso.Text = peso.GetCantidad().ToString();
                this.txtPesoAEuro.Text = (((Euro)peso).GetCantidad()).ToString("N2");
                this.txtPesoADolar.Text = (((Dolar)peso).GetCantidad()).ToString("N2");
            }
        }
    }
}