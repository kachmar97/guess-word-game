using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guess_A_Word
{
    class Program
    {
        static int k;

        static void ask(Task t)
        {
            Console.WriteLine("Питання : {0}", t.question);
            string n = Console.ReadLine();
            Console.WriteLine();

            if (n == t.answer)
            {
                Console.WriteLine("You win");
                k += 100;
                Console.WriteLine(k);
            }
            else
                Console.WriteLine("You lose");
        }



        static void Main(string[] args)
        {
            var tp = new TaskProviderImpl();
            while (true) {
                var t = tp.Get();
                if (t == null) break;
                ask(t);
            }
            Console.ReadKey();
        }
    }
}
