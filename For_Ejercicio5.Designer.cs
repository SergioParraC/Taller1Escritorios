namespace Taller
{
    partial class For_Ejercicio5
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
            textBoxCorrectas = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxIncorrectas = new TextBox();
            textBoxBlanco = new TextBox();
            label3 = new Label();
            labelRespuesta = new Label();
            buttonCalcular = new Button();
            buttonNuevo = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // textBoxCorrectas
            // 
            textBoxCorrectas.Location = new Point(245, 54);
            textBoxCorrectas.Margin = new Padding(3, 2, 3, 2);
            textBoxCorrectas.Name = "textBoxCorrectas";
            textBoxCorrectas.Size = new Size(67, 23);
            textBoxCorrectas.TabIndex = 14;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(22, 57);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(202, 15);
            labelRCorrectas.TabIndex = 13;
            labelRCorrectas.Text = "Ingrese el N° de respuestas correctas:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(87, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 12;
            labelTitulo.Text = "Solución ejercicio 5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 15;
            label1.Text = "Ingrese el N° de respuestas incorrectas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 118);
            label2.Name = "label2";
            label2.Size = new Size(206, 15);
            label2.TabIndex = 16;
            label2.Text = "Ingrese el N° de respuestas en blanco:";
            // 
            // textBoxIncorrectas
            // 
            textBoxIncorrectas.Location = new Point(245, 85);
            textBoxIncorrectas.Margin = new Padding(3, 2, 3, 2);
            textBoxIncorrectas.Name = "textBoxIncorrectas";
            textBoxIncorrectas.Size = new Size(67, 23);
            textBoxIncorrectas.TabIndex = 17;
            // 
            // textBoxBlanco
            // 
            textBoxBlanco.Location = new Point(245, 116);
            textBoxBlanco.Margin = new Padding(3, 2, 3, 2);
            textBoxBlanco.Name = "textBoxBlanco";
            textBoxBlanco.Size = new Size(67, 23);
            textBoxBlanco.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(100, 164);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 19;
            label3.Text = "El puntaje final fue de:";
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.BackColor = Color.Yellow;
            labelRespuesta.ForeColor = SystemColors.ActiveCaptionText;
            labelRespuesta.Location = new Point(245, 164);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(0, 15);
            labelRespuesta.TabIndex = 20;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(12, 189);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 21;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(122, 189);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(87, 25);
            buttonNuevo.TabIndex = 22;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(225, 189);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(87, 25);
            buttonSalir.TabIndex = 23;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // For_Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(331, 234);
            Controls.Add(buttonSalir);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonCalcular);
            Controls.Add(labelRespuesta);
            Controls.Add(label3);
            Controls.Add(textBoxBlanco);
            Controls.Add(textBoxIncorrectas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCorrectas);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio5";
            Text = "For_Ejercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCorrectas;
        private Label labelRCorrectas;
        private Label labelTitulo;
        private Label label1;
        private Label label2;
        private TextBox textBoxIncorrectas;
        private TextBox textBoxBlanco;
        private Label label3;
        private Label labelRespuesta;
        private Button buttonCalcular;
        private Button buttonNuevo;
        private Button buttonSalir;
    }
}