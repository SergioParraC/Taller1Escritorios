namespace Taller
{
    partial class For_Ejercicio17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(For_Ejercicio17));
            labelResultado = new Label();
            labelOpcion = new Label();
            textBoxOpc = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            labelMonto = new Label();
            textBoxMonto = new TextBox();
            labelRespuesta = new Label();
            textBoxRespuesta = new TextBox();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Yellow;
            labelResultado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultado.Location = new Point(259, 186);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 53;
            // 
            // labelOpcion
            // 
            labelOpcion.AutoSize = true;
            labelOpcion.ForeColor = SystemColors.Control;
            labelOpcion.Location = new Point(62, 121);
            labelOpcion.Name = "labelOpcion";
            labelOpcion.Size = new Size(120, 15);
            labelOpcion.TabIndex = 52;
            labelOpcion.Text = "Opción seleccionada:";
            // 
            // textBoxOpc
            // 
            textBoxOpc.Location = new Point(193, 118);
            textBoxOpc.Margin = new Padding(3, 2, 3, 2);
            textBoxOpc.Name = "textBoxOpc";
            textBoxOpc.ReadOnly = true;
            textBoxOpc.Size = new Size(67, 23);
            textBoxOpc.TabIndex = 51;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(12, 47);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(327, 60);
            labelRCorrectas.TabIndex = 50;
            labelRCorrectas.Text = resources.GetString("labelRCorrectas.Text");
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(80, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(192, 28);
            labelTitulo.TabIndex = 49;
            labelTitulo.Text = "Solución ejercicio 17";
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.ForeColor = SystemColors.Control;
            labelMonto.Location = new Point(44, 158);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(140, 15);
            labelMonto.TabIndex = 55;
            labelMonto.Text = "Ingrese monto de ventas:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(193, 155);
            textBoxMonto.Margin = new Padding(3, 2, 3, 2);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(67, 23);
            textBoxMonto.TabIndex = 54;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(44, 189);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(128, 30);
            labelRespuesta.TabIndex = 57;
            labelRespuesta.Text = "El total de bonificación\nen S/ es de:";
            // 
            // textBoxRespuesta
            // 
            textBoxRespuesta.Location = new Point(193, 193);
            textBoxRespuesta.Margin = new Padding(3, 2, 3, 2);
            textBoxRespuesta.Name = "textBoxRespuesta";
            textBoxRespuesta.ReadOnly = true;
            textBoxRespuesta.Size = new Size(67, 23);
            textBoxRespuesta.TabIndex = 56;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(119, 245);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 58;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // For_Ejercicio178
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(355, 292);
            Controls.Add(buttonCalcular);
            Controls.Add(labelRespuesta);
            Controls.Add(textBoxRespuesta);
            Controls.Add(labelMonto);
            Controls.Add(textBoxMonto);
            Controls.Add(labelResultado);
            Controls.Add(labelOpcion);
            Controls.Add(textBoxOpc);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio178";
            Text = "For_Ejercicio178";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultado;
        private Label labelOpcion;
        private TextBox textBoxOpc;
        private Label labelRCorrectas;
        private Label labelTitulo;
        private Label labelMonto;
        private TextBox textBoxMonto;
        private Label labelRespuesta;
        private TextBox textBoxRespuesta;
        private Button buttonCalcular;
    }
}