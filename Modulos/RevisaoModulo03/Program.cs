namespace RevisaoModulo03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5));
            DrawPyramid(10);
        }
        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}