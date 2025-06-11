namespace ProjetoMOD_8
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            CB_mesas = new ComboBox();
            LB_pedidos = new ListBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            TB_total = new TextBox();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Mesa: ";
            // 
            // CB_mesas
            // 
            CB_mesas.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_mesas.FormattingEnabled = true;
            CB_mesas.Items.AddRange(new object[] { "Mesa  1", "Mesa  2", "Mesa  3", "Mesa  4", "Mesa  5", "Mesa  6", "Mesa  7", "Mesa  8" });
            CB_mesas.Location = new Point(59, 20);
            CB_mesas.Name = "CB_mesas";
            CB_mesas.Size = new Size(121, 23);
            CB_mesas.TabIndex = 1;
            CB_mesas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LB_pedidos
            // 
            LB_pedidos.FormattingEnabled = true;
            LB_pedidos.ItemHeight = 15;
            LB_pedidos.Location = new Point(2, 22);
            LB_pedidos.Name = "LB_pedidos";
            LB_pedidos.Size = new Size(212, 139);
            LB_pedidos.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LB_pedidos);
            groupBox1.Location = new Point(59, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 187);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itens do Pedido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 259);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Total: ";
            // 
            // TB_total
            // 
            TB_total.Location = new Point(57, 256);
            TB_total.Name = "TB_total";
            TB_total.ReadOnly = true;
            TB_total.Size = new Size(78, 23);
            TB_total.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(34, 290);
            button1.Name = "button1";
            button1.Size = new Size(119, 47);
            button1.TabIndex = 6;
            button1.Text = "[ Pagar Pedido ]";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(193, 290);
            button2.Name = "button2";
            button2.Size = new Size(117, 47);
            button2.TabIndex = 6;
            button2.Text = "[ Fechar ]";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 348);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TB_total);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(CB_mesas);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Pedidos";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CB_mesas;
        private ListBox LB_pedidos;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox TB_total;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}