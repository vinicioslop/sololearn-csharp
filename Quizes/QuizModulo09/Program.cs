using System;

namespace QuizModulo09
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
            Question08();
            Question09();
        }
        static void Question01()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 01");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("List<int> li = new List<int>();");
            Console.WriteLine("li.Add(59);");
            Console.WriteLine("li.Add(72);");
            Console.WriteLine("li.Add(95);");
            Console.WriteLine("li.RemoveAt(1);");
            Console.WriteLine("for (int x = 0; x < li.Count; x++)");
            Console.WriteLine("    Console.Write(li[x] + \" \");");
            Console.WriteLine("R: 59 95");
        }
        static void Question02()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 02");
            Console.WriteLine("Drag and drop from the options below to define a generic method that swaps the values of its arguments and returns the value of the first argument.");
            Console.WriteLine("static T Swap <T> (ref T a, ref T b) {");
            Console.WriteLine("     T temp = a;");
            Console.WriteLine("     a = b;");
            Console.WriteLine("     b = temp;");
            Console.WriteLine("     return a;");
            Console.WriteLine("}");
        }
        static void Question03()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 03");
            Console.WriteLine("Reorder the code to declare a Queue of integers, add values 1 through 5 and print the contents of the Queue.");
            Console.WriteLine("Queue<int> q = new Queue<int>();");
            Console.WriteLine("for (int x = 1; x<= 5; x++)");
            Console.WriteLine("     q.Enqueue(x);");
            Console.WriteLine("foreach (int val in q)");
            Console.WriteLine("     Console.Write(val + \" \");");
        }
        static void Question04()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 04");
            Console.WriteLine("Drag and drop from the options below to define a generic class, which has a member method that returns the value of x.");
            Console.WriteLine("class Temp <T> {");
            Console.WriteLine("    T x;");
            Console.WriteLine("    public T Func() {");
            Console.WriteLine("        return x;");
            Console.WriteLine("    }");
            Console.WriteLine("}");
        }
        static void Question05()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 05");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("List<int> a = new List<int>();");
            Console.WriteLine("a.Add(5);");
            Console.WriteLine("a.Add(2);");
            Console.WriteLine("a.Add(8);");
            Console.WriteLine("a.Reverse();");
            Console.WriteLine("Console.Write(a[1]);");
            Console.WriteLine("R: 2");
        }
        static void Question06()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 06");
            Console.WriteLine("Drag and drop from the options below to create a List that will contain objects of type Student.");
            Console.WriteLine("List<Student> L = new List<Student>();");
        }
        static void Question07()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 07");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("BitArray ba1 = new BitArray(4);");
            Console.WriteLine("BitArray ba2 = new BitArray(4);");
            Console.WriteLine("ba1.SetAll(true);");
            Console.WriteLine("ba2.SetAll(false);");
            Console.WriteLine("ba1.Set(2, false);");
            Console.WriteLine("ba2.Set(3, true);");
            Console.WriteLine("Console.Write(ba1.And(ba2).Get(2));");
            Console.WriteLine("R: False");
        }
        static void Question08()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 08");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("Stack<int> s = new Stack<int>();");
            Console.WriteLine("s.Push(4);");
            Console.WriteLine("s.Push(5);");
            Console.WriteLine("s.Push(4);");
            Console.WriteLine("s.Pop();");
            Console.WriteLine("Console.Write(s.Peek());");
            Console.WriteLine("R: 5");
        }
        static void Question09()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 09");
            Console.WriteLine("Fill in the blanks to declare a dictionary to map names and ages and John's, Ann's and Peter's ages. Print John's age.");
            Console.WriteLine("Dictionary<string, int> d = new Dictionary<string, int>();");
            Console.WriteLine("d. Add(\"John\", 24);");
            Console.WriteLine("d.Add(\"Ann\", 18);");
            Console.WriteLine("d.Add(\"Peter\", 27)");
            Console.WriteLine("string name = \"John\";");
            Console.WriteLine("Console.Write(d[name])");
        }
    }
}