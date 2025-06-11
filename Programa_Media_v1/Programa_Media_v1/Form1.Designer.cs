namespace Programa_Media_v1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_1numero = new TextBox();
            tb_2numero = new TextBox();
            tb_3numero = new TextBox();
            tb_4numero = new TextBox();
            button1 = new Button();
            label5 = new Label();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "1º Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "2ºNúmero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "3ºNúmero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "4ºNúmero";
            // 
            // tb_1numero
            // 
            tb_1numero.Location = new Point(80, 21);
            tb_1numero.Name = "tb_1numero";
            tb_1numero.Size = new Size(100, 23);
            tb_1numero.TabIndex = 1;
            // 
            // tb_2numero
            // 
            tb_2numero.Location = new Point(80, 50);
            tb_2numero.Name = "tb_2numero";
            tb_2numero.Size = new Size(100, 23);
            tb_2numero.TabIndex = 1;
            // 
            // tb_3numero
            // 
            tb_3numero.Location = new Point(80, 79);
            tb_3numero.Name = "tb_3numero";
            tb_3numero.Size = new Size(100, 23);
            tb_3numero.TabIndex = 1;
            // 
            // tb_4numero
            // 
            tb_4numero.Location = new Point(80, 108);
            tb_4numero.Name = "tb_4numero";
            tb_4numero.Size = new Size(100, 23);
            tb_4numero.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(80, 151);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 215);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Resultado";
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(74, 215);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(0, 15);
            lb_resultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 274);
            Controls.Add(lb_resultado);
            Controls.Add(button1);
            Controls.Add(tb_4numero);
            Controls.Add(tb_3numero);
            Controls.Add(tb_2numero);
            Controls.Add(tb_1numero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_1numero;
        private TextBox tb_2numero;
        private TextBox tb_3numero;
        private TextBox tb_4numero;
        private Button button1;
        private Label label5;
        private Label lb_resultado;
    }
}
