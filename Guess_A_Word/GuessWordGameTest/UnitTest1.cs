using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guess_A_Word;

namespace GuessWordGameTest
{
    [TestClass]
    public class TaskProviderTest
    {
        [TestMethod]
        public void GetReturnsTask()
        {
            TaskProvider tp = new TaskProviderImpl();
            var task = tp.Get();

            Assert.IsNotNull(task);
            Assert.IsNotNull(task.question);
            Assert.IsNotNull(task.answer);
        }
    }
}
