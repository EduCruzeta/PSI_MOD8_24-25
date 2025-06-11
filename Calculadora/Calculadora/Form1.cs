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
            // converter o sender num bot�o
            Button bt = (Button)sender;
            Tb_painel.Text += bt.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //bot�o opera��o
        private void button15_Click(object sender, EventArgs e)
        {
            // guardar a opera��o selecionada
            Button bt = (Button)sender;
            operacao = bt.Text;
            // guardar o numero atual
            primeiroNumero = Convert.ToSingle(Tb_painel.Text);
            // limpar o painel
            Tb_painel.Text = "0";
        }
        // bot�o =
        private void button16_Click(object sender, EventArgs e)
        {
            // guardar o numero atual
            float segundoNumero = Convert.ToSingle(Tb_painel.Text);
            float resultado = 0;
            // verificar qual � a opera��o
            switch (operacao)
            {
                // executar a opera��o
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
                    MessageBox.Show("Opera��o n�o est� definida");
                    break;
            }
            // limpar a opera��o
            operacao = "";
            // guardar o resultado no painel e na vari�vel no primeiroNumero
            Tb_painel.Text = resultado.ToString();
            primeiroNumero = resultado;
        }
        // bot�o limpar
        private void button20_Click(object sender, EventArgs e)
        {
            operacao = "";
            Tb_painel.Text = "0";
            primeiroNumero = 0;

        }
    }
}
