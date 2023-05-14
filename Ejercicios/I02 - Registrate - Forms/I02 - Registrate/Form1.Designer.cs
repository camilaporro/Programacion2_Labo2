

namespace I02___Registrate
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
            gbUsuario = new GroupBox();
            numericEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            gbGenero = new GroupBox();
            rbNobinario = new RadioButton();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            gbCursos = new GroupBox();
            cbJavaScript = new CheckBox();
            cbCMasMas = new CheckBox();
            cbCSharp = new CheckBox();
            btIngresar = new Button();
            lblPais = new Label();
            listBoxPaises = new ListBox();
            gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).BeginInit();
            gbGenero.SuspendLayout();
            gbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gbUsuario
            // 
            gbUsuario.Controls.Add(numericEdad);
            gbUsuario.Controls.Add(txtDireccion);
            gbUsuario.Controls.Add(txtNombre);
            gbUsuario.Controls.Add(lblEdad);
            gbUsuario.Controls.Add(lblDireccion);
            gbUsuario.Controls.Add(lblNombre);
            gbUsuario.Location = new Point(34, 39);
            gbUsuario.Name = "gbUsuario";
            gbUsuario.Size = new Size(241, 143);
            gbUsuario.TabIndex = 0;
            gbUsuario.TabStop = false;
            gbUsuario.Text = "Detalles del usuario";
            // 
            // numericEdad
            // 
            numericEdad.BorderStyle = BorderStyle.FixedSingle;
            numericEdad.Location = new Point(76, 108);
            numericEdad.Name = "numericEdad";
            numericEdad.Size = new Size(145, 23);
            numericEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(76, 75);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(145, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 114);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 78);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNobinario);
            gbGenero.Controls.Add(rbMasculino);
            gbGenero.Controls.Add(rbFemenino);
            gbGenero.Location = new Point(339, 41);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(129, 105);
            gbGenero.TabIndex = 1;
            gbGenero.TabStop = false;
            gbGenero.Text = "Genero";
            gbGenero.Leave += gbGenero_Leave;
            // 
            // rbNobinario
            // 
            rbNobinario.AutoSize = true;
            rbNobinario.Location = new Point(18, 75);
            rbNobinario.Name = "rbNobinario";
            rbNobinario.Size = new Size(81, 19);
            rbNobinario.TabIndex = 2;
            rbNobinario.TabStop = true;
            rbNobinario.Text = "No binario";
            rbNobinario.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(18, 48);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 1;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(18, 23);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 0;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(cbJavaScript);
            gbCursos.Controls.Add(cbCMasMas);
            gbCursos.Controls.Add(cbCSharp);
            gbCursos.Location = new Point(339, 168);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new Size(129, 100);
            gbCursos.TabIndex = 2;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            gbCursos.Leave += gbCursos_Leave;
            // 
            // cbJavaScript
            // 
            cbJavaScript.AutoSize = true;
            cbJavaScript.Location = new Point(18, 71);
            cbJavaScript.Name = "cbJavaScript";
            cbJavaScript.Size = new Size(78, 19);
            cbJavaScript.TabIndex = 5;
            cbJavaScript.Text = "JavaScript";
            cbJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbCMasMas
            // 
            cbCMasMas.AutoSize = true;
            cbCMasMas.Location = new Point(18, 46);
            cbCMasMas.Name = "cbCMasMas";
            cbCMasMas.Size = new Size(50, 19);
            cbCMasMas.TabIndex = 4;
            cbCMasMas.Text = "C++";
            cbCMasMas.UseVisualStyleBackColor = true;
            // 
            // cbCSharp
            // 
            cbCSharp.AutoSize = true;
            cbCSharp.Location = new Point(18, 21);
            cbCSharp.Name = "cbCSharp";
            cbCSharp.Size = new Size(41, 19);
            cbCSharp.TabIndex = 3;
            cbCSharp.Text = "C#";
            cbCSharp.UseVisualStyleBackColor = true;
            // 
            // btIngresar
            // 
            btIngresar.Location = new Point(339, 286);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(129, 32);
            btIngresar.TabIndex = 3;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            btIngresar.Click += btIngresar_Click;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(40, 214);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 6;
            lblPais.Text = "Pais";
            // 
            // listBoxPaises
            // 
            listBoxPaises.FormattingEnabled = true;
            listBoxPaises.ItemHeight = 15;
            listBoxPaises.Location = new Point(40, 239);
            listBoxPaises.Name = "listBoxPaises";
            listBoxPaises.Size = new Size(235, 79);
            listBoxPaises.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 334);
            Controls.Add(listBoxPaises);
            Controls.Add(lblPais);
            Controls.Add(btIngresar);
            Controls.Add(gbCursos);
            Controls.Add(gbGenero);
            Controls.Add(gbUsuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresante";
            Load += Form1_Load;
            gbUsuario.ResumeLayout(false);
            gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEdad).EndInit();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCursos.ResumeLayout(false);
            gbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbUsuario;
        private NumericUpDown numericEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblNombre;
        private GroupBox gbGenero;
        private RadioButton rbNobinario;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private GroupBox gbCursos;
        private CheckBox cbJavaScript;
        private CheckBox cbCMasMas;
        private CheckBox cbCSharp;
        private Button btIngresar;
        private Label lblPais;
        private ListBox listBoxPaises;
    }
}