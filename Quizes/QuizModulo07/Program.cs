namespace QuizModulo07
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
            Question07();
        }
        static void Question01()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 01");
            Console.WriteLine("Can you instantiate objects an abstract class?");
            Console.WriteLine("R: No");
        }
        static void Question02()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 02");
            Console.WriteLine("Fill in the blanks to define a new class Falcon,");
            Console.WriteLine("which is derived from the class Bird.");
            Console.WriteLine("class Falcon : Bird {");
            Console.WriteLine("}");
        }
        static void Question03()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 03");
            Console.WriteLine("Which keyword makes class members accessible to only");
            Console.WriteLine("its derived class members?");
            Console.WriteLine("R: protected");
        }
        static void Question04()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 04");
            Console.WriteLine("Fill in the blanks to declare a Person class with");
            Console.WriteLine("a Hello abstract method, and then declare a Student");
            Console.WriteLine("class that is derived from the Person class and");
            Console.WriteLine("overrides its Hello method.");
            Console.WriteLine("abstract class Person {");
            Console.WriteLine("     public abstract void Hello();");
            Console.WriteLine("}");
            Console.WriteLine("class Student : Person {");
            Console.WriteLine("     public override void Hello() {");
            Console.WriteLine("         Console.WriteLine(\"Hello\");");
            Console.WriteLine("     }");
            Console.WriteLine("}");
        }
        static void Question05()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 05");
            Console.WriteLine("A sealed class can be marked as abstract.");
            Console.WriteLine("R: False");
        }
        static void Question06()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 06");
            Console.WriteLine("Fill in the blanks to implement the A and B");
            Console.WriteLine("interfaces.");
            Console.WriteLine("interface A {");
            Console.WriteLine("}");
            Console.WriteLine("interface B {");
            Console.WriteLine("}");
            Console.WriteLine("class Test : A, B {");
            Console.WriteLine("}");
        }
        static void Question07()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 07");
            Console.WriteLine("Can a single class inherit from multiple");
            Console.WriteLine("abstract classes?");
            Console.WriteLine("R: No");
        }
    }
}