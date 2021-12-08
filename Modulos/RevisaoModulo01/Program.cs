namespace RevisaoModulo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentarios();
            // Constantes();
            // EntradadeDeDados();
            // PrimeiroPrograma();
            // VariavelVar();

            OperadoresDeAtribuicao();
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
        static void OperadoresDeAtribuicao()
        {
            int x = 42;
            // EQUIVALENTE A X = X + 2
            x += 2;
            Console.WriteLine(x);
            // EQUIVALENTE A X = X - 6
            x -= 6;
            Console.WriteLine(x);
            // EQUIVALENTE A X = X * 8
            x *= 8;
            Console.WriteLine(x);
            // EQUIVALENTE A X = X / 5
            x /= 5;
            Console.WriteLine(x);
            // EQUIVALENTE A X = X % 2
            x %= 2;
            Console.WriteLine(x);
            // EQUIVALENTE A X = X + 1
            x++;
            Console.WriteLine(x);
            // SOMA 1 A X ANTES DA EXPRESSÃO
            ++x;
            Console.WriteLine(x);
            // SOMA 1 A X DEPOIS DA EXPRESSÃO
            x++;
            Console.WriteLine(x);
            // SUBTRAI 1 A X ANTES DA EXPRESSÃO
            --x;
            Console.WriteLine(x);
            // SUBTRAI 1 A X DEPOIS DA EXPRESSÃO
            x--;
            Console.WriteLine(x);

            // EXEMPLO
            x = 3;
            int y = ++x;
            // X = 4 e Y = 4;
            Console.WriteLine($"X = {x} e Y = {y}");

            x = 3;
            y = x++;
            // X = 4 e Y = 3;
            Console.WriteLine($"X = {x} e Y = {y}");
        }
    }
}