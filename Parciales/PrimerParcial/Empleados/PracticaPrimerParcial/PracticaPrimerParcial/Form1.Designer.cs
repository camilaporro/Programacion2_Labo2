namespace PracticaPrimerParcial
{
    partial class Form1
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
            lblNombre = new Label();
            lblLegajo = new Label();
            lblTipo = new Label();
            lblHoraIngreso = new Label();
            lblGrupo = new Label();
            btnIngresoEmp = new Button();
            btnRetiroEmp = new Button();
            btnImpNomina = new Button();
            txtNombre = new TextBox();
            txtLegajo = new TextBox();
            lstEmpleados = new ListBox();
            cmbTipo = new ComboBox();
            dtpHoraIngreso = new DateTimePicker();
            cmbGrupo = new ComboBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(156, 24);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 1;
            lblLegajo.Text = "Legajo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(290, 24);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Location = new Point(461, 24);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(75, 15);
            lblHoraIngreso.TabIndex = 3;
            lblHoraIngreso.Text = "Hora ingreso";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(27, 91);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(66, 15);
            lblGrupo.TabIndex = 4;
            lblGrupo.Text = "Grupo RAC";
            // 
            // btnIngresoEmp
            // 
            btnIngresoEmp.Location = new Point(27, 185);
            btnIngresoEmp.Name = "btnIngresoEmp";
            btnIngresoEmp.Size = new Size(75, 23);
            btnIngresoEmp.TabIndex = 5;
            btnIngresoEmp.Text = "Ingreso";
            btnIngresoEmp.UseVisualStyleBackColor = true;
            // 
            // btnRetiroEmp
            // 
            btnRetiroEmp.Location = new Point(169, 186);
            btnRetiroEmp.Name = "btnRetiroEmp";
            btnRetiroEmp.Size = new Size(75, 23);
            btnRetiroEmp.TabIndex = 6;
            btnRetiroEmp.Text = "Retiro";
            btnRetiroEmp.UseVisualStyleBackColor = true;
            // 
            // btnImpNomina
            // 
            btnImpNomina.Location = new Point(488, 332);
            btnImpNomina.Name = "btnImpNomina";
            btnImpNomina.Size = new Size(197, 91);
            btnImpNomina.TabIndex = 7;
            btnImpNomina.Text = "Imprimir nomina";
            btnImpNomina.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(156, 49);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(105, 23);
            txtLegajo.TabIndex = 9;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(25, 224);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(431, 199);
            lstEmpleados.TabIndex = 10;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(290, 49);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 11;
            // 
            // dtpHoraIngreso
            // 
            dtpHoraIngreso.Location = new Point(461, 49);
            dtpHoraIngreso.Name = "dtpHoraIngreso";
            dtpHoraIngreso.Size = new Size(224, 23);
            dtpHoraIngreso.TabIndex = 12;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(28, 109);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(88, 23);
            cmbGrupo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(cmbGrupo);
            Controls.Add(dtpHoraIngreso);
            Controls.Add(cmbTipo);
            Controls.Add(lstEmpleados);
            Controls.Add(txtLegajo);
            Controls.Add(txtNombre);
            Controls.Add(btnImpNomina);
            Controls.Add(btnRetiroEmp);
            Controls.Add(btnIngresoEmp);
            Controls.Add(lblGrupo);
            Controls.Add(lblHoraIngreso);
            Controls.Add(lblTipo);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Camila Porro - 2C";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblLegajo;
        private Label lblTipo;
        private Label lblHoraIngreso;
        private Label lblGrupo;
        private Button btnIngresoEmp;
        private Button btnRetiroEmp;
        private Button btnImpNomina;
        private TextBox txtNombre;
        private TextBox txtLegajo;
        private ListBox lstEmpleados;
        private ComboBox cmbTipo;
        private DateTimePicker dtpHoraIngreso;
        private ComboBox cmbGrupo;
        private BindingSource bindingSource1;
    }
}