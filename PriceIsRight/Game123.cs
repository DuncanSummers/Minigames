using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriceIsRight
{
    public class Game123
    {

        public static void EasyGame()
        {
            Dictionary<string, double> itemPrice = new Dictionary<string, double>();

            itemPrice.Add("Coffee Maker", 23.00);
            itemPrice.Add("Lawn Mower", 150.00);
            itemPrice.Add("Samsung TV", 230.00);
            itemPrice.Add("Caviar", 450.00);
            itemPrice.Add("NFL Football", 27.00);
            itemPrice.Add("Easton Baseball Bat", 199.00);
            itemPrice.Add("Frosted Mini-Wheats", 3.00);
            itemPrice.Add("Diablo 2 Resurrected", 70.00);
            itemPrice.Add("Star-Trac Treadmill", 500.00);
            itemPrice.Add("Crest Tooth Paste", 2.15);
            itemPrice.Add("Expresso Machine", 549.23);
            itemPrice.Add("JBL Bluetooth Speaker", 31.00);
            itemPrice.Add("Jefferson's Ocean Bourbon Whiskey", 75.00);

            int lives = 3;


            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Welcome to Easy as 1 2 3!!");
                Console.WriteLine("Please input numbers 1, 2, or 3, in the order of least expensive item to most expensive");

                //Random item = new Random();
                Random indexer = new Random();

                double answer1; // must be declared outside of if statement
                double answer2; // must be declared outside of if statement
                double answer3; // must be declared outside of if statement

                int index1 = indexer.Next(itemPrice.Count);
                string key1 = itemPrice.Keys.ElementAt(index1);

                int index2 = indexer.Next(itemPrice.Count);
                string key2 = itemPrice.Keys.ElementAt(index2);
                while (index1 == index2)
                {
                    index2 = indexer.Next(itemPrice.Count);
                    key2 = itemPrice.Keys.ElementAt(index2);
                }

                int index3 = indexer.Next(itemPrice.Count);
                string key3 = itemPrice.Keys.ElementAt(index3);
                while (index3 == index1 || index3 == index2)
                {
                    index3 = indexer.Next(itemPrice.Count);
                    key3 = itemPrice.Keys.ElementAt(index3);
                }

                double value1 = itemPrice[key1];
                double value2 = itemPrice[key2];
                double value3 = itemPrice[key3];

                Console.WriteLine("Item 1:" + key1);
                Console.WriteLine("Item 2:" + key2);
                Console.WriteLine("Item 3:" + key3);
                Console.WriteLine("Which is cheapest '1, 2, or 3' ?");
                string answerOne = Console.ReadLine();

                while (answerOne != "1" && answerOne != "2" && answerOne != "3")
                {
                    Console.WriteLine("Try again!\n\n");
                    Console.WriteLine("Which is cheapest '1, 2, 3' ?");
                    answerOne = Console.ReadLine();
                }

                if (answerOne == "1")
                {
                    answer1 = value1;
                }
                else if (answerOne == "2")
                {
                    answer1 = value2;
                }
                else
                {
                    answer1 = value3;
                }



                Console.WriteLine("Which is 2nd most expensive '1, 2, or 3' ?");
                string answerTwo = Console.ReadLine();

                if (answerTwo == "1")
                {
                    answer2 = value1;
                }
                else if (answerTwo == "2")
                {
                    answer2 = value2;
                }
                else
                {
                    answer2 = value3;
                }

                Console.WriteLine("Which is most expensive '1, 2, or 3' ?");
                string answerThree = Console.ReadLine();

                if (answerThree == "1")
                {
                    answer3 = value1;
                }
                else if (answerThree == "2")
                {
                    answer3 = value2;
                }
                else
                {
                    answer3 = value3;
                }

                if (answer1 > answer2 || answer1 > answer3)
                {
                    Console.WriteLine("Unfortunately that is incorrect. Better luck next time.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    lives--;
                    if (lives == 0)
                    {
                        continueToRun = false;
                    }
                }
                else if (answer2 > answer3)
                {
                    Console.WriteLine("Unfortunately that is incorrect. Better luck next time.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    lives--;
                    if (lives == 0)
                    {
                        continueToRun = false;
                    }
                }
                else if (answer3 > answer1 || answer3 > answer2)
                {
                    Console.WriteLine("Unfortunately that is incorrect. Better luck next time.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    lives--;
                    if (lives == 0)
                    {
                        continueToRun = false;
                    }
                }
                else
                {
                    Console.WriteLine($"You got it right!! {answer1}, {answer2}, {answer3} ");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}