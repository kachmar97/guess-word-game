using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    interface GameView
    {
        void ShowTask(Task task);
        void Congratulate(string text);
        void Sorry(string text);
    }
}
