using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class ChessGame
    {
        IDifficultyLevel obj;
       

        public void setDifficultyLevel(IDifficultyLevel obj)
        {
            this.obj = obj;
        }

        public void makeMove()
        {
            obj.move();
        }
    }
}
