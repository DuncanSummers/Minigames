using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriceIsRight
{
    public class HiLoGame
    {
        public static void HiLo()
        {
            bool playHiLo;
            playHiLo = true;
            int score = 0;

            
            while (playHiLo)
            {
                Random random = new Random();
                int returnValue = random.Next(1, 999);
                string input;
                Console.WriteLine("\n\tPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine();
                Console.Write($"\t{returnValue} :");
                Console.Write("\tIs the next number 'higher' or 'lower'?");
                Console.Write("\n\t");
                input = Console.ReadLine();
                Random newRandom = new Random();
                int newValue = newRandom.Next(1, 999);


                if (input == "higher")
                {
                    if (newValue > returnValue)
                    {
                        Console.Write($"\t{newValue}: ");
                        Console.Write("You guessed right! It was higher!");
                        newValue = returnValue;
                        score++;
                    }
                    else if (newValue <= returnValue)
                    {
                        Console.Write($"\t{newValue}: ");
                        Console.Write("Oh no! That was incorrect!");
                        Console.WriteLine($"\tSCORE: {score}");
                        Thread.Sleep(7000);
                        Console.Clear();
                        playHiLo = false;
                    }
                }
                else if (input == "lower")
                {
                    if (newValue < returnValue)
                    {
                        Console.Write($"\t{newValue}: ");
                        Console.Write("You guessed right! It was lower!");
                        newValue = returnValue;
                        score++;
                    }
                    else if (newValue >= returnValue)
                    {
                        Console.Write($"\t{newValue}: ");
                        Console.Write("Oh no! That was incorrect!");
                        Console.WriteLine($"\tSCORE: {score}");
                        Thread.Sleep(7000);
                        Console.Clear();
                        playHiLo = false;
                    }
                }
                else
                {
                    Console.WriteLine("\tPlease input either 'higher' or 'lower'");
                }
            }
        }
    }
}