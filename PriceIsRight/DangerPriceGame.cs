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
                Console.WriteLine("\tWelcome to DANGER PRICE! Choose the three prizes that don't match the Danger Price and you win them all!");
                Console.WriteLine("\tPress any key to continue:");
                Console.Write("\t");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("\tToday's Prizes:\n" +
                    "\t1. Black Diamond IPhone\n" +
                    "\t2. Manhattan Parking Space\n" +
                    "\t3. Rolls-Royce Sweptail\n" +
                    "\t4. One microgram of Anti-matter\n\n" +
                    "\tDanger Price: $15,300,000\n");
                Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1,2,3,or 4)");
                string input;
                Console.Write("\t");
                input = Console.ReadLine();
                Console.WriteLine("");

                if (input == "2") 
                {
                    Console.WriteLine("\tNice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                    Console.WriteLine("\n" +
                        "\tWhich item is NOT worth the Danger Price? (1, 3, or 4?)");
                    Console.Write("\t");
                    input = Console.ReadLine();
                    Console.WriteLine("");
                    if (input == "3") 
                    {
                        Console.WriteLine("\tFantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                        Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1 or 4?)");
                        Console.Write("\t");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "4")
                        {
                            Console.WriteLine("\n\tGreat guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                            Console.WriteLine("\tCongrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(8500);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("\tThanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("\tOh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("\tGreat guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                        Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1 or 3?)");
                        Console.Write("\t");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "3")
                        {
                            Console.WriteLine("\tFantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                            Console.WriteLine("\tCongrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n\n This'll be our final show...");
                            Thread.Sleep(8500);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("\tThanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("\tOh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                        Console.WriteLine("\tThanks for playing!");
                        Thread.Sleep(5000);
                        playDangerPrice = false;
                    }
                    else
                    {
                        Console.WriteLine("\tOh no! Wrong answer!");
                        Thread.Sleep(2500);
                        playDangerPrice = false;
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("\tFantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                    Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1, 2, or 4?)");
                    Console.Write("\t");
                    input = Console.ReadLine();
                    Console.WriteLine("");
                    if (input == "2")
                    {
                        Console.WriteLine("\tNice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                        Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1 or 4?)");
                        Console.Write("\t");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "4")
                        {
                            Console.WriteLine("\tGreat guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.");
                            Console.WriteLine("\tCongrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(8500);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("\tThanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("\tOh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("\tGreat guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.\n");
                        Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1 or 2?)");
                        Console.Write("\t");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "2")
                        {
                            Console.WriteLine("\tNice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                            Console.WriteLine("\tCongrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(8500);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("\tThanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("\tOh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                        Console.WriteLine("\tThanks for playing!");
                        Thread.Sleep(5000);
                        playDangerPrice = false;
                    }
                    else
                    {
                        Console.WriteLine("\tOh no! Wrong answer!");
                        Thread.Sleep(2500);
                        playDangerPrice = false;
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("\tGreat guess! One microgram of Anti-matter is $62,500,000 of what the hell are you gonna do with.\n");
                    Console.WriteLine("\n\tWhich item is NOT worth the Danger Price? (1, 2, or 3?)");
                    Console.Write("\t");
                    input = Console.ReadLine();
                    Console.WriteLine();
                    if (input == "2")
                    {
                        Console.WriteLine("\tNice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                        Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1 or 3?)");
                        Console.Write("\t");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "3")
                        {
                            Console.WriteLine("\tFantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                            Console.WriteLine("\tCongrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...");
                            Thread.Sleep(8500);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("\tThanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("\tOh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("\tFantastic! Getting your hands on a Rolls-Royce Sweptail shows the world you have $13,000,000 to throw around.");
                        Console.WriteLine("\tWhich item is NOT worth the Danger Price? (1 or 2?)");
                        Console.Write("\t");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "2")
                        {
                            Console.WriteLine("\tNice! Owning a public parking space in Manhattan will set you back $1,000,000!");
                            Console.WriteLine("\tCongrats you've won all the prizes!!! Unfortunately these prizes have caused us to go bankrupt.\n This'll be our final show...\n");
                            Thread.Sleep(8500);
                            playDangerPrice = false;
                        }
                        else if (input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                            Console.WriteLine("\tThanks for playing!");
                            Thread.Sleep(5000);
                            playDangerPrice = false;
                        }
                        else
                        {
                            Console.WriteLine("\tOh no! Wrong answer!");
                            Thread.Sleep(2500);
                            playDangerPrice = false;
                        }
                    }
                    else if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                        Console.WriteLine("\tThanks for playing!");
                        Thread.Sleep(5000);
                        playDangerPrice = false;
                    }
                    else
                    {
                        Console.WriteLine("\tOh no! Wrong answer!");
                        Thread.Sleep(2500);
                        playDangerPrice = false;
                    }
                }
                else if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\tDANGER PRICE! Sorry, the Black Diamond IPhone does, in fact, cost a whopping $15,300,000!");
                    Console.WriteLine("\tThanks for playing!");
                    Thread.Sleep(5000);
                    playDangerPrice = false;
                }
                else
                {
                    Console.WriteLine("\tOh no! Wrong answer!");
                    Thread.Sleep(2500);
                    playDangerPrice = false;
                }
            }
        }
    }
}
