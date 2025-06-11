namespace Programa_entradas
{
    public partial class Form1 : Form
    {
        // variavel para as pessoas
        int n_pessoas = 0;
        // maior numero de pessoas que entraram na loja
        int maior = 0;
        // para calcular a média
        int contar = 0, somaTotal = 0;
        // guarda o numero mais alto de pessoas na loja
        int maiorLotacao = 0;


        public Form1()
        {
            InitializeComponent();
            lb_pessoas_atual.Text = "Pessoas na loja: 0";
        }
        // timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;

            lb_relogio.Text = agora.ToString("HH:mm:ss");
        }
        //bt entrar
        private void button1_Click(object sender, EventArgs e)
        {
            int entrar = (int)NU_pessoas.Value;
            if (n_pessoas + entrar > 100)
            {
                MessageBox.Show("Nº de pessoas ultrapassa o limite de 100. Por favor volte mais tarde.");
                    return;
            }
            n_pessoas += entrar;
            lb_pessoas_atual.Text = $"Pessoas na loja: {n_pessoas}";
            NU_pessoas.Value = 1;
            // verificar se é o maior numero de pessoas que entraram na loja
            if (entrar > maior)
                maior = entrar;
            // contar e somar entrada
            contar += 1;
            somaTotal += entrar;
            // verificar se atingui a maior lotação
            if (n_pessoas > maiorLotacao)
                maiorLotacao = n_pessoas;
        }
        // bt sair
        private void button2_Click(object sender, EventArgs e)
        {
            int sair = (int)NU_pessoas.Value;
            if (n_pessoas <= 0)
            {
                MessageBox.Show("Não existe esse nº de pessoas para sair");
                return;
            }
            n_pessoas -= sair;
            lb_pessoas_atual.Text = $"Pessoas na loja: {n_pessoas}";
            NU_pessoas.Value = 1;
        }
        //bt estatisticas
        private void button3_Click(object sender, EventArgs e)
        {
            float media = 0;

            media = (float)somaTotal / contar;

            // criar um objeto do tipo form2
            Form2 f = new Form2();

            string mensagem = "Maior nº de pessoas que entraram: " + maior;
            mensagem += "\nMédia de pessoas que entraram: " + media;
            mensagem += "\nMaior lotação: " + maiorLotacao;

            //alterar o modifier do label para public
            // para permitir fazer alterações apartir de outro form
            f.lb_mensagem.Text = mensagem;
            f.ShowDialog();

            //segundo metodo que passa mensagem pelo construtor
            Form3 f3 = new Form3(mensagem);
            f3.ShowDialog();


        }
    }
}
