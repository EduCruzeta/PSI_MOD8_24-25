namespace Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // botão carregar imagem
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ficheiro = new OpenFileDialog();
            ficheiro.Filter = "imagens|*.png;*.jpg;*.bmp|Todos|*.*";
            // abre a janela para escolher um ficheiro e espera até fechar
            ficheiro.ShowDialog();
            // verificar se escolheu um ficheiro
            if (ficheiro.FileName == "")
            {
                return;
            }
            // carregar a imagem do ficheiro escolhido
            pictureBox1.Image = Image.FromFile(ficheiro.FileName);
        }
        // botão limpar imagem
        private void button1_Click(object sender, EventArgs e)
        {
            //limpar
            pictureBox1.Image = null;
        }
    }
}
