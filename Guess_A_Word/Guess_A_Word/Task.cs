using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    public class Task
    {
        public string question;
        public string answer;

        public Task(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
