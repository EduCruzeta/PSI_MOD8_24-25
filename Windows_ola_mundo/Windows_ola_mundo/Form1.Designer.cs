namespace Windows_ola_mundo
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
            lb_Mensagem = new Label();
            tb_Nome = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lb_Mensagem
            // 
            lb_Mensagem.AutoSize = true;
            lb_Mensagem.Location = new Point(132, 162);
            lb_Mensagem.Name = "lb_Mensagem";
            lb_Mensagem.Size = new Size(0, 15);
            lb_Mensagem.TabIndex = 0;
            // 
            // tb_Nome
            // 
            tb_Nome.Location = new Point(132, 54);
            tb_Nome.Name = "tb_Nome";
            tb_Nome.Size = new Size(221, 23);
            tb_Nome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(374, 53);
            button1.Name = "button1";
            button1.Size = new Size(84, 24);
            button1.TabIndex = 2;
            button1.Text = "Diz olá";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(464, 54);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 3;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_Nome);
            Controls.Add(lb_Mensagem);
            Name = "Form1";
            Text = "Olá mundo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Mensagem;
        private TextBox tb_Nome;
        private Button button1;
        private Button button2;
    }
}
