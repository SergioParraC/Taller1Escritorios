namespace Taller
{
    partial class For_Ejercicio6
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
            textBoxPerdidos = new TextBox();
            textBoxEmpatados = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxGanados = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            labelRespuesta = new Label();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(225, 189);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(87, 25);
            buttonSalir.TabIndex = 34;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(122, 189);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(87, 25);
            buttonNuevo.TabIndex = 33;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(12, 189);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 32;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(100, 164);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 31;
            label3.Text = "El puntaje final fue de:";
            // 
            // textBoxPerdidos
            // 
            textBoxPerdidos.Location = new Point(245, 116);
            textBoxPerdidos.Margin = new Padding(3, 2, 3, 2);
            textBoxPerdidos.Name = "textBoxPerdidos";
            textBoxPerdidos.Size = new Size(67, 23);
            textBoxPerdidos.TabIndex = 30;
            // 
            // textBoxEmpatados
            // 
            textBoxEmpatados.Location = new Point(245, 85);
            textBoxEmpatados.Margin = new Padding(3, 2, 3, 2);
            textBoxEmpatados.Name = "textBoxEmpatados";
            textBoxEmpatados.Size = new Size(67, 23);
            textBoxEmpatados.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(59, 119);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 28;
            label2.Text = "Número de Partidos  perdidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(46, 85);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 27;
            label1.Text = "Número de Partidos  empatados";
            // 
            // textBoxGanados
            // 
            textBoxGanados.Location = new Point(245, 54);
            textBoxGanados.Margin = new Padding(3, 2, 3, 2);
            textBoxGanados.Name = "textBoxGanados";
            textBoxGanados.Size = new Size(67, 23);
            textBoxGanados.TabIndex = 26;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(63, 58);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(161, 15);
            labelRCorrectas.TabIndex = 25;
            labelRCorrectas.Text = "Número de Partidos ganados";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(87, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 24;
            labelTitulo.Text = "Solución ejercicio 6";
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.BackColor = Color.Yellow;
            labelRespuesta.ForeColor = SystemColors.ActiveCaptionText;
            labelRespuesta.Location = new Point(245, 164);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(0, 15);
            labelRespuesta.TabIndex = 35;
            // 
            // For_Ejercicio6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(338, 230);
            Controls.Add(labelRespuesta);
            Controls.Add(buttonSalir);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonCalcular);
            Controls.Add(label3);
            Controls.Add(textBoxPerdidos);
            Controls.Add(textBoxEmpatados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxGanados);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio6";
            Text = "For_Ejercicio6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Button buttonNuevo;
        private Button buttonCalcular;
        private Label label3;
        private TextBox textBoxPerdidos;
        private TextBox textBoxEmpatados;
        private Label label2;
        private Label label1;
        private TextBox textBoxGanados;
        private Label labelRCorrectas;
        private Label labelTitulo;
        private Label labelRespuesta;
    }
}