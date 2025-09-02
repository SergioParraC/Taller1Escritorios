namespace Taller
{
    partial class For_Ejercicio16
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
            labelRespuesta = new Label();
            textBoxInput = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Yellow;
            labelResultado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultado.Location = new Point(208, 90);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 53;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(12, 90);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(178, 15);
            labelRespuesta.TabIndex = 52;
            labelRespuesta.Text = "Equibalente en número romano:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(205, 54);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(67, 23);
            textBoxInput.TabIndex = 51;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(49, 57);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(141, 15);
            labelRCorrectas.TabIndex = 50;
            labelRCorrectas.Text = "Ingrese un número (0-10)";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(49, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(192, 28);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "Solución ejercicio 16";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(103, 118);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 59;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // For_Ejercicio16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(291, 178);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(labelRespuesta);
            Controls.Add(textBoxInput);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio16";
            Text = "For_Ejercicio16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultado;
        private Label labelRespuesta;
        private TextBox textBoxInput;
        private Label labelRCorrectas;
        private Label labelTitulo;
        private Button buttonCalcular;
    }
}