using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    class GameViewImplemantation : GameView
    {
        public void Congratulate(string text)
        {
            Console.WriteLine("You won {0}", text);
        }

        public void ShowTask(Task task)
        {
            Console.WriteLine("Please answer {0}", task.question);
        }

        public void Sorry(string text)
        {
            Console.WriteLine("Sorry wrong answer {0}", text);
        }
    }
}
