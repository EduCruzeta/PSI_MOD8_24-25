namespace Programa_Media_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(tb_1numero.Text);
            int numero2 = Convert.ToInt32(tb_2numero.Text);
            int numero3 = Convert.ToInt32(tb_3numero.Text);
            int numero4 = Convert.ToInt32(tb_4numero.Text);

            int maior = 0;
            int menor = 0;
            float media = 0;

            //media
            media = (numero1 + numero2 + numero3 + numero4) / 4;

            //maior
            if (numero1 > numero2)
            {
                maior = numero1;
            }
            else
            {
                maior = numero2;
            }

            if (maior < numero3)
            {
                maior = numero3;
            }

            if (maior < numero4)
            {
                maior = numero4;
            }
            //menor
            if (numero1 < numero2)
            {
                menor = numero1;
            }
            else
            {
                menor = numero2;
            }

            if (menor > numero3)
            {
                menor = numero3;
            }

            if (menor > numero4)
            {
                menor = numero4;
            }

            // mostrar resultado
            lb_resultado.Text = $"A média dos valores é de {media}.\n" + $"O maior é {maior}.\nO menor é {menor}.";

        }
    }       
}
