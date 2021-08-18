using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                Console.WriteLine(" __   __");                       
                Console.WriteLine("|  |_|  |--.-----.");
                Console.WriteLine("|   _|     |  -__|");
                Console.WriteLine("|____|__|__|_____|");
                Console.WriteLine(" _______      __ ");
                Console.WriteLine("|   _   .----|__.----.-----.");
                Console.WriteLine("|.  1   |   _|  |  __|  -__|");
                Console.WriteLine("|.  ____|__| |__|____|_____|");
                Console.WriteLine("|:  |");
                Console.WriteLine("|::.|");
                Console.WriteLine("`---'");                          
                Console.WriteLine(" __");
                Console.WriteLine("|__.-----.");
                Console.WriteLine("|  |__ --|");
                Console.WriteLine("|__|_____|");
                Console.WriteLine(" _______ __       __    __");
                Console.WriteLine("|   _   |__.-----|  |--|  |_");
                Console.WriteLine("|.  l   |  |  _  |     |   _|");
                Console.WriteLine("|.  _   |__|___  |__|__|____|");
                Console.WriteLine("|:  |   |  |_____|");
                Console.WriteLine("|::.|:. |");
                Console.WriteLine("`--- ---'");
                Console.WriteLine("\n\n\nWhich game would you like to play?:\n" +
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
                        Console.WriteLine("Clearly, you don't want to play this garbage :(");
                        Thread.Sleep(3500);
                        continueToRun = false;
                        break;
                }
            }
        }
    }
}