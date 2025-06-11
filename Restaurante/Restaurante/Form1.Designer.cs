namespace Restaurante
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
            Cb_vegetariano = new CheckBox();
            RB_sobremesa = new RadioButton();
            RB_Prato = new RadioButton();
            RB_Bebida = new RadioButton();
            Lb_Escolha = new ListBox();
            button1 = new Button();
            Lb_Ementa = new ListBox();
            SuspendLayout();
            // 
            // Cb_vegetariano
            // 
            Cb_vegetariano.AutoSize = true;
            Cb_vegetariano.CheckAlign = ContentAlignment.MiddleRight;
            Cb_vegetariano.Location = new Point(12, 12);
            Cb_vegetariano.Name = "Cb_vegetariano";
            Cb_vegetariano.Size = new Size(88, 19);
            Cb_vegetariano.TabIndex = 0;
            Cb_vegetariano.Text = "Vegetariano";
            Cb_vegetariano.UseVisualStyleBackColor = true;
            Cb_vegetariano.CheckedChanged += Cb_vegetariano_CheckedChanged;
            // 
            // RB_sobremesa
            // 
            RB_sobremesa.AutoSize = true;
            RB_sobremesa.CheckAlign = ContentAlignment.MiddleRight;
            RB_sobremesa.Location = new Point(12, 53);
            RB_sobremesa.Name = "RB_sobremesa";
            RB_sobremesa.Size = new Size(83, 19);
            RB_sobremesa.TabIndex = 1;
            RB_sobremesa.TabStop = true;
            RB_sobremesa.Text = "Sobremesa";
            RB_sobremesa.UseVisualStyleBackColor = true;
            RB_sobremesa.CheckedChanged += RB_sobremesa_CheckedChanged;
            // 
            // RB_Prato
            // 
            RB_Prato.AutoSize = true;
            RB_Prato.CheckAlign = ContentAlignment.MiddleRight;
            RB_Prato.Location = new Point(12, 78);
            RB_Prato.Name = "RB_Prato";
            RB_Prato.Size = new Size(53, 19);
            RB_Prato.TabIndex = 1;
            RB_Prato.TabStop = true;
            RB_Prato.Text = "Prato";
            RB_Prato.UseVisualStyleBackColor = true;
            RB_Prato.CheckedChanged += RB_Prato_CheckedChanged;
            // 
            // RB_Bebida
            // 
            RB_Bebida.AutoSize = true;
            RB_Bebida.CheckAlign = ContentAlignment.MiddleRight;
            RB_Bebida.Location = new Point(12, 103);
            RB_Bebida.Name = "RB_Bebida";
            RB_Bebida.Size = new Size(61, 19);
            RB_Bebida.TabIndex = 1;
            RB_Bebida.TabStop = true;
            RB_Bebida.Text = "Bebida";
            RB_Bebida.UseVisualStyleBackColor = true;
            RB_Bebida.CheckedChanged += RB_Bebida_CheckedChanged;
            // 
            // Lb_Escolha
            // 
            Lb_Escolha.FormattingEnabled = true;
            Lb_Escolha.ItemHeight = 15;
            Lb_Escolha.Location = new Point(239, 128);
            Lb_Escolha.Name = "Lb_Escolha";
            Lb_Escolha.Size = new Size(97, 154);
            Lb_Escolha.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(140, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            // 
            // Lb_Ementa
            // 
            Lb_Ementa.FormattingEnabled = true;
            Lb_Ementa.ItemHeight = 15;
            Lb_Ementa.Location = new Point(12, 128);
            Lb_Ementa.Name = "Lb_Ementa";
            Lb_Ementa.Size = new Size(97, 154);
            Lb_Ementa.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 303);
            Controls.Add(button1);
            Controls.Add(Lb_Ementa);
            Controls.Add(Lb_Escolha);
            Controls.Add(RB_Bebida);
            Controls.Add(RB_Prato);
            Controls.Add(RB_sobremesa);
            Controls.Add(Cb_vegetariano);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox Cb_vegetariano;
        private RadioButton RB_sobremesa;
        private RadioButton RB_Prato;
        private RadioButton RB_Bebida;
        private ListBox Lb_Escolha;
        private Button button1;
        private ListBox Lb_Ementa;
    }
}
