namespace Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            f_splach f = new f_splach();
            f.ShowDialog();

        }
        // evento � executado sempre que o texto for alterado
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarPalindromo()
        }
        void VerificarPalindromo()
        {
            string palavra = tb_palavra.Text.ToLower().Trim();
            string palavra_invertida = "";

            // inventar palavra
            for (int i = 0; i < palavra.Length; i++)
                palavra_invertida = palavra[i] + palavra_invertida;
            // comparar as duas palavras
            if (palavra == palavra_invertida)
                lb_resultado.Text = "� um palindromo";
            else
                lb_resultado.Text = "N�o � um palindromo";

        }
    }
}
