namespace Taller
{
    partial class For_Ejercicio1
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
            label1 = new Label();
            buttonMultiplicar = new Button();
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            labelOperador1 = new Label();
            labelOperador2 = new Label();
            textBoxOperador1 = new TextBox();
            textBoxOperador2 = new TextBox();
            textBoxResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 35);
            label1.TabIndex = 0;
            label1.Text = "Solución ejercicio 1";
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.BackColor = Color.Black;
            buttonMultiplicar.ForeColor = Color.Transparent;
            buttonMultiplicar.Location = new Point(12, 129);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(98, 33);
            buttonMultiplicar.TabIndex = 1;
            buttonMultiplicar.Text = "Multiplicar";
            buttonMultiplicar.UseVisualStyleBackColor = false;
            buttonMultiplicar.Click += buttonMultiplicar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.Black;
            buttonLimpiar.ForeColor = Color.Transparent;
            buttonLimpiar.Location = new Point(12, 188);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(109, 51);
            buttonLimpiar.TabIndex = 2;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Black;
            buttonSalir.ForeColor = Color.Transparent;
            buttonSalir.Location = new Point(153, 188);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(109, 51);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // labelOperador1
            // 
            labelOperador1.AutoSize = true;
            labelOperador1.ForeColor = SystemColors.Control;
            labelOperador1.Location = new Point(12, 58);
            labelOperador1.Name = "labelOperador1";
            labelOperador1.Size = new Size(85, 20);
            labelOperador1.TabIndex = 4;
            labelOperador1.Text = "Operador 1";
            // 
            // labelOperador2
            // 
            labelOperador2.AutoSize = true;
            labelOperador2.ForeColor = SystemColors.Control;
            labelOperador2.Location = new Point(12, 95);
            labelOperador2.Name = "labelOperador2";
            labelOperador2.Size = new Size(85, 20);
            labelOperador2.TabIndex = 5;
            labelOperador2.Text = "Operador 2";
            // 
            // textBoxOperador1
            // 
            textBoxOperador1.Location = new Point(125, 55);
            textBoxOperador1.Name = "textBoxOperador1";
            textBoxOperador1.Size = new Size(125, 27);
            textBoxOperador1.TabIndex = 6;
            textBoxOperador1.KeyPress += textBoxOperador1_KeyPress;
            // 
            // textBoxOperador2
            // 
            textBoxOperador2.Location = new Point(125, 92);
            textBoxOperador2.Name = "textBoxOperador2";
            textBoxOperador2.Size = new Size(125, 27);
            textBoxOperador2.TabIndex = 7;
            textBoxOperador2.KeyPress += textBoxOperador2_KeyPress;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(125, 129);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(125, 27);
            textBoxResultado.TabIndex = 8;
            // 
            // For_Ejercisio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(278, 253);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxOperador2);
            Controls.Add(textBoxOperador1);
            Controls.Add(labelOperador2);
            Controls.Add(labelOperador1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonMultiplicar);
            Controls.Add(label1);
            Name = "For_Ejercisio1";
            Text = "Solución ejercicio 1";
            Shown += For_Ejercisio1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonMultiplicar;
        private Button buttonLimpiar;
        private Button buttonSalir;
        private Label labelOperador1;
        private Label labelOperador2;
        private TextBox textBoxOperador1;
        private TextBox textBoxOperador2;
        private TextBox textBoxResultado;
    }
}