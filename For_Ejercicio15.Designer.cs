namespace Taller
{
    partial class For_Ejercicio15
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
            textBoxLado1 = new TextBox();
            labelLado1 = new Label();
            labelTitulo = new Label();
            textBoxLado2 = new TextBox();
            labelLado2 = new Label();
            textBoxLado3 = new TextBox();
            labelLado3 = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Yellow;
            labelResultado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultado.Location = new Point(134, 182);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 53;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(17, 182);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(87, 15);
            labelRespuesta.TabIndex = 52;
            labelRespuesta.Text = "El triángulo es: ";
            // 
            // textBoxLado1
            // 
            textBoxLado1.Location = new Point(134, 54);
            textBoxLado1.Margin = new Padding(3, 2, 3, 2);
            textBoxLado1.Name = "textBoxLado1";
            textBoxLado1.Size = new Size(67, 23);
            textBoxLado1.TabIndex = 51;
            // 
            // labelLado1
            // 
            labelLado1.AutoSize = true;
            labelLado1.ForeColor = SystemColors.Control;
            labelLado1.Location = new Point(39, 57);
            labelLado1.Name = "labelLado1";
            labelLado1.Size = new Size(83, 15);
            labelLado1.TabIndex = 50;
            labelLado1.Text = "Ingrese lado 1:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(25, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(203, 28);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "5Solución ejercicio 15";
            // 
            // textBoxLado2
            // 
            textBoxLado2.Location = new Point(134, 94);
            textBoxLado2.Margin = new Padding(3, 2, 3, 2);
            textBoxLado2.Name = "textBoxLado2";
            textBoxLado2.Size = new Size(67, 23);
            textBoxLado2.TabIndex = 55;
            // 
            // labelLado2
            // 
            labelLado2.AutoSize = true;
            labelLado2.ForeColor = SystemColors.Control;
            labelLado2.Location = new Point(39, 97);
            labelLado2.Name = "labelLado2";
            labelLado2.Size = new Size(83, 15);
            labelLado2.TabIndex = 54;
            labelLado2.Text = "Ingrese lado 2:";
            // 
            // textBoxLado3
            // 
            textBoxLado3.Location = new Point(134, 133);
            textBoxLado3.Margin = new Padding(3, 2, 3, 2);
            textBoxLado3.Name = "textBoxLado3";
            textBoxLado3.Size = new Size(67, 23);
            textBoxLado3.TabIndex = 57;
            // 
            // labelLado3
            // 
            labelLado3.AutoSize = true;
            labelLado3.ForeColor = SystemColors.Control;
            labelLado3.Location = new Point(39, 136);
            labelLado3.Name = "labelLado3";
            labelLado3.Size = new Size(83, 15);
            labelLado3.TabIndex = 56;
            labelLado3.Text = "Ingrese lado 3:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(66, 212);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 58;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // For_Ejercicio15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(249, 257);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxLado3);
            Controls.Add(labelLado3);
            Controls.Add(textBoxLado2);
            Controls.Add(labelLado2);
            Controls.Add(labelResultado);
            Controls.Add(labelRespuesta);
            Controls.Add(textBoxLado1);
            Controls.Add(labelLado1);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio15";
            Text = "For_Ejercicio15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultado;
        private Label labelRespuesta;
        private TextBox textBoxLado1;
        private Label labelLado1;
        private Label labelTitulo;
        private TextBox textBoxLado2;
        private Label labelLado2;
        private TextBox textBoxLado3;
        private Label labelLado3;
        private Button buttonCalcular;
    }
}