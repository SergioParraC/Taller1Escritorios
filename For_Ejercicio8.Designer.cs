namespace Taller
{
    partial class For_Ejercicio8
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
            buttonSalir = new Button();
            buttonNuevo = new Button();
            buttonCalcular = new Button();
            label3 = new Label();
            textBoxLadoC = new TextBox();
            textBoxLadoB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxLadoA = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            labelRespuesta = new Label();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(152, 189);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(41, 25);
            buttonSalir.TabIndex = 34;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(90, 189);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(52, 25);
            buttonNuevo.TabIndex = 33;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(17, 189);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(63, 25);
            buttonCalcular.TabIndex = 32;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(27, 158);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 31;
            label3.Text = "El área es de:";
            // 
            // textBoxLadoC
            // 
            textBoxLadoC.Location = new Point(112, 116);
            textBoxLadoC.Margin = new Padding(3, 2, 3, 2);
            textBoxLadoC.Name = "textBoxLadoC";
            textBoxLadoC.Size = new Size(67, 23);
            textBoxLadoC.TabIndex = 30;
            // 
            // textBoxLadoB
            // 
            textBoxLadoB.Location = new Point(112, 85);
            textBoxLadoB.Margin = new Padding(3, 2, 3, 2);
            textBoxLadoB.Name = "textBoxLadoB";
            textBoxLadoB.Size = new Size(67, 23);
            textBoxLadoB.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(16, 119);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 28;
            label2.Text = "Ingrese lado C:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 87);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 27;
            label1.Text = "Ingrese lado B:";
            // 
            // textBoxLadoA
            // 
            textBoxLadoA.Location = new Point(112, 54);
            textBoxLadoA.Margin = new Padding(3, 2, 3, 2);
            textBoxLadoA.Name = "textBoxLadoA";
            textBoxLadoA.Size = new Size(67, 23);
            textBoxLadoA.TabIndex = 26;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(16, 57);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(85, 15);
            labelRCorrectas.TabIndex = 25;
            labelRCorrectas.Text = "Ingrese lado A:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(18, 11);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 24;
            labelTitulo.Text = "Solución ejercicio 8";
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.BackColor = Color.Yellow;
            labelRespuesta.ForeColor = SystemColors.ActiveCaptionText;
            labelRespuesta.Location = new Point(112, 158);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(0, 15);
            labelRespuesta.TabIndex = 45;
            // 
            // For_Ejercicio8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(204, 225);
            Controls.Add(labelRespuesta);
            Controls.Add(buttonSalir);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonCalcular);
            Controls.Add(label3);
            Controls.Add(textBoxLadoC);
            Controls.Add(textBoxLadoB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLadoA);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio8";
            Text = "For_Ejercicio8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Button buttonNuevo;
        private Button buttonCalcular;
        private Label label3;
        private TextBox textBoxLadoC;
        private TextBox textBoxLadoB;
        private Label label2;
        private Label label1;
        private TextBox textBoxLadoA;
        private Label labelRCorrectas;
        private Label labelTitulo;
        private Label labelRespuesta;
    }
}