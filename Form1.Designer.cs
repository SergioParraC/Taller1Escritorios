namespace Taller
{
    partial class For_VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEjercicio1 = new Button();
            label1 = new Label();
            buttonEjercicio2 = new Button();
            buttonEjercisio3 = new Button();
            buttonEjercicio4 = new Button();
            SuspendLayout();
            // 
            // buttonEjercicio1
            // 
            buttonEjercicio1.BackColor = Color.Black;
            buttonEjercicio1.ForeColor = Color.FromArgb(113, 209, 234);
            buttonEjercicio1.Location = new Point(10, 49);
            buttonEjercicio1.Margin = new Padding(3, 2, 3, 2);
            buttonEjercicio1.Name = "buttonEjercicio1";
            buttonEjercicio1.Size = new Size(103, 38);
            buttonEjercicio1.TabIndex = 0;
            buttonEjercicio1.Text = "Ejercicio 1";
            buttonEjercicio1.UseVisualStyleBackColor = false;
            buttonEjercicio1.Click += buttonEjercisio1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(79, 7);
            label1.Name = "label1";
            label1.Size = new Size(472, 28);
            label1.TabIndex = 1;
            label1.Text = "Solución taller 1 Desarrollo de entornos de escritorio";
            // 
            // buttonEjercicio2
            // 
            buttonEjercicio2.BackColor = Color.Black;
            buttonEjercicio2.ForeColor = Color.FromArgb(113, 209, 234);
            buttonEjercicio2.Location = new Point(134, 49);
            buttonEjercicio2.Margin = new Padding(3, 2, 3, 2);
            buttonEjercicio2.Name = "buttonEjercicio2";
            buttonEjercicio2.Size = new Size(103, 38);
            buttonEjercicio2.TabIndex = 2;
            buttonEjercicio2.Text = "Ejercicio 2";
            buttonEjercicio2.UseVisualStyleBackColor = false;
            buttonEjercicio2.Click += buttonEjercicio2_Click;
            // 
            // buttonEjercisio3
            // 
            buttonEjercisio3.BackColor = Color.Black;
            buttonEjercisio3.ForeColor = Color.FromArgb(113, 209, 234);
            buttonEjercisio3.Location = new Point(252, 49);
            buttonEjercisio3.Margin = new Padding(3, 2, 3, 2);
            buttonEjercisio3.Name = "buttonEjercisio3";
            buttonEjercisio3.Size = new Size(103, 38);
            buttonEjercisio3.TabIndex = 3;
            buttonEjercisio3.Text = "Ejercicio 3";
            buttonEjercisio3.UseVisualStyleBackColor = false;
            buttonEjercisio3.Click += buttonEjercisio3_Click;
            // 
            // buttonEjercicio4
            // 
            buttonEjercicio4.BackColor = Color.Black;
            buttonEjercicio4.ForeColor = Color.FromArgb(113, 209, 234);
            buttonEjercicio4.Location = new Point(367, 49);
            buttonEjercicio4.Margin = new Padding(3, 2, 3, 2);
            buttonEjercicio4.Name = "buttonEjercicio4";
            buttonEjercicio4.Size = new Size(103, 38);
            buttonEjercicio4.TabIndex = 4;
            buttonEjercicio4.Text = "Ejercicio 4";
            buttonEjercicio4.UseVisualStyleBackColor = false;
            buttonEjercicio4.Click += buttonEjercicio4_Click;
            // 
            // For_VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonEjercicio4);
            Controls.Add(buttonEjercisio3);
            Controls.Add(buttonEjercicio2);
            Controls.Add(label1);
            Controls.Add(buttonEjercicio1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "For_VentanaPrincipal";
            Text = "Taller Desarrollo en entornos de escritorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEjercicio1;
        private Label label1;
        private Button buttonEjercicio2;
        private Button buttonEjercisio3;
        private Button buttonEjercicio4;
    }
}
