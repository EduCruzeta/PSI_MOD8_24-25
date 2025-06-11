namespace Calcular_idade
{
    public partial class Form1 : Form
    {
        // contrutor do formulario
        public Form1()
        {
            InitializeComponent();
            // defenir como data maxima a data atual
            dt_dataNasce.MaxDate = DateTime.Now;
        }
        // sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // terminar a aplicação
            Application.Exit();
        }
        //sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir o formulario sobre
            f_sobre form = new f_sobre();
            form.ShowDialog();
        }
        // calcular idade
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datatual = DateTime.Now;
            DateTime dataNascimento = dt_dataNasce.Value;

            // calcular a diferença entre a data atual e a data de nascimento
            TimeSpan tempo = datatual.Date - dataNascimento.Date;

            lb_resultado.Text = ((int)(tempo.TotalDays / 365)).ToString();

            // verificar se o ano é bixesto
            if (DateTime.IsLeapYear(dataNascimento.Year))
            {
                lb_resultado.Text += " anos. \nNasceu num ano bissexto.";
            }
            else
            {
                lb_resultado.Text += " anos. \nNasceu num ano regular.";
            }
        }
    }
}
