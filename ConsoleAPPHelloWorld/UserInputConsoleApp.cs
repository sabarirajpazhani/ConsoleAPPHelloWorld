using System;

namespace ConsoleAPPHelloWorld
{
    public  class UserInputConsoleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Sentence: ");

            string userInput = Console.ReadLine();

            Console.WriteLine($"User Entered Sentence : {userInput}");
        }
    }
}
