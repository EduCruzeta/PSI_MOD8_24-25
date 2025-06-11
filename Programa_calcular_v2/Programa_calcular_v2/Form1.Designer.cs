namespace Programa_calcular_v2
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
            bt_calcular = new Button();
            bt_limpar = new Button();
            NU_numero = new NumericUpDown();
            lb_resultados = new Label();
            ((System.ComponentModel.ISupportInitialize)NU_numero).BeginInit();
            SuspendLayout();
            // 
            // bt_calcular
            // 
            bt_calcular.Location = new Point(9, 78);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(123, 38);
            bt_calcular.TabIndex = 0;
            bt_calcular.Text = "Calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // bt_limpar
            // 
            bt_limpar.Location = new Point(9, 122);
            bt_limpar.Name = "bt_limpar";
            bt_limpar.Size = new Size(123, 38);
            bt_limpar.TabIndex = 0;
            bt_limpar.Text = "Limpar";
            bt_limpar.UseVisualStyleBackColor = true;
            bt_limpar.Click += bt_limpar_Click;
            // 
            // NU_numero
            // 
            NU_numero.Location = new Point(9, 49);
            NU_numero.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NU_numero.Name = "NU_numero";
            NU_numero.Size = new Size(120, 23);
            NU_numero.TabIndex = 1;
            // 
            // lb_resultados
            // 
            lb_resultados.AutoSize = true;
            lb_resultados.Location = new Point(155, 49);
            lb_resultados.Name = "lb_resultados";
            lb_resultados.Size = new Size(0, 15);
            lb_resultados.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(313, 189);
            Controls.Add(lb_resultados);
            Controls.Add(NU_numero);
            Controls.Add(bt_limpar);
            Controls.Add(bt_calcular);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)NU_numero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button bt_calcular;
        private Button bt_limpar;
        private NumericUpDown NU_numero;
        private Label lb_resultados;
    }
}