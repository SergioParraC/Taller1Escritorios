namespace Taller
{
    partial class For_Ejercicio3
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
            labelVelocidad = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            textBoxVelocidad = new TextBox();
            textBoxTiempo = new TextBox();
            richTextBoxResultado = new RichTextBox();
            buttonCalcular = new Button();
            labelRespuesta = new Label();
            SuspendLayout();
            // 
            // labelVelocidad
            // 
            labelVelocidad.AutoSize = true;
            labelVelocidad.ForeColor = SystemColors.Control;
            labelVelocidad.Location = new Point(45, 56);
            labelVelocidad.Name = "labelVelocidad";
            labelVelocidad.Size = new Size(143, 15);
            labelVelocidad.TabIndex = 6;
            labelVelocidad.Text = "Ingrese la velodicda (m/s)";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(72, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Solución ejercicio 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(60, 80);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 7;
            label1.Text = "Ingrese el tiempo (Seg)";
            // 
            // textBoxVelocidad
            // 
            textBoxVelocidad.Location = new Point(202, 54);
            textBoxVelocidad.Margin = new Padding(3, 2, 3, 2);
            textBoxVelocidad.Name = "textBoxVelocidad";
            textBoxVelocidad.Size = new Size(110, 23);
            textBoxVelocidad.TabIndex = 8;
            // 
            // textBoxTiempo
            // 
            textBoxTiempo.Location = new Point(202, 80);
            textBoxTiempo.Margin = new Padding(3, 2, 3, 2);
            textBoxTiempo.Name = "textBoxTiempo";
            textBoxTiempo.Size = new Size(110, 23);
            textBoxTiempo.TabIndex = 9;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.Location = new Point(202, 107);
            richTextBoxResultado.Margin = new Padding(3, 2, 3, 2);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.ReadOnly = true;
            richTextBoxResultado.Size = new Size(110, 24);
            richTextBoxResultado.TabIndex = 10;
            richTextBoxResultado.Text = "";
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.Black;
            buttonCalcular.ForeColor = Color.Transparent;
            buttonCalcular.Location = new Point(117, 134);
            buttonCalcular.Margin = new Padding(3, 2, 3, 2);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 25);
            buttonCalcular.TabIndex = 11;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(8, 110);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(174, 15);
            labelRespuesta.TabIndex = 12;
            labelRespuesta.Text = "La distancia recorrida  en (m) es";
            // 
            // For_Ejercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(328, 172);
            Controls.Add(labelRespuesta);
            Controls.Add(buttonCalcular);
            Controls.Add(richTextBoxResultado);
            Controls.Add(textBoxTiempo);
            Controls.Add(textBoxVelocidad);
            Controls.Add(label1);
            Controls.Add(labelVelocidad);
            Controls.Add(labelTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "For_Ejercicio3";
            Text = "For_Ejercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVelocidad;
        private Label labelTitulo;
        private Label label1;
        private TextBox textBoxVelocidad;
        private TextBox textBoxTiempo;
        private RichTextBox richTextBoxResultado;
        private Button buttonCalcular;
        private Label labelRespuesta;
    }
}