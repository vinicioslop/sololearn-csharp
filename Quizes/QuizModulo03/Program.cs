namespace QuizModulo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc(1, 2));
            Test(x: 7, y: 11);

            // PERGUNTA 05
            int a;
            int z = Test02(out a);
            Console.WriteLine(a + z);
        }
        /*
        PERGUNTA 01
        Every C# program has the method:

        (ERRADA) Console
        (CERTA)  Main
        (ERRADA) Program
        (ERRADA) Start
        */
        /*
        PERGUNTA 02
        Fill in the blanks to create a method that calculates and
        returns the sum of its parameters.
        */
        static int Calc(int a, int b)
        {
            return a + b;
        }

        /*
        PERGUNTA 03
        Fill in the blanks to declare a method that has two int parameters
        with default values 6 and 8, respectively, and displays their
        product to the screen. Call the method in Main using named arguments.
        */
        static void Test(int x = 6, int y = 8)
        {
            Console.WriteLine(x * y);
        }
        /*
        PERGUNTA 04
        If a method does not return any value, you should use the return type:
        R: void
        */
        /*
        PERGUNTA 05
        What is the output of this code?
        */

        static int Test02(out int x, int y = 4)
        {
            x = 6;
            return x * y;
        }
    }
}