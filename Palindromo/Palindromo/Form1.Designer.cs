namespace Palindromo
{
    partial class Form1
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
            label1 = new Label();
            tb_palavra = new TextBox();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 89);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduz uma palavra";
            // 
            // tb_palavra
            // 
            tb_palavra.Location = new Point(246, 86);
            tb_palavra.Name = "tb_palavra";
            tb_palavra.Size = new Size(100, 23);
            tb_palavra.TabIndex = 1;
            tb_palavra.TextChanged += textBox1_TextChanged;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(246, 127);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(0, 15);
            lb_resultado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_resultado);
            Controls.Add(tb_palavra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_palavra;
        private Label lb_resultado;
    }
}
