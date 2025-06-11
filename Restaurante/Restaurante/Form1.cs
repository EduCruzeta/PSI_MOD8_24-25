namespace Restaurante
{
    public partial class Form1 : Form
    {
        // array sobremesas
        string[] sobremesa = { "Gelado", "Bolo Bolacha", "Mosse" };
        // array Prato_vegetariano
        string[] prato_vegetariano = { "salada", "tofu" };
        // array prato
        string[] prato = { "bife", "arroz de pato" };
        // array bebidas
        string[] bebidas = { "água", "sumo" };
        public Form1()
        {
            InitializeComponent();
        }
        void PreencherListBox(ListBox listBox, string[] opcoes)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(opcoes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RB_sobremesa_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_sobremesa.Checked == true)
            {
                PreencherListBox(Lb_Ementa, sobremesa);
            }
        }

        private void RB_Prato_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Prato.Checked == true)
            {
                if (Cb_vegetariano.Checked == true)
                {
                    PreencherListBox(Lb_Ementa, prato_vegetariano);
                }
                else
                {
                    PreencherListBox(Lb_Ementa, prato);
                }
            }
        }

        private void Cb_vegetariano_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Prato.Checked == true)
            {
                if (Cb_vegetariano.Checked == true)
                {
                    PreencherListBox(Lb_Ementa, prato_vegetariano);
                }
                else
                {
                    PreencherListBox(Lb_Ementa, prato); 
                }
            }
        }

        private void RB_Bebida_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Bebida.Checked == true)
            {
                PreencherListBox(Lb_Ementa, bebidas);
            }

        }
    }
}
