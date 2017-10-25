using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        private static Random rnd = new Random();

        public void Guess()
        {
            int n = rnd.Next(1, 10);
            int l = 11;
            int k = 0;
            do
            {
                k++;
                Console.Write("Write your number: ");
                string m = Console.ReadLine();
                if (m.Contains('1') || m.Contains('2') || m.Contains('3') || m.Contains('4') || m.Contains('5') || m.Contains('6') || m.Contains('7') || m.Contains('8') || m.Contains('9') || m.Contains('0'))
                {
                    l = Convert.ToInt32(m);
                    if (l == n)
                    {
                        Console.Clear();
                        Console.WriteLine("Gratulations!!!");
                        Console.WriteLine("You are guess the number");
                    }
                    if (l < n)
                        Console.WriteLine("Your number is smaller conceived number");
                    if (l > n)
                        Console.WriteLine("Your nnumber is bigger conceived number");
                }
                else
                    Console.WriteLine("bad choise");
            } while (l != n);
            Console.Write("You guessed after {0} Attempt", k);
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Guess();
            Console.ReadKey();
        }
    }
}
