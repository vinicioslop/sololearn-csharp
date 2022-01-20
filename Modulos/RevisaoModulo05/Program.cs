namespace RevisaoModulo05
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public void Question01()
        {
            Console.WriteLine();

            Console.WriteLine("Question 01");
            Console.WriteLine("An array is a:");
            Console.WriteLine("1 - none of these");
            Console.WriteLine("2 - reference type");
            Console.WriteLine("3 - value type");
            Console.WriteLine("R: 2 - reference type");
        }
        public void Question02()
        {
            Console.WriteLine();

            Console.WriteLine("Question 02");
            Console.WriteLine("Fill in the blanks to print all elements of the array");
            Console.WriteLine("R: int[] arr = {0, 5, 3, 2, 1};");
            Console.WriteLine("   foreach (int item in arr) {");
            Console.WriteLine("     Console.WriteLine(item);");
            Console.WriteLine("   }");
        }
        public void Question03()
        {
            Console.WriteLine();

            Console.WriteLine("Question 03");
            Console.WriteLine("What is the output of this code?");
            Console.WriteLine("string s = \"SoloLearn\";");
            Console.WriteLine("Console.WriteLine(s[6]);");
            Console.WriteLine("R: a");
        }
        public void Question04()
        {
            Console.WriteLine();

            Console.WriteLine("Question 04");
            Console.WriteLine("How many elements can the following array store?");
            Console.WriteLine("int[,,] array = new int[4,5,3];");
            Console.WriteLine("R: 60");
        }
        public void Question05()
        {
            Console.WriteLine();

            Console.WriteLine("Question 05");
            Console.WriteLine("What is the output of this code ?");
            Console.WriteLine("string s = \"SoloLearn\";");
            Console.WriteLine("int x = s.Length; RETURNS 9");
            Console.WriteLine("int y = s.IndexOf(\"e\"); RETURNS 5");
            Console.WriteLine("Console.Write(x % y); \\ 9 mod 5 outputs 4");
            Console.WriteLine("R: 4");
        }
    }
}