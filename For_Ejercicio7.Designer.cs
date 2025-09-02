namespace Taller
{
    partial class For_Ejercicio7
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
            labelRespuesta = new Label();
            buttonSalir = new Button();
            buttonNuevo = new Button();
            buttonCalcular = new Button();
            labelResultado = new Label();
            textBoxTarifa = new TextBox();
            labelTariga = new Label();
            textBoxHoras = new TextBox();
            labelHoras = new Label();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.BackColor = Color.Yellow;
            labelRespuesta.ForeColor = SystemColors.ActiveCaptionText;
            labelRespuesta.Location = new Point(191, 116);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(0, 15);
            labelRespuesta.TabIndex = 44;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(185, 143);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(66, 25);
            buttonSalir.TabIndex = 43;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(104, 143);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(54, 25);
            buttonNuevo.TabIndex = 42;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(13, 143);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(62, 25);
            buttonCalcular.TabIndex = 41;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.ForeColor = SystemColors.Control;
            labelResultado.Location = new Point(46, 116);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(124, 15);
            labelResultado.TabIndex = 40;
            labelResultado.Text = "El puntaje final fue de:";
            // 
            // textBoxTarifa
            // 
            textBoxTarifa.Location = new Point(187, 82);
            textBoxTarifa.Margin = new Padding(3, 2, 3, 2);
            textBoxTarifa.Name = "textBoxTarifa";
            textBoxTarifa.Size = new Size(67, 23);
            textBoxTarifa.TabIndex = 39;
            // 
            // labelTariga
            // 
            labelTariga.AutoSize = true;
            labelTariga.ForeColor = SystemColors.Control;
            labelTariga.Location = new Point(71, 85);
            labelTariga.Name = "labelTariga";
            labelTariga.Size = new Size(94, 15);
            labelTariga.TabIndex = 38;
            labelTariga.Text = "Tarifas por horas";
            // 
            // textBoxHoras
            // 
            textBoxHoras.Location = new Point(187, 51);
            textBoxHoras.Margin = new Padding(3, 2, 3, 2);
            textBoxHoras.Name = "textBoxHoras";
            textBoxHoras.Size = new Size(67, 23);
            textBoxHoras.TabIndex = 37;
            // 
            // labelHoras
            // 
            labelHoras.AutoSize = true;
            labelHoras.ForeColor = SystemColors.Control;
            labelHoras.Location = new Point(5, 55);
            labelHoras.Name = "labelHoras";
            labelHoras.Size = new Size(160, 15);
            labelHoras.TabIndex = 36;
            labelHoras.Text = "N° horas laboradas en el mes";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(47, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 45;
            labelTitulo.Text = "Solución ejercicio 7";
            // 
            // For_Ejercicio7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(279, 182);
            Controls.Add(labelTitulo);
            Controls.Add(labelRespuesta);
            Controls.Add(buttonSalir);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(textBoxTarifa);
            Controls.Add(labelTariga);
            Controls.Add(textBoxHoras);
            Controls.Add(labelHoras);
            Name = "For_Ejercicio7";
            Text = "For_Ejercicio7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRespuesta;
        private Button buttonSalir;
        private Button buttonNuevo;
        private Button buttonCalcular;
        private Label labelResultado;
        private TextBox textBoxTarifa;
        private Label labelTariga;
        private TextBox textBoxHoras;
        private Label labelHoras;
        private Label labelTitulo;
    }
}