using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Game
    {
        //this class determines if the player won or lost
        public bool Won(List<char> blanks)
        {
            bool won = true;
            for (int i = 0; i < blanks.Count; i++)
            {
                if (blanks[i] == '_')
                    won = false;
            }
            return won;
        }
        public bool Lost(bool haveJumper)
        {
            return !haveJumper;
        }
    }
}
