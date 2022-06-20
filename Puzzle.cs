using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Puzzle
    {
        //This list stores all the word values
        private List<string> Getwords = new List<string>{};
        private List<char> num = new List<char>();

        public Puzzle()
        {
            this.Getwords.Add("thanks");
            this.Getwords.Add("area");
            this.Getwords.Add("memory");
            this.Getwords.Add("relation");
            this.Getwords.Add("interaction");
            this.Getwords.Add("speaker");
            this.Getwords.Add("committee");
            this.Getwords.Add("instruction");
            this.Getwords.Add("goal");
            this.Getwords.Add("environmetn");
            this.Getwords.Add("economics");
            this.Getwords.Add("measurement");
            this.Getwords.Add("library");
            this.Getwords.Add("investment");
            this.Getwords.Add("resolution");
            this.Getwords.Add("communication");
            this.Getwords.Add("politics");
            this.Getwords.Add("bathroom");
            this.Getwords.Add("performance");
            this.Getwords.Add("statement");
            this.Getwords.Add("setting");
            this.Getwords.Add("failure");
            this.Getwords.Add("imagination");
            this.Getwords.Add("dealer");
            this.Getwords.Add("addition");
            this.Getwords.Add("kind");
            this.Getwords.Add("patience");
            this.Getwords.Add("membership");
            this.Getwords.Add("weakness");
            this.Getwords.Add("cookie");
            this.Getwords.Add("judgment");
            this.Getwords.Add("preference");
            this.Getwords.Add("road");
            this.Getwords.Add("accident");
            this.Getwords.Add("recording");
            this.Getwords.Add("recommendation");
        }
        //recieves the word
        public string GetWord()
        {
            Random random = new Random();
            int randomNumber = random.Next(this.Getwords.Count);
            return this.Getwords[randomNumber];
        }
        //determines how many blanks we need
        public void NumWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                num.Add('_');
            }
        }
        public List<char> GetNum()
        {
            return num;
        }
        public bool UpdateNum(char letter, string word)
        {
            bool updated = false;
            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    num[i] = letter;
                    updated = true;
                }
            }
            return updated;
        }
    }
}
