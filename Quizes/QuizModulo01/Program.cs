namespace QuizModulo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Quest01();
            Quest02();
            Quest03();
            Quest04();
            Quest05();
        }
        static void Quest01()
        {
            string msg = "Hello";
            Console.WriteLine(msg);
        }
        static void Quest02()
        {
            int x = (4 + 3) * 2;
            Console.WriteLine(x);
        }
        static void Quest03()
        {
            int a = 4;
            int b = 6;
            b = a++;
            Console.WriteLine(++b);
        }
        static void Quest04()
        {
            int x = 8;
            int y = 15;
            Console.WriteLine(x + y);
        }
        static void Quest05()
        {
            int x = 15;
            int y = 6;
            x %= y;
            Console.WriteLine(x);
        }
    }
}