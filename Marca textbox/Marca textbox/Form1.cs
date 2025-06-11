namespace Marca_textbox
{
    public partial class Form1 : Form
    {
        // array de string
        string[] marcas = { "Ford", "Mercedes", "Opel", "Renault" };
        // array vazio de 4 strings
        string[] teste = new string[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //evento é executado antes do formulatio ser mostrado ao utilizador
            // adicionar item a item
            //cbMarcas.Items.Add("Ford");
            //cbMarcas.Items.Add("Mercedes");
            // adicionar array de uma só vez
            //cbMarcas.Items.AddRange(marcas);
            // adicionar o array um de cada vez
            for (int i = 0; i < marcas.Length; i++)
            {
                cbMarcas.Items.Add(marcas[i]);
            }
            // bloquear a combobox para obrigar a escolher um da lista
            cbMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // Evento ocorre quando é escolhida uma marca
        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarcas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleciona uma marca.");
                return;
            }
            int posicao = cbMarcas.SelectedIndex;

            string marcaEscolhida = cbMarcas.Items[posicao].ToString();
            // MessageBox.Show(marcaEscolhida);
            // adicionar marca à listbox
            lbEscolhidas.Items.Add(marcaEscolhida);
            // remover a marca escolhida da combobox
            cbMarcas.Items.RemoveAt(posicao);
        }
        // butão limpar
        private void Limpar_Click(object sender, EventArgs e)
        {
            // remove todos os itens da listbox
            lbEscolhidas.Items.Clear();
            // repoe todos os itens da combobox
            cbMarcas.Items.Clear();
            cbMarcas.Items.AddRange(marcas);
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            // caso não tenha nenhum item selecionado deve mostrar um aviso
            if (lbEscolhidas.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de escolher um elemento");
                return;
            }
            // remove o item selecionado da listbox
            lbEscolhidas.Items.RemoveAt(lbEscolhidas.SelectedIndex);
        }
    }
}
