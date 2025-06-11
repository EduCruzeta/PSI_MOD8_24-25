namespace strings
{
    public partial class Form1 : Form
    {
        string[] palavras = new string[10];
        int contar = 0;
        public Form1()
        {
            InitializeComponent();
            f_splach f = new f_splach();

            f.ShowDialog();
        }

        int MaiorPalavra(string[] palavras)
        {
            int maior = 0;

            //TODO: completar

            return maior;
        }

        int Maisvogais(string[] palavras) 
        { 

        }

    }
}
