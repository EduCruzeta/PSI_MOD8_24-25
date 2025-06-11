namespace Calcular_nota
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
            tb_nome = new TextBox();
            label2 = new Label();
            tb_teste = new TextBox();
            label3 = new Label();
            tb_desafio = new TextBox();
            label4 = new Label();
            tb_projeto = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lb_mensagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(73, 29);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(247, 23);
            tb_nome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Teste";
            // 
            // tb_teste
            // 
            tb_teste.Location = new Point(73, 58);
            tb_teste.Name = "tb_teste";
            tb_teste.Size = new Size(247, 23);
            tb_teste.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 90);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Desafio";
            // 
            // tb_desafio
            // 
            tb_desafio.Location = new Point(73, 87);
            tb_desafio.Name = "tb_desafio";
            tb_desafio.Size = new Size(247, 23);
            tb_desafio.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 119);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Projeto";
            // 
            // tb_projeto
            // 
            tb_projeto.Location = new Point(73, 116);
            tb_projeto.Name = "tb_projeto";
            tb_projeto.Size = new Size(247, 23);
            tb_projeto.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(123, 145);
            button1.Name = "button1";
            button1.Size = new Size(148, 27);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 61);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "30%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 90);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 4;
            label6.Text = "30%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 119);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 4;
            label7.Text = "40%";
            // 
            // lb_mensagem
            // 
            lb_mensagem.AutoSize = true;
            lb_mensagem.Location = new Point(149, 195);
            lb_mensagem.Name = "lb_mensagem";
            lb_mensagem.Size = new Size(0, 15);
            lb_mensagem.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 232);
            Controls.Add(lb_mensagem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(tb_projeto);
            Controls.Add(label4);
            Controls.Add(tb_desafio);
            Controls.Add(label3);
            Controls.Add(tb_teste);
            Controls.Add(label2);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calcular Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_nome;
        private Label label2;
        private TextBox tb_teste;
        private Label label3;
        private TextBox tb_desafio;
        private Label label4;
        private TextBox tb_projeto;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lb_mensagem;
    }
}
