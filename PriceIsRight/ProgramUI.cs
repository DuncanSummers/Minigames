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
                Console.WriteLine("\t __   __");                       
                Console.WriteLine("\t|  |_|  |--.-----.");
                Console.WriteLine("\t|   _|     |  -__|");
                Console.WriteLine("\t|____|__|__|_____|");
                Console.WriteLine("\t _______      __ ");
                Console.WriteLine("\t|   _   .----|__.----.-----.");
                Console.WriteLine("\t|.  1   |   _|  |  __|  -__|");
                Console.WriteLine("\t|.  ____|__| |__|____|_____|");
                Console.WriteLine("\t|:  |");
                Console.WriteLine("\t|::.|");
                Console.WriteLine("\t`---'");                          
                Console.WriteLine("\t __");
                Console.WriteLine("\t|__.-----.");
                Console.WriteLine("\t|  |__ --|");
                Console.WriteLine("\t|__|_____|");
                Console.WriteLine("\t _______ __       __    __");
                Console.WriteLine("\t|   _   |__.-----|  |--|  |_");
                Console.WriteLine("\t|.  l   |  |  _  |     |   _|");
                Console.WriteLine("\t|.  _   |__|___  |__|__|____|");
                Console.WriteLine("\t|:  |   |  |_____|");
                Console.WriteLine("\t|::.|:. |");
                Console.WriteLine("\t`--- ---'    By Duncan Summers and Roy Bentz");
                Console.WriteLine("\n\n\n \t Which 'The Price Is Right' themed mini-game would you like to play?:\n" +
                    "\t 1. Hi-Lo\n" +
                    "\t 2. Easy 1-2-3\n" +
                    "\t 3. Danger Price\n" +
                    "\t 4. Exit");

                Console.Write("\t");
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        HiLoGame.HiLo();
                        break;
                    case "2":
                        Console.Clear();
                        Game123.EasyGame();
                        break;
                    case "3":
                        Console.Clear();
                        DangerPriceGame.DangerPrice();
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