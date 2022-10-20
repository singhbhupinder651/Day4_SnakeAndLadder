using System;

namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");
            Console.WriteLine("Use case #1: Single Player at Position Zero");
            Console.WriteLine("Use case #2: Single Player Rolls the Die");
            Console.WriteLine("Use case #3: Single Player Checks for Options After Die Roll");
            Console.WriteLine("Use case #4: Single Player Reaches Winning Position");
            Console.WriteLine("Use case #5: Single Player Reaches Exact Winning Position Hundred");
            Console.WriteLine("Use case #6: Single Player Game Statistics Report");
            Console.WriteLine("Use case #7: Double Player Competition");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SinglePlayerPositionZero.Play();
                    Console.WriteLine("Player One ready to play, starting at position 0");
                    break;
                case 2:
                    SinglePlayerRollsDie.RollDie();
                    break;
                case 3:
                    SinglePlayerChecksOption.CheckOption();
                    break;
                case 4:
                    SinglePlayerWinningPosition.PlayerToHundred();
                    break;
                case 5:
                    SinglePlayerExactWinningPosition.ExactPositionHundred();
                    break;
                case 6:
                    SinglePlayerStatisticsReport.PlayGame();
                    break;
                case 7:
                    DoublePlayerCompetition.StartGame();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
            
        }
    }
}