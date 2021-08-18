using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Random random = new Random();
            int returnValue = random.Next(1, 999);
            string input;

            while (playHiLo)
            {


                Console.WriteLine(returnValue);
                Console.WriteLine("Is the next number 'higher' or 'lower'?");
                input = Console.ReadLine();
                Random newRandom = new Random();
                int newValue = newRandom.Next(1, 999);


                if (input == "higher")
                {
                    if (newValue > returnValue)
                    {
                        Console.WriteLine(newValue);
                        Console.WriteLine("You guessed right! It was higher!");
                        newValue = returnValue;
                        score++;
                    }
                    else if (newValue <= returnValue)
                    {
                        Console.WriteLine(newValue);
                        Console.WriteLine("Oh no! That was incorrect!");
                    }
                }
                else if (input == "lower")
                {
                    if (newValue < returnValue)
                    {
                        Console.WriteLine(newValue);
                        Console.WriteLine("You guessed right! It was lower!");
                        newValue = returnValue;
                        score++;
                    }
                    else if (newValue >= returnValue)
                    {
                        Console.WriteLine(newValue);
                        Console.WriteLine("Oh no! That was incorrect!");
                    }
                }
                else
                {
                    Console.WriteLine("Please input either 'higher' or 'lower'");
                }
            }
        }
    }
}