using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriceIsRight
{
    public class DangerPriceGame
    {
        public static void DangerPrice()
        {
            bool playDangerPrice;
            playDangerPrice = true;

            while (playDangerPrice)
            {
                Console.WriteLine("Welcome to DANGER PRICE! Choose the three prizes that don't match the Danger Price and you win them all!");
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Today's Prizes:\n" +
                    "1. Black Diamond IPhone\n" +
                    "2. Manhattan Parking Space\n" +
                    "3. Rolls-Royce Sweptail\n" +
                    "4. One microgram of Anti-matter\n\n" +
                    "Danger Price: $15,300,000");
                Console.WriteLine("Which item is NOT worth the Danger Price? (1,2,3,or 4)");
                string input;
                input = Console.ReadLine();

                if (input == "2") 
                {
                    Console.WriteLine("Nice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                    Console.WriteLine("Which item is NOT worth the Danger Price? (1, 3, or 4?)");
                    input = Console.ReadLine();
                    if (input == "3") 
                    {
                        Console.WriteLine("Fantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                        Console.WriteLine("Which item is NOT worth the Danger Price? (1 or 4?)");
                        input = Console.ReadLine();
                        if (input == "4")
                        {
                            Console.WriteLine("Great guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                            Console.WriteLine("Congrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(7000);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("Great guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                        Console.WriteLine("Which item is NOT worth the Danger Price? (1 or 3?)");
                        input = Console.ReadLine();
                        if (input == "3")
                        {
                            Console.WriteLine("Fantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                            Console.WriteLine("Congrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n\n This'll be our final show...");
                            Thread.Sleep(7000);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                        Console.WriteLine("Thanks for playing!");
                        Thread.Sleep(5000);
                        playDangerPrice = false;
                    }
                    else
                    {
                        Console.WriteLine("Oh no! Wrong answer!");
                        Thread.Sleep(2500);
                        playDangerPrice = false;
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Fantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                    Console.WriteLine("Which item is NOT worth the Danger Price? (1, 2, or 4?)");
                    input = Console.ReadLine();
                    if (input == "2")
                    {
                        Console.WriteLine("Nice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                        Console.WriteLine("Which item is NOT worth the Danger Price? (1 or 4?)");
                        input = Console.ReadLine();
                        if (input == "4")
                        {
                            Console.WriteLine("Great guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                            Console.WriteLine("Congrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(7000);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("Great guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                        Console.WriteLine("Which item is NOT worth the Danger Price? (1 or 2?)");
                        input = Console.ReadLine();
                        if (input == "2")
                        {
                            Console.WriteLine("Nice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                            Console.WriteLine("Congrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(7000);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                        Console.WriteLine("Thanks for playing!");
                        Thread.Sleep(5000);
                        playDangerPrice = false;
                    }
                    else
                    {
                        Console.WriteLine("Oh no! Wrong answer!");
                        Thread.Sleep(2500);
                        playDangerPrice = false;
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Great guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                    Console.WriteLine("Which item is NOT worth the Danger Price? (1, 2, or 3?)");
                    input = Console.ReadLine();
                    if (input == "2")
                    {
                        Console.WriteLine("Nice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                        Console.WriteLine("Which item is NOT worth the Danger Price? (1 or 3?)");
                        input = Console.ReadLine();
                        if (input == "3")
                        {
                            Console.WriteLine("Fantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                            Console.WriteLine("Congrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(7000);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("Fantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                        Console.WriteLine("Which item is NOT worth the Danger Price? (1 or 2?)");
                        input = Console.ReadLine();
                        if (input == "2")
                        {
                            Console.WriteLine("Nice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                            Console.WriteLine("Congrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(7000);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("Oh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                        Console.WriteLine("Thanks for playing!");
                        Thread.Sleep(5000);
                        playDangerPrice = false;
                    }
                    else
                    {
                        Console.WriteLine("Oh no! Wrong answer!");
                        Thread.Sleep(2500);
                        playDangerPrice = false;
                    }
                }
                else if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("DANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                    Console.WriteLine("Thanks for playing!");
                    Thread.Sleep(5000);
                    playDangerPrice = false;
                }
                else
                {
                    Console.WriteLine("Oh no! Wrong answer!");
                    Thread.Sleep(2500);
                    playDangerPrice = false;
                }
            }
        }
    }
}
