namespace Programa_calcular_v2
{
    public partial class Form1 : Form
    {
        // variaveis do formulario
        float maior = float.MinValue,menor = float.MaxValue, soma = 0, contar = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // botão para calcular a média , o maior e o menor
        private void bt_calcular_Click(object sender, EventArgs e)
        {
            float atual = (float)NU_numero.Value;
            contar++;
            soma += atual;
            float media = soma / contar;
            if (atual > maior)
                maior = atual;
            if (atual < menor)
                menor = atual;
            lb_resultados.Text = $"A média dos valores é de {media.ToString("f2")}.\n" + $"O maior é {maior}.\nO menor é {menor}.";
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            //botão limpar
            maior = menor = soma = contar = 0;
            lb_resultados.Text = "";
        }
    }
}
