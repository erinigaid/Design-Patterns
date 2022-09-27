using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {

            ChessGame g = new ChessGame();
            
            g.setDifficultyLevel(new Extreme());

            g.makeMove();
        }
    }
}
