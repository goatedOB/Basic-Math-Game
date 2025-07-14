
namespace First_Program
{
    internal class GameEngine
    {
       internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int j = 0; j < 5; j++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Well, Your answer is correct! Type any key for the next question"!);
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Too Bad your Answer is Incorrect");
                }

                if (j == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistroy(score, "Addition");

        }
       internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int j = 0; j < 5; j++)
            {

                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Well, Your answer is correct! Type any bekey for the next question"!);
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Too Bad your Answer is Incorrect");
                }

                if (j == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

           Helpers.AddToHistroy(score, "Subtraction");
        }
       internal void DivisionGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divisionNumbers = Helpers.GetdivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Well, Your answer is correct! Type any key for the next question"!);
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Eish, Too bad you answer is incorrect");
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistroy(score, "Division");
        }
       internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int j = 0; j < 5; j++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Well, Your answer is correct! Type any key for the next question"!);
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Too Bad your Answer is Incorrect");
                }

                if (j == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to the main menu");
                    Console.ReadLine();
                }
            }

           Helpers.AddToHistroy(score, "Multiplication");
        }

    }
}
