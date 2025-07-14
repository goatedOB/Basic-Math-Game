using First_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();
       internal void ShowMenu(string name, DateTime date)
        {

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Hello {name}. Its{date}. This a simple math's game. Its great that you want be better at mathematics\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would your like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("--------------------------------------------------");

                var userOption = Console.ReadLine();

                switch (userOption.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");

                        break;
                    case "q":
                        Console.WriteLine("GoodBye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Environment.Exit(1);
                        break;

                }
            } while (isGameOn);

        }

    }
}
