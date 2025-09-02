namespace Taller
{
    partial class For_Ejercicio11
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
            textBoxAgno = new TextBox();
            buttonSalir = new Button();
            buttonNuevo = new Button();
            buttonCalcular = new Button();
            labelRespuesta = new Label();
            textBoxAgnoNacimiento = new TextBox();
            labelRCorrectas = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            textBoxRespuesta = new TextBox();
            SuspendLayout();
            // 
            // textBoxAgno
            // 
            textBoxAgno.BackColor = Color.Cyan;
            textBoxAgno.Location = new Point(171, 90);
            textBoxAgno.Margin = new Padding(3, 2, 3, 2);
            textBoxAgno.Name = "textBoxAgno";
            textBoxAgno.ReadOnly = true;
            textBoxAgno.Size = new Size(67, 23);
            textBoxAgno.TabIndex = 55;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(254, 162);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(87, 25);
            buttonSalir.TabIndex = 54;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(147, 162);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(87, 25);
            buttonNuevo.TabIndex = 53;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(37, 162);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 25);
            buttonCalcular.TabIndex = 52;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.ForeColor = SystemColors.Control;
            labelRespuesta.Location = new Point(99, 128);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(54, 15);
            labelRespuesta.TabIndex = 51;
            labelRespuesta.Text = "Mensaje:";
            // 
            // textBoxAgnoNacimiento
            // 
            textBoxAgnoNacimiento.Location = new Point(171, 51);
            textBoxAgnoNacimiento.Margin = new Padding(3, 2, 3, 2);
            textBoxAgnoNacimiento.Name = "textBoxAgnoNacimiento";
            textBoxAgnoNacimiento.Size = new Size(67, 23);
            textBoxAgnoNacimiento.TabIndex = 50;
            // 
            // labelRCorrectas
            // 
            labelRCorrectas.AutoSize = true;
            labelRCorrectas.ForeColor = SystemColors.Control;
            labelRCorrectas.Location = new Point(11, 54);
            labelRCorrectas.Name = "labelRCorrectas";
            labelRCorrectas.Size = new Size(147, 15);
            labelRCorrectas.TabIndex = 49;
            labelRCorrectas.Text = "Ingrese año de nacimiento";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(100, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(192, 28);
            labelTitulo.TabIndex = 48;
            labelTitulo.Text = "Solución ejercicio 11";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(86, 93);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 56;
            label1.Text = "Año actiual";
            // 
            // textBoxRespuesta
            // 
            textBoxRespuesta.BackColor = Color.FromArgb(255, 255, 128);
            textBoxRespuesta.Location = new Point(171, 125);
            textBoxRespuesta.Margin = new Padding(3, 2, 3, 2);
            textBoxRespuesta.Name = "textBoxRespuesta";
            textBoxRespuesta.ReadOnly = true;
            textBoxRespuesta.Size = new Size(183, 23);
            textBoxRespuesta.TabIndex = 57;
            // 
            // For_Ejercicio11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(390, 210);
            Controls.Add(textBoxRespuesta);
            Controls.Add(label1);
            Controls.Add(textBoxAgno);
            Controls.Add(buttonSalir);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonCalcular);
            Controls.Add(labelRespuesta);
            Controls.Add(textBoxAgnoNacimiento);
            Controls.Add(labelRCorrectas);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio11";
            Text = "For_Ejercicio11";
            Load += For_Ejercicio11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAgno;
        private Button buttonSalir;
        private Button buttonNuevo;
        private Button buttonCalcular;
        private Label labelRespuesta;
        private TextBox textBoxAgnoNacimiento;
        private Label labelRCorrectas;
        private Label labelTitulo;
        private Label label1;
        private TextBox textBoxRespuesta;
    }
}