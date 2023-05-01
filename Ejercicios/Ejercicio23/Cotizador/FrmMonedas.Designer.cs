namespace Cotizador
{
    partial class FrmMonedas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            btnConvertDolar = new Button();
            btnConvertEuro = new Button();
            btnConvertPeso = new Button();
            btnLockCotizacion = new Button();
            imageList1 = new ImageList(components);
            lblEuro = new Label();
            lblEuroA = new Label();
            lblDolar = new Label();
            lblDolarA = new Label();
            lblPeso = new Label();
            lblPesoA = new Label();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            txtPeso = new TextBox();
            txtDolarADolar = new TextBox();
            txtEuroADolar = new TextBox();
            txtPesoADolar = new TextBox();
            txtDolarAEuro = new TextBox();
            txtEuroAEuro = new TextBox();
            txtPesoAEuro = new TextBox();
            txtPesoAPeso = new TextBox();
            txtEuroAPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            txtCotizacionDolar = new TextBox();
            txtCotizacionEuro = new TextBox();
            txtCotizacionPeso = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(227, 80);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(73, 28);
            btnConvertDolar.TabIndex = 0;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(227, 144);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(73, 28);
            btnConvertEuro.TabIndex = 1;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(227, 204);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(73, 28);
            btnConvertPeso.TabIndex = 2;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // btnLockCotizacion
            // 
            btnLockCotizacion.ImageIndex = 1;
            btnLockCotizacion.ImageList = imageList1;
            btnLockCotizacion.Location = new Point(232, 9);
            btnLockCotizacion.Name = "btnLockCotizacion";
            btnLockCotizacion.Size = new Size(64, 64);
            btnLockCotizacion.TabIndex = 3;
            btnLockCotizacion.UseVisualStyleBackColor = true;
            btnLockCotizacion.Click += btnLockCotizacion_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "lock.png");
            imageList1.Images.SetKeyName(1, "unlock.png");
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuro.Location = new Point(24, 148);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(32, 15);
            lblEuro.TabIndex = 4;
            lblEuro.Text = "Euro";
            // 
            // lblEuroA
            // 
            lblEuroA.AutoSize = true;
            lblEuroA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuroA.Location = new Point(523, 58);
            lblEuroA.Name = "lblEuroA";
            lblEuroA.Size = new Size(32, 15);
            lblEuroA.TabIndex = 5;
            lblEuroA.Text = "Euro";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolar.Location = new Point(24, 89);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(37, 15);
            lblDolar.TabIndex = 6;
            lblDolar.Text = "Dolar";
            // 
            // lblDolarA
            // 
            lblDolarA.AutoSize = true;
            lblDolarA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolarA.Location = new Point(395, 58);
            lblDolarA.Name = "lblDolarA";
            lblDolarA.Size = new Size(37, 15);
            lblDolarA.TabIndex = 7;
            lblDolarA.Text = "Dolar";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso.Location = new Point(24, 208);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(33, 15);
            lblPeso.TabIndex = 8;
            lblPeso.Text = "Peso";
            // 
            // lblPesoA
            // 
            lblPesoA.AutoSize = true;
            lblPesoA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoA.Location = new Point(650, 58);
            lblPesoA.Name = "lblPesoA";
            lblPesoA.Size = new Size(33, 15);
            lblPesoA.TabIndex = 9;
            lblPesoA.Text = "Peso";
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(76, 85);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(108, 23);
            txtDolar.TabIndex = 10;
            txtDolar.Leave += txtDolar_Leave;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(76, 144);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(108, 23);
            txtEuro.TabIndex = 11;
            txtEuro.Leave += txtEuro_Leave;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(77, 205);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(108, 23);
            txtPeso.TabIndex = 12;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new Point(359, 85);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.ReadOnly = true;
            txtDolarADolar.Size = new Size(108, 23);
            txtDolarADolar.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new Point(359, 144);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.ReadOnly = true;
            txtEuroADolar.Size = new Size(108, 23);
            txtEuroADolar.TabIndex = 14;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Enabled = false;
            txtPesoADolar.Location = new Point(359, 204);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.ReadOnly = true;
            txtPesoADolar.Size = new Size(108, 23);
            txtPesoADolar.TabIndex = 15;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new Point(485, 85);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.ReadOnly = true;
            txtDolarAEuro.Size = new Size(108, 23);
            txtDolarAEuro.TabIndex = 16;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new Point(485, 144);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.ReadOnly = true;
            txtEuroAEuro.Size = new Size(108, 23);
            txtEuroAEuro.TabIndex = 17;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Enabled = false;
            txtPesoAEuro.Location = new Point(485, 204);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.ReadOnly = true;
            txtPesoAEuro.Size = new Size(108, 23);
            txtPesoAEuro.TabIndex = 18;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Enabled = false;
            txtPesoAPeso.Location = new Point(616, 204);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.ReadOnly = true;
            txtPesoAPeso.Size = new Size(108, 23);
            txtPesoAPeso.TabIndex = 21;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new Point(616, 144);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.ReadOnly = true;
            txtEuroAPeso.Size = new Size(108, 23);
            txtEuroAPeso.TabIndex = 20;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new Point(616, 85);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.ReadOnly = true;
            txtDolarAPeso.Size = new Size(108, 23);
            txtDolarAPeso.TabIndex = 19;
            // 
            // txtCotizacionDolar
            // 
            txtCotizacionDolar.Enabled = false;
            txtCotizacionDolar.Location = new Point(359, 22);
            txtCotizacionDolar.Name = "txtCotizacionDolar";
            txtCotizacionDolar.Size = new Size(108, 23);
            txtCotizacionDolar.TabIndex = 22;
            txtCotizacionDolar.Text = "1";
            // 
            // txtCotizacionEuro
            // 
            txtCotizacionEuro.Location = new Point(485, 22);
            txtCotizacionEuro.Name = "txtCotizacionEuro";
            txtCotizacionEuro.Size = new Size(108, 23);
            txtCotizacionEuro.TabIndex = 23;
            txtCotizacionEuro.Leave += txtCotizacionEuro_Leave;
            // 
            // txtCotizacionPeso
            // 
            txtCotizacionPeso.Location = new Point(616, 22);
            txtCotizacionPeso.Name = "txtCotizacionPeso";
            txtCotizacionPeso.Size = new Size(108, 23);
            txtCotizacionPeso.TabIndex = 24;
            txtCotizacionPeso.Leave += txtCotizacionPeso_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 24);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 25;
            label1.Text = "Cotizacion";
            // 
            // FrmMonedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(742, 249);
            Controls.Add(label1);
            Controls.Add(txtCotizacionPeso);
            Controls.Add(txtCotizacionEuro);
            Controls.Add(txtCotizacionDolar);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtPeso);
            Controls.Add(txtEuro);
            Controls.Add(txtDolar);
            Controls.Add(lblPesoA);
            Controls.Add(lblPeso);
            Controls.Add(lblDolarA);
            Controls.Add(lblDolar);
            Controls.Add(lblEuroA);
            Controls.Add(lblEuro);
            Controls.Add(btnLockCotizacion);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertEuro);
            Controls.Add(btnConvertDolar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmMonedas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertDolar;
        private Button btnConvertEuro;
        private Button btnConvertPeso;
        private Button btnLockCotizacion;
        private Label lblEuro;
        private Label lblEuroA;
        private Label lblDolar;
        private Label lblDolarA;
        private Label lblPeso;
        private Label lblPesoA;
        private TextBox txtDolar;
        private TextBox txtEuro;
        private TextBox txtPeso;
        private TextBox txtDolarADolar;
        private TextBox txtEuroADolar;
        private TextBox txtPesoADolar;
        private TextBox txtDolarAEuro;
        private TextBox txtEuroAEuro;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoAPeso;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtCotizacionDolar;
        private TextBox txtCotizacionEuro;
        private TextBox txtCotizacionPeso;
        private Label label1;
        private ImageList imageList1;
    }
}