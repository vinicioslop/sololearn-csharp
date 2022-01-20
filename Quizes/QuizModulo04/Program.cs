using System;

namespace QuizModulo04
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
            Quest06();
            Quest07();
        }
        public static void Quest01()
        {
            Console.Clear();

            Console.WriteLine("QUESTION 01");
            Console.WriteLine("Objects of a class are stored on the: ");
            Console.WriteLine("1 - stack");
            Console.WriteLine("2 - heap");
            Console.WriteLine("3 - property");
            Console.WriteLine("R: heap");
        }
        public static void Quest02()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 02");
            Console.WriteLine("Fill in the blanks to instantiate an object of the class Cat, passing to the");
            Console.WriteLine("constructor the value 12. Then call the Meow method for that object:");
            Console.WriteLine("R: Cat c = new Cat(12);");
            Console.WriteLine("   c.Meow()");
        }
        public static void Quest03()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 03");
            Console.WriteLine("To make a member of a class accessible from outside the class declaration,");
            Console.WriteLine("you should declare it as:");
            Console.WriteLine("1 - public");
            Console.WriteLine("2 - void");
            Console.WriteLine("3 - private");
            Console.WriteLine("R: public");
        }
        public static void Quest04()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 04");
            Console.WriteLine("Which statement is true?");
            Console.WriteLine("1 - An object is an instance of a class.");
            Console.WriteLine("2 - An object is a member of a class.");
            Console.WriteLine("3 - An object is a method of a class.");
            Console.WriteLine("R: 1 - An object is an instance of a class.");
        }
        public static void Quest05()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 05");
            Console.WriteLine("Fill in the blanks to declare a class Student, with one public method called");
            Console.WriteLine("Hello. The Hello method displays \"hi\" to the screen.");
            Console.WriteLine("R: class Student {");
            Console.WriteLine("     public void Hello() {");
            Console.WriteLine("         Console.WriteLine(\"hi\").");
            Console.WriteLine("     }");
            Console.WriteLine("   }");
        }
        public static void Quest06()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 06");
            Console.WriteLine("Fill in the blanks to declare a constructor that has one parameter and assigns");
            Console.WriteLine("it to the age member:");
            Console.WriteLine("R: class Dog");
            Console.WriteLine("   {");
            Console.WriteLine("     private int age;");
            Console.WriteLine("     public Dog(int val)");
            Console.WriteLine("     {");
            Console.WriteLine("         age = val;");
            Console.WriteLine("     }");
            Console.WriteLine("   }");
        }
        public static void Quest07()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 07");
            Console.WriteLine("Which accessor is used to read the value of a member?");
            Console.WriteLine("1 - return");
            Console.WriteLine("2 - set");
            Console.WriteLine("3 - void");
            Console.WriteLine("4 - get");
            Console.WriteLine("R: get");
        }
    }
}