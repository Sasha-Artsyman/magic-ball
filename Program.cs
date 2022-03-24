using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ask a question and press 'Enter'");
        Console.WriteLine(" (Press key 'End' to complete)  \n");

        bool end0 = false;
        string[] answers0 = { "Yes", "No", "Probably yes", "Probably no", "Maybe" };
        
        do
        {
            Console.Write("Your question: ");
            Console.ReadLine();
            Console.WriteLine("Answer: " + answers0[new Random().Next(0, answers0.Length)]);
            
            if (Console.ReadKey(true).Key == ConsoleKey.End)
            {
                end0 = true;
            }
        }
        while (!end0);

        Console.ReadLine();
    }
}