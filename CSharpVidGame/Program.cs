using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int chances = 3;
            char[] wordTest = new char[] {'T','e','s','t','s'};
            char[] underlineFill = new char[] {'_','_','_','_','_'};
            char[] threeStrikes = new char[] {'O','O','O'};
            while(!underlineFill.SequenceEqual(wordTest) && chances != 0) {
            char letterGuess;
            Console.WriteLine("( |  _  | )\n");
            Console.WriteLine("     |     \n");
            Console.WriteLine("-----|-----\n");
            Console.WriteLine("     |     \n");
            Console.WriteLine("    /-\\   \n"); 
            Console.WriteLine(threeStrikes[0] + "    " + threeStrikes[1] + "     " + threeStrikes[2]);
            Console.WriteLine(underlineFill);
            letterGuess = Console.ReadLine()[0];
            Console.Clear();
            if(wordTest.Contains(letterGuess)) {
                for(int i = 0;i != wordTest.Length;i++) {
                    if(wordTest[i] == letterGuess) {
                        underlineFill[i] = letterGuess;
                    }
                }
            }
            else{
                --chances;
                threeStrikes[chances] = 'X';
            }
            } 
            if(chances == 0) {
                Console.WriteLine("You didn't get it!\n");
            }
            else{Console.WriteLine("You got it!\n");}
        }
    }
}