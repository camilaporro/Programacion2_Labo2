namespace View
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
            lblKilometros = new Label();
            lblLitros = new Label();
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            richTextBox1 = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblKilometros.Location = new Point(12, 15);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(107, 28);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLitros.Location = new Point(12, 84);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(60, 28);
            lblLitros.TabIndex = 1;
            lblLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(12, 46);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(181, 23);
            txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(12, 115);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(181, 23);
            txtLitros.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(243, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(199, 157);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.FlatStyle = FlatStyle.Popup;
            btnCalcular.Location = new Point(12, 157);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(181, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 202);
            Controls.Add(btnCalcular);
            Controls.Add(richTextBox1);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            Controls.Add(lblLitros);
            Controls.Add(lblKilometros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometros;
        private Label lblLitros;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private RichTextBox richTextBox1;
        private Button btnCalcular;
    }
}