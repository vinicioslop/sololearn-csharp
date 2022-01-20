namespace QuizModulo05
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public void Question01()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 01");
            Console.WriteLine("Fill in the blanks to declare a destructor dor the class Book.");
            Console.WriteLine("class Book {");
            Console.WriteLine("     ~Book() {");
            Console.WriteLine("         //some code");
            Console.WriteLine("     }");
            Console.WriteLine("}");
        }
        public void Question02()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 02");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("class Temp {");
            Console.WriteLine("     public int num = 2;");
            Console.WriteLine("     public Temp() { num++;}");
            Console.WriteLine("     ~Temp() { num++; }");
            Console.WriteLine("}");
            Console.WriteLine("static void Main(string[] args)");
            Console.WriteLine("{");
            Console.WriteLine("    Temp t = new Temp();");
            Console.WriteLine("    Console.WriteLine(t.num);");
            Console.WriteLine("}");
            Console.WriteLine("R: 3");
        }
        public void Question03()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 03");
            Console.WriteLine("Fill in the blanks to make a valid working program.");
            Console.WriteLine("static void Func() {");
            Console.WriteLine("     Console.Write(\"Hi there\")");
            Console.WriteLine("}");
            Console.WriteLine("static void Main(string[] args) {");
            Console.WriteLine("     Func();");
            Console.WriteLine("}");
        }
        public void Question04()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 4");
            Console.WriteLine("What is the value of x after this code?");
            Console.WriteLine("int[] arr = {8, 5, 4};");
            Console.WriteLine("Array.Reverse(arr);");
            Console.WriteLine("double x = Math.Pow(arr[0], 2);");
            Console.WriteLine("R: 16");
        }
        public void Question05()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 5");
            Console.WriteLine("public int this [int index] {");
            Console.WriteLine("     get {");
            Console.WriteLine("         return n[index];");
            Console.WriteLine("     }");
            Console.WriteLine("     set {");
            Console.WriteLine("         n[index] = value;");
            Console.WriteLine("     }");
            Console.WriteLine("}");
        }
        public void Question06()
        {
            Console.WriteLine();

            Console.WriteLine("QUESTION 06");
            Console.WriteLine("Fill in the blanks to overload the minus operator for the T class:");
            Console.WriteLine("public static T operator-(T a, T b) {");
            Console.WriteLine("     T res = new T(a.num - b.num)");
            Console.WriteLine("     return res;");
            Console.WriteLine("}");
        }
    }
}