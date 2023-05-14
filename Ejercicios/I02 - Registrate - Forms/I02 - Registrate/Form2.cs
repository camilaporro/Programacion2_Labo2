using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I02___Registrate
{
    public partial class Form2 : Form
    {
        public Form2(string mensaje)
        {
            InitializeComponent();
            lblInformacion.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
