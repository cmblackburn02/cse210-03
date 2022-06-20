using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Output
    {
        //Displays the dude
        public void DisplayJumper(List<string> jumper)
        {
            for (int i = 0; i < jumper.Count; i++)
            {
                Console.WriteLine(jumper[i]);
            }
            Console.WriteLine("   O");
            Console.WriteLine(@"  /|\");
            Console.WriteLine(@"  / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^");
        }
        public void DisplayNum(List<char> num)
        {
            for (int i = 0; i <num.Count; i++)
            {
                Console.Write(num[i]+ " ");
            }
            Console.WriteLine("\n");
        }
        public char PromptLetter()
        {
            //This reads the letter and determines if it is a letter
            char letter = 'a';
            do
            {
                Console.Write("Guess a letter [a-z]: ");
                try
                {
                    letter = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input one letter.");
                }
                if(!Char.IsLetter(letter))
                    Console.WriteLine("Not a letter.");
            } while(!Char.IsLetter(letter));
            return letter;
        }
        public void DisplayWon(List<char> num)
        {
            this.DisplayNum(num);
            Console.WriteLine("YES!!! You won!");
        }
        //This shows the dead guy when the user loses
        public void DisplayLost(String word)
        {
            Console.WriteLine("    X");
            Console.WriteLine(@"   /|\");
            Console.WriteLine(@"   / \");
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^^");
            Console.WriteLine("Good try, just not good enough. The word was "+ word);
        }
    }
}
