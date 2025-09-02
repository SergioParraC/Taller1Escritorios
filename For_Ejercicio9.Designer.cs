namespace Taller
{
    partial class For_Ejercicio9
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
            labelResultado = new Label();
            textBoxDiscoDuro = new TextBox();
            labelCapacidad = new Label();
            labelTitulo = new Label();
            labelRespuesta = new Label();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(211, 116);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(41, 25);
            buttonSalir.TabIndex = 41;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(149, 116);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(52, 25);
            buttonNuevo.TabIndex = 40;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(76, 116);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(63, 25);
            buttonCalcular.TabIndex = 39;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.ForeColor = SystemColors.Control;
            labelResultado.Location = new Point(10, 85);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(269, 15);
            labelResultado.TabIndex = 38;
            labelResultado.Text = "La cantidad de Micro Discos para el BackUp es de:";
            // 
            // textBoxDiscoDuro
            // 
            textBoxDiscoDuro.Location = new Point(302, 52);
            textBoxDiscoDuro.Margin = new Padding(3, 2, 3, 2);
            textBoxDiscoDuro.Name = "textBoxDiscoDuro";
            textBoxDiscoDuro.Size = new Size(67, 23);
            textBoxDiscoDuro.TabIndex = 37;
            // 
            // labelCapacidad
            // 
            labelCapacidad.AutoSize = true;
            labelCapacidad.ForeColor = SystemColors.Control;
            labelCapacidad.Location = new Point(50, 52);
            labelCapacidad.Name = "labelCapacidad";
            labelCapacidad.Size = new Size(229, 15);
            labelCapacidad.TabIndex = 36;
            labelCapacidad.Text = "Ingrese la capacidad del disco duro en GB:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(105, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 35;
            labelTitulo.Text = "Solución ejercicio 9";
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.BackColor = Color.Yellow;
            labelRespuesta.ForeColor = SystemColors.ActiveCaptionText;
            labelRespuesta.Location = new Point(302, 85);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(0, 15);
            labelRespuesta.TabIndex = 46;
            // 
            // For_Ejercicio9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(408, 156);
            Controls.Add(labelRespuesta);
            Controls.Add(buttonSalir);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(textBoxDiscoDuro);
            Controls.Add(labelCapacidad);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio9";
            Text = "For_Ejercicio9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Button buttonNuevo;
        private Button buttonCalcular;
        private Label labelResultado;
        private TextBox textBoxDiscoDuro;
        private Label labelCapacidad;
        private Label labelTitulo;
        private Label labelRespuesta;
    }
}