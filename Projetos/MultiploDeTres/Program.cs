namespace MultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            You are an elementary school teacher and explaining multiplication to students.
            You are going to use multiplication by 3 as your example.
            The program you are given takes N number as input. Write a program to output all
            numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

            Sample Input
            7

            Sample Output
            12*45*7
            The N number is a multiple of 3 if N%3==0.
            */

            int number = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            string result = "";

            for (int i = 1; i <= number; i++)
            {
                if (i%3==0)
                {
                    result += "*";
                }
                else
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}