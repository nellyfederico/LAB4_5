using System;
using System.Collections.Generic;

namespace LAB4_5Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
                //List of scores.
                List<int> triviaScores = new List<int>();
                triviaScores.Add(4400);
                triviaScores.Add(8900);
                triviaScores.Add(1200);
                triviaScores.Add(3700);
                triviaScores.Add(7200);

                //Sort low to high, order and print.
                triviaScores.Sort();

                foreach (int s in triviaScores)
                {
                    Console.WriteLine(s);
                }

                //Sort high to low, order and print.
                triviaScores.Reverse();

                foreach (int s in triviaScores)
                {
                    Console.WriteLine(s);
                }


                //Adding new item.
                triviaScores.Add(2400);

                //Removing old item.
                triviaScores.Remove(4400);


            }
    }
}
