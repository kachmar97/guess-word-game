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
                Console.Write("Введiть число: ");
                string m = Console.ReadLine();
                int mInt;
                var res  = Int32.TryParse(m, out mInt);
                if (res)
                {
                    l = Convert.ToInt32(m);
                    if (l == n)
                    {
                        Console.Clear();
                        Console.WriteLine("Вiтаємо!!!");
                        Console.WriteLine("Ви вгадали число");
                    }
                    if (l < n)
                        Console.WriteLine("Ваше число менше нiж загадане");
                    if (l > n)

                        Console.WriteLine("Ваше число бiльше нiж загадане");
                }
                else
                    Console.WriteLine("Поганий вибiр");
            } while (l != n);
            Console.Write("Ви вгадали пiсля {0} спроби", k);
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Guess();
            Console.ReadKey();
        }
    }
}