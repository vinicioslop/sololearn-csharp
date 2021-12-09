namespace RevisaoModulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema01();
            // Pratica01();
            // Pratica02();
            Pratica03();
        }
        // PROBLEMAS
        static void Problema01()
        {
            int a = 8;
            int b = ++a;

            if (a > 5) b -= 3;

            else b = 9;

            Console.WriteLine(b);
        }
        static void Problema02()
        {
            int x = 1;

            while (x++ < 5)
            {
                if (x % 2 == 0)
                {
                    x += 2;
                }
            }
        }
        static void Problema03()
        {
            int x = 1;

            for (; x < 7;)
            {
                x += 2;
            }
        }
        static void Problema04()
        {
            int a = 2;

            do
            {
                a += 3;
            } while (a < 4);
            Console.WriteLine(a);
        }
        static void Problema05()
        {
            for (int x = 1; x < 8; x++)
            {
                if (x > 5)
                    break;
                Console.WriteLine(x);
            }
        }
        static void Problema06()
        {
            int x = 5; int y = 12;

            if (x > 10 || y / x > 10)
                Console.WriteLine(y - x);
            else
                Console.WriteLine(y);
        }
        static void Problema07()
        {
            int x = 5;
            int y = 3;

            x = (x > y) ? y : x;
        }
        // PRATICA
        static void Pratica01()
        {
            /*
            The if Statement

            A restaurant provides a 15% discount if the bill exceeds 1500․
            Write a program to take the bill total as input and output the discount amount.
 
            Sample Input
            2700
 
            Sample Output
            405

            Hint
            405 is the discount for a 2700 bill (0.15*2700).

            The program should output nothing if the bill total is less than or equal to 1500.
            */

            //taking the bill as input
            int bill = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            if (bill > 1500)
            {
                Console.WriteLine((double)bill * 0.15);
            }
            else
            {
                Console.WriteLine();
            }
        }
        static void Pratica02()
        {
            /*
            The else Clause

            You are creating a mobile payment application.
            Write a program to take a user payment and outstanding balance as input.
            If the balance is greater or equal to payment, the program should output
            "Completed", otherwise the program should output "Insufficient funds".

            Sample Input
            1570
            14368.12

            Sample Output
            Completed

            The else block executes when the condition in the if statement evaluates
            to false.
            */

            double payment = Convert.ToDouble(Console.ReadLine());
            double balance = Convert.ToDouble(Console.ReadLine());

            //your code goes here
            if (balance >= payment)
            {
                Console.WriteLine("Completed");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
        static void Pratica03()
        {
            /*
            The default Case

            You are making a game, where the player selects the difficulty level:
            1 - Easy
            2 - Medium
            3 - Hard

            You are given a program that takes the number as input.
            Complete the program so that it will output the corresponding difficulty level.
            If the user entered an invalid number, the program should output "Invalid option".

            Sample Input
            2

            Sample Output
            Medium
            
            Use the default case to execute the invalid option message.
            */

            int num = Convert.ToInt32(Console.ReadLine());

            /*
            1 - Easy
            2 - Medium
            3 - Hard
            other - "Invalid option"
            */

            //your code goes here
            switch (num)
            {
                case 1:
                    Console.WriteLine("Easy");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 3:
                    Console.WriteLine("Hard");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}