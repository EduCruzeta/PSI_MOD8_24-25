namespace Programa_entradas
{
    partial class Form2
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
            lb_mensagem = new Label();
            SuspendLayout();
            // 
            // lb_mensagem
            // 
            lb_mensagem.AutoSize = true;
            lb_mensagem.Location = new Point(173, 81);
            lb_mensagem.Name = "lb_mensagem";
            lb_mensagem.Size = new Size(38, 15);
            lb_mensagem.TabIndex = 0;
            lb_mensagem.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 253);
            Controls.Add(lb_mensagem);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lb_mensagem;
    }
}