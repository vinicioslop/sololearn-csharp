namespace revisao_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentarios();
            Constantes();
            EntradadeDeDados();
            PrimeiroPrograma();
            VariavelVar();
        }
        static void Comentarios()
        {
            // Prints Hello
            // Console.WriteLine("Hello");
            /* Some long
             *  comment text
             */
            int x = 42;
            Console.WriteLine(x);
        }
        static void Constantes()
        {
            const double PI = 3.14;
            // PI = 8; - RESULTA EM ERRO
        }
        static void EntradadeDeDados()
        {
            // EXEMPLOS

            string yourName;
            Console.WriteLine("Whats is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Helo {0}", yourName);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
        static void PrimeiroPrograma()
        {
            // CÓDIGOS DE EXEMPLOS

            // Console.WriteLine("Oi pessoas");
            // int x = 89;
            // Console.WriteLine(x);
            // int x = 10;
            // double y = 20;
            // Console.WriteLine("x = {0}; y = {1}", x, y);

            // PRIMEIRO DESAFIO
            // Exibir a mensagem "C# is cool"

            Console.WriteLine("C# is cool");
        }
        static void VariavelVar()
        {
            // var num = 15;
            /*
             * var num;
             * num = 10;
             * 
             * resulta em erro porque a variavel não foi iniciada com um
             * valor válido.
             */
        }
    }
}