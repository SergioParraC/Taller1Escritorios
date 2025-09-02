namespace Taller
{
    partial class For_Ejercicio12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelResultado = new Label();
            buttonCalcular = new Button();
            labelRespuesta = new Label();
            textBoxHer2 = new TextBox();
            label1 = new Label();
            textBoxHer1 = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.FromArgb(255, 128, 0);
            labelResultado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultado.Location = new Point(184, 127);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 56;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(82, 157);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 55;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(23, 127);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(146, 15);
            labelRespuesta.TabIndex = 54;
            labelRespuesta.Text = "Diferencia entre hermanos";
            // 
            // textBoxHer2
            // 
            textBoxHer2.Location = new Point(184, 85);
            textBoxHer2.Margin = new Padding(3, 2, 3, 2);
            textBoxHer2.Name = "textBoxHer2";
            textBoxHer2.Size = new Size(67, 23);
            textBoxHer2.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 85);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 52;
            label1.Text = "Edad del Segundo hermano";
            // 
            // textBoxHer1
            // 
            textBoxHer1.Location = new Point(184, 54);
            textBoxHer1.Margin = new Padding(3, 2, 3, 2);
            textBoxHer1.Name = "textBoxHer1";
            textBoxHer1.Size = new Size(67, 23);
            textBoxHer1.TabIndex = 51;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(28, 57);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(141, 15);
            labelRCorrectas.TabIndex = 50;
            labelRCorrectas.Text = "Edad del Primer hermano";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(68, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(192, 28);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "Solución ejercicio 12";
            // 
            // For_Ejercicio12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(311, 198);
            Controls.Add(labelResultado);
            Controls.Add(buttonCalcular);
            Controls.Add(labelRespuesta);
            Controls.Add(textBoxHer2);
            Controls.Add(label1);
            Controls.Add(textBoxHer1);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio12";
            Text = "For_Ejercicio12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultado;
        private Button buttonCalcular;
        private Label labelRespuesta;
        private TextBox textBoxHer2;
        private Label label1;
        private TextBox textBoxHer1;
        private Label labelRCorrectas;
        private Label labelTitulo;
    }
}