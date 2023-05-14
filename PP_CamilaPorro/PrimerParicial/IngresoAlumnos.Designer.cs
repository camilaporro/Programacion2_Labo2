namespace PrimerParicial
{
    partial class IngresoAlumnos
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
            lstAlumnosCreados = new ListBox();
            lstAlumnosInscriptosProgramacion = new ListBox();
            gbAlumnos = new GroupBox();
            btnCrearAlumno = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            gbMateria = new GroupBox();
            btnAsignar = new Button();
            cmbMaterias = new ComboBox();
            lblMateria = new Label();
            lblAlumnosCreados = new Label();
            lblProgra = new Label();
            label7 = new Label();
            lblLabo = new Label();
            lstAlumnosInscriptosLaboratorio = new ListBox();
            gbAlumnos.SuspendLayout();
            gbMateria.SuspendLayout();
            SuspendLayout();
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(41, 245);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(169, 169);
            lstAlumnosCreados.TabIndex = 0;
            // 
            // lstAlumnosInscriptosProgramacion
            // 
            lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
            lstAlumnosInscriptosProgramacion.ItemHeight = 15;
            lstAlumnosInscriptosProgramacion.Location = new Point(513, 60);
            lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
            lstAlumnosInscriptosProgramacion.Size = new Size(166, 139);
            lstAlumnosInscriptosProgramacion.TabIndex = 1;
            // 
            // gbAlumnos
            // 
            gbAlumnos.Controls.Add(btnCrearAlumno);
            gbAlumnos.Controls.Add(txtNombre);
            gbAlumnos.Controls.Add(txtApellido);
            gbAlumnos.Controls.Add(txtDni);
            gbAlumnos.Controls.Add(lblNombre);
            gbAlumnos.Controls.Add(lblApellido);
            gbAlumnos.Controls.Add(lblDni);
            gbAlumnos.Location = new Point(41, 36);
            gbAlumnos.Name = "gbAlumnos";
            gbAlumnos.Size = new Size(398, 148);
            gbAlumnos.TabIndex = 2;
            gbAlumnos.TabStop = false;
            gbAlumnos.Text = "Alta alumno";
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.Location = new Point(83, 99);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(239, 34);
            btnCrearAlumno.TabIndex = 6;
            btnCrearAlumno.Text = "Crear alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(278, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 52);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(22, 52);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(278, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(153, 34);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "APELLIDO";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(22, 34);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // gbMateria
            // 
            gbMateria.Controls.Add(btnAsignar);
            gbMateria.Controls.Add(cmbMaterias);
            gbMateria.Controls.Add(lblMateria);
            gbMateria.Location = new Point(240, 227);
            gbMateria.Name = "gbMateria";
            gbMateria.Size = new Size(199, 187);
            gbMateria.TabIndex = 3;
            gbMateria.TabStop = false;
            gbMateria.Text = "Asignar materia";
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(31, 110);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(148, 61);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignar al alumno seleccionado";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(40, 52);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(128, 23);
            cmbMaterias.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(68, 34);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(55, 15);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "MATERIA";
            // 
            // lblAlumnosCreados
            // 
            lblAlumnosCreados.AutoSize = true;
            lblAlumnosCreados.Location = new Point(41, 227);
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            lblAlumnosCreados.Size = new Size(99, 15);
            lblAlumnosCreados.TabIndex = 4;
            lblAlumnosCreados.Text = "Alumnos creados";
            // 
            // lblProgra
            // 
            lblProgra.AutoSize = true;
            lblProgra.Location = new Point(513, 42);
            lblProgra.Name = "lblProgra";
            lblProgra.Size = new Size(96, 15);
            lblProgra.TabIndex = 5;
            lblProgra.Text = "Inscriptos Progra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(628, 248);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // lblLabo
            // 
            lblLabo.AutoSize = true;
            lblLabo.Location = new Point(513, 257);
            lblLabo.Name = "lblLabo";
            lblLabo.Size = new Size(87, 15);
            lblLabo.TabIndex = 8;
            lblLabo.Text = "Inscriptos Labo";
            // 
            // lstAlumnosInscriptosLaboratorio
            // 
            lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
            lstAlumnosInscriptosLaboratorio.ItemHeight = 15;
            lstAlumnosInscriptosLaboratorio.Location = new Point(513, 275);
            lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
            lstAlumnosInscriptosLaboratorio.Size = new Size(166, 139);
            lstAlumnosInscriptosLaboratorio.TabIndex = 7;
            // 
            // IngresoAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(lblLabo);
            Controls.Add(lstAlumnosInscriptosLaboratorio);
            Controls.Add(label7);
            Controls.Add(lblProgra);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(gbMateria);
            Controls.Add(gbAlumnos);
            Controls.Add(lstAlumnosInscriptosProgramacion);
            Controls.Add(lstAlumnosCreados);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IngresoAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion alumnos";
            Load += IngresoAlumnos_Load;
            gbAlumnos.ResumeLayout(false);
            gbAlumnos.PerformLayout();
            gbMateria.ResumeLayout(false);
            gbMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosProgramacion;
        private GroupBox gbAlumnos;
        private Button btnCrearAlumno;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private GroupBox gbMateria;
        private Button btnAsignar;
        private ComboBox cmbMaterias;
        private Label lblMateria;
        private Label lblAlumnosCreados;
        private Label lblProgra;
        private Label label7;
        private Label lblLabo;
        private ListBox lstAlumnosInscriptosLaboratorio;
    }
}