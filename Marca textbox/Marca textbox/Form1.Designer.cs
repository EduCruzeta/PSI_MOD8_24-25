namespace Marca_textbox
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
            label2 = new Label();
            cbMarcas = new ComboBox();
            lbEscolhidas = new ListBox();
            Remover = new Button();
            Limpar = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 57);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Marcas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Escolhidos";
            // 
            // cbMarcas
            // 
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new Point(44, 75);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new Size(121, 23);
            cbMarcas.TabIndex = 1;
            toolTip1.SetToolTip(cbMarcas, "Escolha uma marca");
            cbMarcas.SelectedIndexChanged += cbMarcas_SelectedIndexChanged;
            // 
            // lbEscolhidas
            // 
            lbEscolhidas.FormattingEnabled = true;
            lbEscolhidas.ItemHeight = 15;
            lbEscolhidas.Location = new Point(269, 75);
            lbEscolhidas.Name = "lbEscolhidas";
            lbEscolhidas.Size = new Size(148, 94);
            lbEscolhidas.TabIndex = 2;
            toolTip1.SetToolTip(lbEscolhidas, "Marcas escolhidas");
            // 
            // Remover
            // 
            Remover.Location = new Point(269, 175);
            Remover.Name = "Remover";
            Remover.Size = new Size(67, 23);
            Remover.TabIndex = 3;
            Remover.Text = "Remover";
            toolTip1.SetToolTip(Remover, "Remove a marca selecionada.");
            Remover.UseVisualStyleBackColor = true;
            Remover.Click += Remover_Click;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(350, 175);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(67, 23);
            Limpar.TabIndex = 3;
            Limpar.Text = "Limpar";
            toolTip1.SetToolTip(Limpar, "Remove todas as marcas");
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 244);
            Controls.Add(Limpar);
            Controls.Add(Remover);
            Controls.Add(lbEscolhidas);
            Controls.Add(cbMarcas);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbMarcas;
        private ListBox lbEscolhidas;
        private Button Remover;
        private Button Limpar;
        private ToolTip toolTip1;
    }
}
