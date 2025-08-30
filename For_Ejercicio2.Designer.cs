namespace Taller
{
    partial class For_Ejercicio2
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
            buttonLimpiar = new Button();
            textBoxIngreso = new TextBox();
            labelIngreso = new Label();
            label1 = new Label();
            labelResultado = new Label();
            textBoxRespuesta = new TextBox();
            buttonCaF = new Button();
            buttonFsC = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.Black;
            buttonLimpiar.ForeColor = Color.Transparent;
            buttonLimpiar.Location = new Point(30, 303);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(109, 51);
            buttonLimpiar.TabIndex = 3;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxIngreso
            // 
            textBoxIngreso.Location = new Point(186, 55);
            textBoxIngreso.Name = "textBoxIngreso";
            textBoxIngreso.Size = new Size(125, 27);
            textBoxIngreso.TabIndex = 9;
            textBoxIngreso.KeyPress += textBoxIngreso_KeyPress;
            // 
            // labelIngreso
            // 
            labelIngreso.AutoSize = true;
            labelIngreso.ForeColor = SystemColors.Control;
            labelIngreso.Location = new Point(21, 58);
            labelIngreso.Name = "labelIngreso";
            labelIngreso.Size = new Size(159, 20);
            labelIngreso.TabIndex = 8;
            labelIngreso.Text = "Ingrese la temperatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 35);
            label1.TabIndex = 7;
            label1.Text = "Solución ejercicio 2";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.ForeColor = SystemColors.Control;
            labelResultado.Location = new Point(105, 91);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(75, 20);
            labelResultado.TabIndex = 10;
            labelResultado.Text = "Resultado";
            // 
            // textBoxRespuesta
            // 
            textBoxRespuesta.Location = new Point(186, 88);
            textBoxRespuesta.Name = "textBoxRespuesta";
            textBoxRespuesta.ReadOnly = true;
            textBoxRespuesta.Size = new Size(125, 27);
            textBoxRespuesta.TabIndex = 11;
            // 
            // buttonCaF
            // 
            buttonCaF.BackColor = Color.Black;
            buttonCaF.ForeColor = Color.Transparent;
            buttonCaF.Location = new Point(30, 141);
            buttonCaF.Name = "buttonCaF";
            buttonCaF.Size = new Size(109, 36);
            buttonCaF.TabIndex = 12;
            buttonCaF.Text = "C a F";
            buttonCaF.UseVisualStyleBackColor = false;
            buttonCaF.Click += buttonCaF_Click;
            // 
            // buttonFsC
            // 
            buttonFsC.BackColor = Color.Black;
            buttonFsC.ForeColor = Color.Transparent;
            buttonFsC.Location = new Point(176, 141);
            buttonFsC.Name = "buttonFsC";
            buttonFsC.Size = new Size(109, 36);
            buttonFsC.TabIndex = 13;
            buttonFsC.Text = "F a C";
            buttonFsC.UseVisualStyleBackColor = false;
            buttonFsC.Click += buttonFsC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(30, 197);
            label2.Name = "label2";
            label2.Size = new Size(195, 20);
            label2.TabIndex = 14;
            label2.Text = "Presione el botón adecuado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(30, 228);
            label3.Name = "label3";
            label3.Size = new Size(395, 20);
            label3.TabIndex = 15;
            label3.Text = "C a F: Convierte de gados Fahrenheit a grados Centigrados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(30, 266);
            label4.Name = "label4";
            label4.Size = new Size(399, 20);
            label4.TabIndex = 16;
            label4.Text = "C a F: Convierte de gados Centigrados a grados Fahrenheit ";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Black;
            buttonSalir.ForeColor = Color.Transparent;
            buttonSalir.Location = new Point(176, 303);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(109, 51);
            buttonSalir.TabIndex = 17;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // For_Ejercisio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(455, 378);
            Controls.Add(buttonSalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonFsC);
            Controls.Add(buttonCaF);
            Controls.Add(textBoxRespuesta);
            Controls.Add(labelResultado);
            Controls.Add(textBoxIngreso);
            Controls.Add(labelIngreso);
            Controls.Add(label1);
            Controls.Add(buttonLimpiar);
            Name = "For_Ejercisio2";
            Text = "For_Ejercisio2";
            Shown += For_Ejercisio2_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimpiar;
        private TextBox textBoxIngreso;
        private Label labelIngreso;
        private Label label1;
        private Label labelResultado;
        private TextBox textBoxRespuesta;
        private Button buttonCaF;
        private Button buttonFsC;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonSalir;
    }
}