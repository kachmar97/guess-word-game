using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    public class TaskProviderImpl : TaskProvider
    {

        Task[] tasks = new Task[]
            {
                new Task("Which is the capital of Germany?", "Berlin"),
                new Task("Which is the capital of Ukraine?","Kyiv"),
                new Task("Which is the capital of Polish?","Warshava"),
                new Task("Which is the capital of Spain?","Madrid"),
                new Task("Which is the capital of Czech Republic?","Praha")
            };

        int index = 0;

        public Task Get()
        {
            if (index >= tasks.Length)
            {
                return null;
            }
            return tasks[index++];
        }
    }
}
