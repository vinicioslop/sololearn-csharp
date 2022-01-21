using System;

namespace QuizModulo08
{
    class Program
    {
        static void Main(string[] args)
        {
            Question01();
            Question02();
            Question03();
            Question04();
            Question05();
            Question06();
        }
        static void Question01()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 01");
            Console.WriteLine("Can you inherit from a struct?");
            Console.WriteLine("R: No");
        }
        static void Question02()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 02");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("enum Test { A, B, C=5, D };");
            Console.WriteLine("static void Main(string[] args) {");
            Console.WriteLine("int x = (int)Test.D;");
            Console.WriteLine("Console.WriteLine(x);");
            Console.WriteLine("R: 6");
        }
        static void Question03()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 03");
            Console.WriteLine("int is a Struct");
            Console.WriteLine("R: True");
        }
        static void Question04()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 04");
            Console.WriteLine("Which of the following is the correct");
            Console.WriteLine("way to define a variable of the struct");
            Console.WriteLine("Person declared below?");
            Console.WriteLine("struct Person {");
            Console.WriteLine("     private string name;");
            Console.WriteLine("     private int age; ");
            Console.WriteLine("}");
            Console.WriteLine("R: Person p;");
        }
        static void Question05()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 05");
            Console.WriteLine("What is the value of x after this code?");
            Console.WriteLine("int x = 0;");
            Console.WriteLine("try {");
            Console.WriteLine("     x /= x;");
            Console.WriteLine("     x += 1;");
            Console.WriteLine("}");
            Console.WriteLine("catch (Exception e) {");
            Console.WriteLine("     x += 3;");
            Console.WriteLine("}");
            Console.WriteLine("finally {");
            Console.WriteLine("     x += 4;");
            Console.WriteLine("}");
            Console.WriteLine("R: 7");
        }
        static void Question06()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 06");
            Console.WriteLine("Fill in the blanks to handle exceptions.");
            Console.WriteLine("int x = 0;");
            Console.WriteLine("try {");
            Console.WriteLine("     x = Convert.ToInt32(\"AAA\")");
            Console.WriteLine("}");
            Console.WriteLine("catch (Exception e) {");
            Console.WriteLine("     Console.WriteLine(\"Error\")");
            Console.WriteLine("}");
        }
    }
}