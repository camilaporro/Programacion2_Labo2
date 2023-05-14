namespace HolaWindowsFrm
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            btnSaludar = new Button();
            comboBoxMaterias = new ComboBox();
            lblMateria = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(235, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(163, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(235, 43);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(75, 21);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(25, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // btnSaludar
            // 
            btnSaludar.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnSaludar.Location = new Point(254, 177);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(144, 30);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(25, 136);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(373, 23);
            comboBoxMaterias.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(25, 112);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(133, 21);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "Materia favorita";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 219);
            Controls.Add(lblMateria);
            Controls.Add(comboBoxMaterias);
            Controls.Add(btnSaludar);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hola, Windows Form!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnSaludar;
        private ComboBox comboBoxMaterias;
        private Label lblMateria;
    }
}