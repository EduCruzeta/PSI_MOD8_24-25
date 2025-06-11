namespace ProjetoMOD_8
{
    public partial class Form1 : Form
    {
        public List<string> pedidos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private string ObterPreco(string item)
        {
            switch (item)
            {
                case "Água": return "1,00";
                case "Coca-Cola": return "1,70";
                case "Sumol": return "1,80";

                case "Hambúrguer": return "5,00";
                case "Pizza": return "6,00";
                case "Batata Frita": return "2,50";

                case "Bolo de Chocolate": return "2,50";
                case "Pudim": return "2,00";
                case "Gelado": return "1,80";

                default: return "0,00";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CB_mesa.Text))
            {
                MessageBox.Show("Por favor, introduza o número da mesa.");
                return;
            }

            string nomeMesa = CB_mesa.Text;
            string pedidoFinal = "";

            string bebida = "";

            if (CHK_agua.Checked)
            {
                bebida = "Água";
                pedidoFinal += nomeMesa + " - " + bebida + " - " + ObterPreco(bebida) + " | ";
                CHK_agua.Checked = false;
            }

            if (CHK_cocacola.Checked)
            {
                bebida = "Coca-Cola";
                pedidoFinal += nomeMesa + " - " + bebida + " - " + ObterPreco(bebida) + " | ";
                CHK_cocacola.Checked = false;
            }

            if (CHK_sumol.Checked)
            {
                bebida = "Sumol";
                pedidoFinal += nomeMesa + " - " + bebida + " - " + ObterPreco(bebida) + " | ";
                CHK_sumol.Checked = false;
            }

            string prato = "";

            if (CHK_hamburguer.Checked)
            {
                prato = "Hambúrguer";
                pedidoFinal += nomeMesa + " - " + prato + " - " + ObterPreco(prato) + " | ";
                CHK_hamburguer.Checked = false;
            }

            if (CHK_pizza.Checked)
            {
                prato = "Pizza";
                pedidoFinal += nomeMesa + " - " + prato + " - " + ObterPreco(prato) + " | ";
                CHK_pizza.Checked = false;
            }

            if (CHK_batataFrita.Checked)
            {
                prato = "Batata Frita";
                pedidoFinal += nomeMesa + " - " + prato + " - " + ObterPreco(prato) + " | ";
                CHK_batataFrita.Checked = false;
            }

            string sobremesa = "";

            if (CHK_boloChocolate.Checked)
            {
                sobremesa = "Bolo de Chocolate";
                pedidoFinal += nomeMesa + " - " + sobremesa + " - " + ObterPreco(sobremesa);
                CHK_boloChocolate.Checked = false;
            }


            if (CHK_pudim.Checked)
            {
                sobremesa = "Pudim";
                pedidoFinal += nomeMesa + " - " + sobremesa + " - " + ObterPreco(sobremesa);
                CHK_pudim.Checked = false;
            }

            if (CHK_gelado.Checked)
            {
                sobremesa = "Gelado";
                pedidoFinal += nomeMesa + " - " + sobremesa + " - " + ObterPreco(sobremesa);
                CHK_gelado.Checked = false;

            }

            // Verifica se pelo 1 produto foi selecionado
            if (bebida == "" && prato == "" && sobremesa == "")
            {
                MessageBox.Show("Por favor, selecione pelo menos uma opção (bebida, prato ou sobremesa).");
                return;
            }

            // Adiciona o pedido a lista 
            pedidos.Add(pedidoFinal);

            MessageBox.Show("Pedido adicionado com sucesso.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se a lista tem algum pedido para enviar
            if (pedidos.Count == 0)
            {
                MessageBox.Show("Ainda não existem pedidos.");
                return;
            }

            Form2 formPedidos = new Form2(pedidos);
            formPedidos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre sobreprograma = new sobre();
            sobreprograma.ShowDialog();
        }
    }
}
