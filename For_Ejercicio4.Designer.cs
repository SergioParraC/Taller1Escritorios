namespace Taller
{
    partial class For_Ejercicio4
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
            textBoxNota1 = new TextBox();
            labelNota1 = new Label();
            labelTitulo = new Label();
            textBoxNota2 = new TextBox();
            textBoxNota3 = new TextBox();
            labelNota2 = new Label();
            labelNoa3 = new Label();
            label1 = new Label();
            labelPromedio = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(106, 53);
            textBoxNota1.Margin = new Padding(3, 2, 3, 2);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(110, 23);
            textBoxNota1.TabIndex = 11;
            // 
            // labelNota1
            // 
            labelNota1.AutoSize = true;
            labelNota1.ForeColor = SystemColors.Control;
            labelNota1.Location = new Point(19, 56);
            labelNota1.Name = "labelNota1";
            labelNota1.Size = new Size(84, 15);
            labelNota1.TabIndex = 10;
            labelNota1.Text = "Ingrese nota 1:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.ForeColor = SystemColors.ButtonHighlight;
            labelTitulo.Location = new Point(19, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 28);
            labelTitulo.TabIndex = 9;
            labelTitulo.Text = "Solución ejercicio 4";
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(106, 87);
            textBoxNota2.Margin = new Padding(3, 2, 3, 2);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(110, 23);
            textBoxNota2.TabIndex = 12;
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new Point(106, 120);
            textBoxNota3.Margin = new Padding(3, 2, 3, 2);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new Size(110, 23);
            textBoxNota3.TabIndex = 13;
            // 
            // labelNota2
            // 
            labelNota2.AutoSize = true;
            labelNota2.ForeColor = SystemColors.Control;
            labelNota2.Location = new Point(19, 90);
            labelNota2.Name = "labelNota2";
            labelNota2.Size = new Size(84, 15);
            labelNota2.TabIndex = 14;
            labelNota2.Text = "Ingrese nota 2:";
            // 
            // labelNoa3
            // 
            labelNoa3.AutoSize = true;
            labelNoa3.ForeColor = SystemColors.Control;
            labelNoa3.Location = new Point(19, 121);
            labelNoa3.Name = "labelNoa3";
            labelNoa3.Size = new Size(84, 15);
            labelNoa3.TabIndex = 15;
            labelNoa3.Text = "Ingrese nota 3:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(15, 166);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 16;
            label1.Text = "El promedio es:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.BackColor = Color.Yellow;
            labelPromedio.ForeColor = SystemColors.ActiveCaptionText;
            labelPromedio.Location = new Point(120, 166);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(0, 15);
            labelPromedio.TabIndex = 17;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.Black;
            buttonCalcular.ForeColor = Color.Transparent;
            buttonCalcular.Location = new Point(19, 193);
            buttonCalcular.Margin = new Padding(3, 2, 3, 2);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 25);
            buttonCalcular.TabIndex = 18;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // For_Ejercicio4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(246, 236);
            Controls.Add(buttonCalcular);
            Controls.Add(labelPromedio);
            Controls.Add(label1);
            Controls.Add(labelNoa3);
            Controls.Add(labelNota2);
            Controls.Add(textBoxNota3);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota1);
            Controls.Add(labelNota1);
            Controls.Add(labelTitulo);
            Name = "For_Ejercicio4";
            Text = "For_Ejercicio4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNota1;
        private Label labelNota1;
        private Label labelTitulo;
        private TextBox textBoxNota2;
        private TextBox textBoxNota3;
        private Label labelNota2;
        private Label labelNoa3;
        private Label label1;
        private Label labelPromedio;
        private Button buttonCalcular;
    }
}