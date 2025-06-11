namespace Windows_ola_mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar uma variavel para o nome 
            string nome;

            // Guardar o texto da tb_nome
            nome = tb_Nome.Text;

            // Alterar a mesagem do lb_mensagem
            lb_Mensagem.Text = "Olá, " + nome;

            // alterar o buttao de limpar para o ativar
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpar o lb_mensagem
            lb_Mensagem.Text = "";

            // Limpar o tb_nome
            tb_Nome.Text = "";

            // voltar a desativar
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // funciona logo a seguir ao programa abrir antes de aparecer a interface
            tb_Nome.Text = "Joaquim";
        }
    }
}
