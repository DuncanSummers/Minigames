using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceIsRight
{
    public class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Which game would you like to play?:\n" +
                    "1. Hi-Lo\n" +
                    "2. Easy 1-2-3\n" +
                    "3. Exit");

                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        HiLoGame.HiLo();
                        break;
                    case "2":
                        Console.WriteLine("coming soon");
                        break;
                    default:
                        Console.WriteLine("Clearly, you don't want to play this garbage");
                        break;
                }
            }
        }
    }
}