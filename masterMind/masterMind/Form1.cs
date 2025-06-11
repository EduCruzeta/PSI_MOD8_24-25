using System.Diagnostics;

namespace masterMind
{
    public partial class Form1 : Form
    {
        //variavel da classe
        int[] codigo;
        public Form1()
        {
            InitializeComponent();
            codigo = GerarCodigo();
        }
        int[] GerarCodigo()
        {
            int[] numeros = new int[4];
            Random sortear = new Random();

            for (int i = 0; i < 4; i++) 
            {
                // sortear um n�mero entre 0 e 9
                int n = sortear.Next(0,10);
                if (numeros.Contains(n))
                {
                    i -= 1;
                    continue;
                }
                numeros[i] = n;
            }

            return numeros;
        }
        // recebe o codigo e a tentativa e devolve o feedback
        // cccc - significa que acertou nos n� todos
        string Testar(int[] codigo,string tentativa)
        {
            string resposta = "";

            for (int p = 0; p < 4; p++)
            {
                string letra = "";
                //est� certo no local certo
                if (tentativa[p].ToString() == codigo[p].ToString())
                {
                    letra = "C";
                }
                //verificar se existe noutra posi��o
                for (int i = 0; letra =="" && i < 4; i++) 
                {
                    if (codigo[i].ToString() == tentativa[p].ToString())
                    {
                        letra = "E";
                        break;
                    }
                }
                if (letra == "")
                    letra = "X";

                //n�o existe no c�digo
                resposta += letra;
            }
            return resposta;
        }

        // bt para testar a combina��o
        private void button1_Click(object sender, EventArgs e)
        {
            //Retirar da tb a tentativa
            string tentativa = textBox1.Text;
            if (tentativa.Length != 4)
            {
                MessageBox.Show("Tem de indicar quatro n�meros para o c�digo secreto.");
                return;
            }
            // verificar se a tentativa tem n�meros repetidos
            for (int i = 0; i < 4; i++)
            {
                if (tentativa.IndexOf(tentativa[i]) != tentativa.LastIndexOf(tentativa[i]))
                {
                    MessageBox.Show("O c�digo n�o tem n�meros repetidos.");
                        return;
                }
            }
            // verificar
            string feedback = Testar(codigo, tentativa);
            // se ganhou mostrar uma mensagebox a perguntar se quer jogar novamente
            if (feedback == "CCCC")
            {
                //acertou o codigo
                DialogResult resposta = MessageBox.Show("Acertou no c�digo secreto. Deseja jogar novamente?", "Game Over", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    codigo = GerarCodigo();
                    TB_tentativas.Items.Clear();
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
            }
            //mostrar o feedback
            string linha = tentativa + " | " + feedback;
            //adicionar a listbox
            TB_tentativas.Items.Add(linha);
        }
    }
}
