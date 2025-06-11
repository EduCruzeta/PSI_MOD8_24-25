namespace Programa_entradas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lb_pessoas_atual = new Label();
            NU_pessoas = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lb_relogio = new Label();
            ((System.ComponentModel.ISupportInitialize)NU_pessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 82);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Nº Pessoas";
            // 
            // lb_pessoas_atual
            // 
            lb_pessoas_atual.AutoSize = true;
            lb_pessoas_atual.Location = new Point(187, 116);
            lb_pessoas_atual.Name = "lb_pessoas_atual";
            lb_pessoas_atual.Size = new Size(0, 15);
            lb_pessoas_atual.TabIndex = 0;
            // 
            // NU_pessoas
            // 
            NU_pessoas.Location = new Point(187, 80);
            NU_pessoas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NU_pessoas.Name = "NU_pessoas";
            NU_pessoas.Size = new Size(120, 23);
            NU_pessoas.TabIndex = 1;
            NU_pessoas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(116, 134);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 134);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 2;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(164, 163);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 2;
            button3.Text = "Estatisticas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lb_relogio
            // 
            lb_relogio.AutoSize = true;
            lb_relogio.Location = new Point(12, 206);
            lb_relogio.Name = "lb_relogio";
            lb_relogio.Size = new Size(0, 15);
            lb_relogio.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 230);
            Controls.Add(lb_relogio);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NU_pessoas);
            Controls.Add(lb_pessoas_atual);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NU_pessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_pessoas_atual;
        private NumericUpDown NU_pessoas;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label lb_relogio;
    }
}
