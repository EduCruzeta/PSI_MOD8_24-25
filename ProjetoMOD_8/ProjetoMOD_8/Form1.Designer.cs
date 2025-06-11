namespace ProjetoMOD_8
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
            GroupBox GB_bebidas;
            CHK_sumol = new CheckBox();
            CHK_cocacola = new CheckBox();
            CHK_agua = new CheckBox();
            label1 = new Label();
            CB_mesa = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            GB_pratos = new GroupBox();
            CHK_pizza = new CheckBox();
            CHK_hamburguer = new CheckBox();
            CHK_batataFrita = new CheckBox();
            GB_sobremesas = new GroupBox();
            CHK_gelado = new CheckBox();
            CHK_pudim = new CheckBox();
            CHK_boloChocolate = new CheckBox();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            GB_bebidas = new GroupBox();
            GB_bebidas.SuspendLayout();
            GB_pratos.SuspendLayout();
            GB_sobremesas.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GB_bebidas
            // 
            GB_bebidas.Controls.Add(CHK_sumol);
            GB_bebidas.Controls.Add(CHK_cocacola);
            GB_bebidas.Controls.Add(CHK_agua);
            GB_bebidas.Location = new Point(10, 86);
            GB_bebidas.Name = "GB_bebidas";
            GB_bebidas.RightToLeft = RightToLeft.No;
            GB_bebidas.Size = new Size(186, 128);
            GB_bebidas.TabIndex = 3;
            GB_bebidas.TabStop = false;
            GB_bebidas.Text = "Bebidas";
            // 
            // CHK_sumol
            // 
            CHK_sumol.AutoSize = true;
            CHK_sumol.Location = new Point(6, 92);
            CHK_sumol.Name = "CHK_sumol";
            CHK_sumol.Size = new Size(121, 19);
            CHK_sumol.TabIndex = 7;
            CHK_sumol.Text = "Sumol (1L) - 1.80€";
            CHK_sumol.UseVisualStyleBackColor = true;
            // 
            // CHK_cocacola
            // 
            CHK_cocacola.AutoSize = true;
            CHK_cocacola.Location = new Point(6, 23);
            CHK_cocacola.Name = "CHK_cocacola";
            CHK_cocacola.Size = new Size(143, 19);
            CHK_cocacola.TabIndex = 7;
            CHK_cocacola.Text = "Coca-Cola (1L) - 1.70€";
            CHK_cocacola.UseVisualStyleBackColor = true;
            // 
            // CHK_agua
            // 
            CHK_agua.AutoSize = true;
            CHK_agua.Location = new Point(6, 57);
            CHK_agua.Name = "CHK_agua";
            CHK_agua.Size = new Size(109, 19);
            CHK_agua.TabIndex = 7;
            CHK_agua.Text = "Água (1.5L) - 1€";
            CHK_agua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Mesa:";
            // 
            // CB_mesa
            // 
            CB_mesa.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_mesa.Items.AddRange(new object[] { "Mesa  1", "Mesa  2", "Mesa  3", "Mesa  4", "Mesa  5", "Mesa  6", "Mesa  7", "Mesa  8" });
            CB_mesa.Location = new Point(62, 32);
            CB_mesa.Name = "CB_mesa";
            CB_mesa.Size = new Size(121, 23);
            CB_mesa.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(102, 233);
            button1.Name = "button1";
            button1.Size = new Size(188, 55);
            button1.TabIndex = 4;
            button1.Text = "[ Adicionar Pedido ]";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 233);
            button2.Name = "button2";
            button2.Size = new Size(188, 55);
            button2.TabIndex = 4;
            button2.Text = "[ Ver Pedidos ]";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GB_pratos
            // 
            GB_pratos.Controls.Add(CHK_pizza);
            GB_pratos.Controls.Add(CHK_hamburguer);
            GB_pratos.Controls.Add(CHK_batataFrita);
            GB_pratos.Location = new Point(202, 86);
            GB_pratos.Margin = new Padding(3, 2, 3, 2);
            GB_pratos.Name = "GB_pratos";
            GB_pratos.Padding = new Padding(3, 2, 3, 2);
            GB_pratos.Size = new Size(186, 128);
            GB_pratos.TabIndex = 5;
            GB_pratos.TabStop = false;
            GB_pratos.Text = "Pratos";
            // 
            // CHK_pizza
            // 
            CHK_pizza.AutoSize = true;
            CHK_pizza.Location = new Point(6, 92);
            CHK_pizza.Name = "CHK_pizza";
            CHK_pizza.Size = new Size(75, 19);
            CHK_pizza.TabIndex = 7;
            CHK_pizza.Text = "Pizza - 6€";
            CHK_pizza.UseVisualStyleBackColor = true;
            // 
            // CHK_hamburguer
            // 
            CHK_hamburguer.AutoSize = true;
            CHK_hamburguer.Location = new Point(6, 23);
            CHK_hamburguer.Name = "CHK_hamburguer";
            CHK_hamburguer.Size = new Size(117, 19);
            CHK_hamburguer.TabIndex = 7;
            CHK_hamburguer.Text = "Hambúrguer - 5€";
            CHK_hamburguer.UseVisualStyleBackColor = true;
            // 
            // CHK_batataFrita
            // 
            CHK_batataFrita.AutoSize = true;
            CHK_batataFrita.Location = new Point(6, 57);
            CHK_batataFrita.Name = "CHK_batataFrita";
            CHK_batataFrita.Size = new Size(123, 19);
            CHK_batataFrita.TabIndex = 7;
            CHK_batataFrita.Text = "Batata Frita - 2.50€";
            CHK_batataFrita.UseVisualStyleBackColor = true;
            // 
            // GB_sobremesas
            // 
            GB_sobremesas.Controls.Add(CHK_gelado);
            GB_sobremesas.Controls.Add(CHK_pudim);
            GB_sobremesas.Controls.Add(CHK_boloChocolate);
            GB_sobremesas.Location = new Point(394, 86);
            GB_sobremesas.Margin = new Padding(3, 2, 3, 2);
            GB_sobremesas.Name = "GB_sobremesas";
            GB_sobremesas.Padding = new Padding(3, 2, 3, 2);
            GB_sobremesas.Size = new Size(186, 128);
            GB_sobremesas.TabIndex = 6;
            GB_sobremesas.TabStop = false;
            GB_sobremesas.Text = "Sobremesas";
            // 
            // CHK_gelado
            // 
            CHK_gelado.AutoSize = true;
            CHK_gelado.Location = new Point(4, 92);
            CHK_gelado.Name = "CHK_gelado";
            CHK_gelado.Size = new Size(101, 19);
            CHK_gelado.TabIndex = 7;
            CHK_gelado.Text = "Gelado - 1.80€";
            CHK_gelado.UseVisualStyleBackColor = true;
            // 
            // CHK_pudim
            // 
            CHK_pudim.AutoSize = true;
            CHK_pudim.Location = new Point(4, 23);
            CHK_pudim.Name = "CHK_pudim";
            CHK_pudim.Size = new Size(84, 19);
            CHK_pudim.TabIndex = 7;
            CHK_pudim.Text = "Pudim - 2€";
            CHK_pudim.UseVisualStyleBackColor = true;
            // 
            // CHK_boloChocolate
            // 
            CHK_boloChocolate.AutoSize = true;
            CHK_boloChocolate.Location = new Point(4, 57);
            CHK_boloChocolate.Name = "CHK_boloChocolate";
            CHK_boloChocolate.Size = new Size(161, 19);
            CHK_boloChocolate.TabIndex = 7;
            CHK_boloChocolate.Text = "Bolo de Chocolate - 2.50€";
            CHK_boloChocolate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(592, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 304);
            Controls.Add(GB_sobremesas);
            Controls.Add(GB_pratos);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(GB_bebidas);
            Controls.Add(CB_mesa);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Restaurante Sem maneiras";
            GB_bebidas.ResumeLayout(false);
            GB_bebidas.PerformLayout();
            GB_pratos.ResumeLayout(false);
            GB_pratos.PerformLayout();
            GB_sobremesas.ResumeLayout(false);
            GB_sobremesas.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CB_mesa;
        private RadioButton RB_cocacola;
        private GroupBox GB_bebidas;
        private RadioButton RB_agua;
        private RadioButton RB_sumol;
        private RadioButton RB_gelado;
        private RadioButton RB_boloChocolate;
        private RadioButton RB_pudim;
        private Button button1;
        private Button button2;
        private RadioButton RB_hamburguer;
        private RadioButton RB_pizza;
        private RadioButton RB_batatafrita;
        private GroupBox GB_pratos;
        private GroupBox GB_sobremesas;
        private CheckBox CHK_cocacola;
        private CheckBox CHK_sumol;
        private CheckBox CHK_agua;
        private CheckBox CHK_batataFrita;
        private CheckBox CHK_boloChocolate;
        private CheckBox CHK_pudim;
        private CheckBox CHK_pizza;
        private CheckBox CHK_hamburguer;
        private CheckBox CHK_gelado;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
