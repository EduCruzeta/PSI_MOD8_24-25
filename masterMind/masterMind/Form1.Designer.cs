namespace masterMind
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
            textBox1 = new TextBox();
            button1 = new Button();
            TB_tentativas = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 0;
            label1.Text = "Tente adivinhar a combinação de números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 62);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Combinação secreta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 62);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 1;
            label3.Text = "****";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(333, 91);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 3;
            button1.Text = "testar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TB_tentativas
            // 
            TB_tentativas.FormattingEnabled = true;
            TB_tentativas.ItemHeight = 15;
            TB_tentativas.Location = new Point(187, 158);
            TB_tentativas.Name = "TB_tentativas";
            TB_tentativas.Size = new Size(123, 94);
            TB_tentativas.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 158);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 0;
            label4.Text = "X - Nº Errado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 198);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 0;
            label5.Text = "E - Posição errada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 237);
            label6.Name = "label6";
            label6.Size = new Size(166, 15);
            label6.TabIndex = 0;
            label6.Text = "C - Está certo na posição certa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 271);
            Controls.Add(TB_tentativas);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private TextBox textBox1;
        private Button button1;
        private ListBox TB_tentativas;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
