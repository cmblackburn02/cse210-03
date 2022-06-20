using System;

namespace cse210_03
{
    public class Director
    {
        private string word;
        // this is wherer it all begins and calls all the classes
        public void StartGame()
        {
            Puzzle puzzle = new Puzzle();
            Output output = new Output();
            Game game = new Game();
            Jumper jumper = new Jumper();

            // this grabs the word 
            word = puzzle.GetWord();
            puzzle.NumWord(word);

            while (!game.Won(puzzle.GetNum()) && !game.Lost(jumper.StillExists()))
            {
                output.DisplayNum(puzzle.GetNum());
                output.DisplayJumper(jumper.GetJumper());
                char letter = output.PromptLetter();
                if (!puzzle.UpdateNum(letter, word))
                    jumper.LosePoint();
            }
            // this asks the functions in the game class if they won or lost
            if (game.Won(puzzle.GetNum()))
                output.DisplayWon(puzzle.GetNum());
            else
                output.DisplayLost(word);
        }
    }
}
