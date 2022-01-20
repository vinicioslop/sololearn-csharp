namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program you are given defines an array with 10 words and takes a letter as input.
            // Write a program to iterate through the array and output words containing the taken letter.
            // If there is no such word, the program should output "No match".

            // Sample Input
            // u

            // Sample Output
            // fun

            // Recall the Contains() method.
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            //your code goes here
            foreach (var word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count ++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}