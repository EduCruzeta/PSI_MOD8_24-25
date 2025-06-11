using System.CodeDom;

namespace Calcular_nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // guardar os dados do windows form
                string nome = tb_nome.Text;
                int teste = Convert.ToInt32(tb_teste.Text);
                int desafio = Convert.ToInt32(tb_desafio.Text);
                int projeto = Convert.ToInt32(tb_projeto.Text);
                // validação
                if (teste < 0 || teste > 20)
                {
                    MessageBox.Show("A nota do teste não é valida. Deve ser um valor entre 0 e 20");
                    return;
                }
                // calcular a nota
                float notafinal;
                notafinal = (float)((teste * 0.3) + (desafio * 0.3) + (projeto * 0.4));
                // mostrar o resultado
                lb_mensagem.Text = $"{nome} a tua nota final é {notafinal}";
                if (notafinal >= 10)
                {
                    lb_mensagem.Text += "\nTens positiva";
                    lb_mensagem.ForeColor = Color.Green;
                }
                else
                {
                    lb_mensagem.Text += "\nTens Negativa";
                    lb_mensagem.ForeColor = Color.Red;
                }
            }catch (Exception erro) // se ocorrer um erro dentro do try entra aqui
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
