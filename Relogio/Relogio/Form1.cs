namespace Relogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // atualizar a label do relogio

        void AtualizarRelogio()
        {
            DateTime agora = DateTime.Now;

            lb_relogio.Text = agora.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarRelogio();
        }
    }
}
