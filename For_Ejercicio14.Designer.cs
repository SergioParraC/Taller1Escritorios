namespace Taller
{
    partial class For_Ejercicio14
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
            textBoxN1 = new TextBox();
            labelN1 = new Label();
            labelTitulo = new Label();
            textBoxN2 = new TextBox();
            labelN2 = new Label();
            textBoxN3 = new TextBox();
            labelN3 = new Label();
            SuspendLayout();
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Yellow;
            labelResultado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultado.Location = new Point(125, 183);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 54;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(54, 223);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 53;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(15, 177);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(87, 30);
            labelRespuesta.TabIndex = 52;
            labelRespuesta.Text = "El mayor de los\n3 números es:";
            // 
            // textBoxN1
            // 
            textBoxN1.Location = new Point(120, 54);
            textBoxN1.Margin = new Padding(3, 2, 3, 2);
            textBoxN1.Name = "textBoxN1";
            textBoxN1.Size = new Size(67, 23);
            textBoxN1.TabIndex = 51;
            // 
            // labelN1
            // 
            labelN1.AutoSize = true;
            labelN1.ForeColor = SystemColors.Control;
            labelN1.Location = new Point(33, 57);
            labelN1.Name = "labelN1";
            labelN1.Size = new Size(66, 15);
            labelN1.TabIndex = 50;
            labelN1.Text = "Ingrese N1:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(21, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(192, 28);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "Solución ejercicio 14";
            // 
            // textBoxN2
            // 
            textBoxN2.Location = new Point(120, 93);
            textBoxN2.Margin = new Padding(3, 2, 3, 2);
            textBoxN2.Name = "textBoxN2";
            textBoxN2.Size = new Size(67, 23);
            textBoxN2.TabIndex = 56;
            // 
            // labelN2
            // 
            labelN2.AutoSize = true;
            labelN2.ForeColor = SystemColors.Control;
            labelN2.Location = new Point(33, 96);
            labelN2.Name = "labelN2";
            labelN2.Size = new Size(66, 15);
            labelN2.TabIndex = 55;
            labelN2.Text = "Ingrese N2:";
            // 
            // textBoxN3
            // 
            textBoxN3.Location = new Point(120, 133);
            textBoxN3.Margin = new Padding(3, 2, 3, 2);
            textBoxN3.Name = "textBoxN3";
            textBoxN3.Size = new Size(67, 23);
            textBoxN3.TabIndex = 58;
            // 
            // labelN3
            // 
            labelN3.AutoSize = true;
            labelN3.ForeColor = SystemColors.Control;
            labelN3.Location = new Point(33, 136);
            labelN3.Name = "labelN3";
            labelN3.Size = new Size(66, 15);
            labelN3.TabIndex = 57;
            labelN3.Text = "Ingrese N3:";
            // 
            // For_Ejercicio14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(219, 290);
            Controls.Add(textBoxN3);
            Controls.Add(labelN3);
            Controls.Add(textBoxN2);
            Controls.Add(labelN2);
            Controls.Add(labelResultado);
            Controls.Add(buttonCalcular);
            Controls.Add(labelRespuesta);
            Controls.Add(textBoxN1);
            Controls.Add(labelN1);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio14";
            Text = "For_Ejercicio14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultado;
        private Button buttonCalcular;
        private Label labelRespuesta;
        private TextBox textBoxN1;
        private Label labelN1;
        private Label labelTitulo;
        private TextBox textBoxN2;
        private Label labelN2;
        private TextBox textBoxN3;
        private Label labelN3;
    }
}