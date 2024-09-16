using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class tesst
    {
        static void Main(string[] args)
        {
            Questions question1 = new Questions(Quizzes[0], "C");
            Questions question2 = new Questions(Quizzes[1], "B");
            Questions question3 = new Questions(Quizzes[2], "B");
            Questions question4 = new Questions(Quizzes[3], "D");
            Questions question5 = new Questions(Quizzes[4], "D");
            Questions question6 = new Questions(Quizzes[5], "D");
            Questions question7 = new Questions(Quizzes[6], "D");
            Questions question8 = new Questions(Quizzes[7], "D");
            Questions question9 = new Questions(Quizzes[8], "D");
            Questions question10 = new Questions(Quizzes[9], "A");
            Questions question11 = new Questions(Quizzes[10], "B");
            Questions question12 = new Questions(Quizzes[11], "D");
            Questions question13 = new Questions(Quizzes[12], "C");
            Questions question14 = new Questions(Quizzes[13], "D");
            Questions question15 = new Questions(Quizzes[14], "D");

            DateTime time = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(time);
            int x = 0;

            while (true)
            {
                x += 1;
                
                



                while ((DateTime.Now - time).Milliseconds < 10)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey(true).Key;
                        Console.WriteLine(key);
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
