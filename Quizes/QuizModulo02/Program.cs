namespace QuizModulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pergunta01();
            // Pergunta02();
            // Pergunta03();
            // Pergunta04();
            Pergunta05();
        }
        static void Pergunta01()
        {
            // Fill in the blancks to print the value of
            // x five times.
            
            int x = 42;
            int num = 0;

            while (num < 5)
            {
                Console.WriteLine(x);
                num++;
            }
        }
        static void Pergunta02()
        {
            // Drag and drop from the options below to
            // create a valid finite for loop.
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }
        }
        static void Pergunta03()
        {
            /*
            Select the correct statements about && and || operators

            (CERTA)  (a && b) || c is true if c is true
            (CERTA)  a || b is true if either a or b is true
            (ERRADA) a && b is true if either a or b is true
            (ERRADA) a && b is false if both a and b are true
            */
        }
        static void Pergunta04()
        {
            // Fill in the blanks to calculate the sum of all
            // whole numbers from 1 to 100.
            
            int sum = 0;

            for (int x = 1; x <= 100; x++)
            {
                sum += x;
            }

            Console.WriteLine(sum);
        }
        static void Pergunta05()
        {
            // What is the value of x after this code?
            
            int x = 4; int y = 9;

            x = (y % x != 0) ? y / x : y;

            // x = 2
        }
    }
}