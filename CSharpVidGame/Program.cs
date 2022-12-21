using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
            char[] threeStrikes = new char[] {'O','O','O'};
            string wordGuess;
            Console.WriteLine("( |  _  | )\n");
            Console.WriteLine("     |     \n");
            Console.WriteLine("-----|-----\n");
            Console.WriteLine("     |     \n");
            Console.WriteLine("    /-\\   \n"); 
            Console.WriteLine(threeStrikes[0] + "    " + threeStrikes[1] + "     " + threeStrikes[2]);
            wordGuess = Console.ReadLine();
            Console.Clear();
            } 
        }
    }
}