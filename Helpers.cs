﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Program
{
    internal class Helpers
    {
        static List<string> games = new();
       internal static int[] GetdivisionNumbers()
        {

            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            result[0] = firstNumber;
            result[1] = secondNumber;

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
       internal static void AddToHistroy(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
        }
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-------------------------------/n");
            Console.WriteLine("Press any key ruturn to menu");
            Console.ReadLine();
        }
    }
}
