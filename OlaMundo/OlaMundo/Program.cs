internal class Program
{
    private static void Main(string[] args)
    {
        //Variaveis();
        //LerDados();
        //OperadoresLogicos();
        Ciclos();
        Console.WriteLine(Soma(10, 20));
    }
    /// <summary>
    /// Função para somar dois números
    /// </summary>
    /// <param name="x">Primeiro nº a somar</param>
    /// <param name="y">Segundo nº a somar</param>
    /// <returns>Um inteiro com resultado da soma</returns>
    static int Soma(int x, int y)
    {
        return x + y;    
    }
    private static void Ciclos()
    {
        int i = 0;
        // Precorrer nº inteiros de 0 < 9
        for (i=0;i<10;i++)
        {
            Console.WriteLine(i);
        }
        // Precorrer nº inteiros de 9 a 0
        for (i = 9; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        ////////////////////////////////////
        //ciclo while
        i = 0;
        while(i<10)
        {
            Console.WriteLine(i);
            i++;
        }
        //////////foreach
        ///
        string texto = "Olá mundo";
        for ( i = 0; i < texto.Length; i++)
        {
            Console.WriteLine(texto[i]);
        }
        foreach (char c in texto)
        {
            Console.WriteLine(c);
        }
    }
    static void OperadoresLogicos()
    {
        int x = 10, y = 5;
        // mostrar mensagem se dois nº são maiores que 0
        // operador logico E
        if (x > 0 && y > 0)
            Console.WriteLine("São os dois maiores que zero");
        // operador lõgico OU
        if (x > 0 || y > 0)
            Console.WriteLine("Um dos dois é maior que zero");
     
    }
    static void LerDados()
    {
        string? texto;
        texto = Console.ReadLine();
        int numero;
        numero = Convert.ToInt32(texto);
        Console.WriteLine(numero);
    }
    public static void Variaveis()
    { 
        // comentario de 1 linha
        /*
         * comentario com varias linhas
         */

        Console.WriteLine("Hello, World!");
        // Variáveis
        bool verdadeiro_falso = true;
        int inteiros = 10;
        double mais_casas_deciamis = 10.4;
        float menos_casas_decimais = 10.4f;
        char uma_letra = 'a';
        String um_nome = "Joaquim";
        var o_que_e_isto = 10.5;

        if (verdadeiro_falso == true)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }

    }
}