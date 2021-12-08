namespace entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXEMPLOS

            // string yourName;
            // Console.WriteLine("Whats is your name?");
            // yourName = Console.ReadLine();
            // Console.WriteLine("Helo {0}", yourName);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
    }
}