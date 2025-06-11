namespace Calculadora
{
    public partial class form1 : Form
    {
        // variaveis da classe
        string operacao;
        float primeiroNumero;

        public form1()
        {
            InitializeComponent();
            Tb_painel.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // converter o sender num botão
            Button bt = (Button)sender;
            Tb_painel.Text += bt.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //botão operação
        private void button15_Click(object sender, EventArgs e)
        {
            // guardar a operação selecionada
            Button bt = (Button)sender;
            operacao = bt.Text;
            // guardar o numero atual
            primeiroNumero = Convert.ToSingle(Tb_painel.Text);
            // limpar o painel
            Tb_painel.Text = "0";
        }
        // botão =
        private void button16_Click(object sender, EventArgs e)
        {
            // guardar o numero atual
            float segundoNumero = Convert.ToSingle(Tb_painel.Text);
            float resultado = 0;
            // verificar qual é a operação
            switch (operacao)
            {
                // executar a operação
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "*":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "/":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                default:
                    MessageBox.Show("Operação não está definida");
                    break;
            }
            // limpar a operação
            operacao = "";
            // guardar o resultado no painel e na variável no primeiroNumero
            Tb_painel.Text = resultado.ToString();
            primeiroNumero = resultado;
        }
        // botão limpar
        private void button20_Click(object sender, EventArgs e)
        {
            operacao = "";
            Tb_painel.Text = "0";
            primeiroNumero = 0;

        }
    }
}
