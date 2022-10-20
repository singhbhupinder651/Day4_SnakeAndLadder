using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public static class SinglePlayerStatisticsReport
    {
        public static void PlayGame()
        {
            int position = 0, rollsCounter = 0;
            Random random = new Random();

            while (position < 100)
            {
                rollsCounter++;
                int dieRoll = random.Next(1, 7);
                int option = random.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Case: Ladder");
                        position += dieRoll;
                        if (position > 100)
                        {
                            position -= dieRoll;
                        }
                        Console.WriteLine("Player's current position after ladder: " + position);
                        break;
                    case 1:
                        Console.WriteLine("Case: Snake");
                        position -= dieRoll;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine("Player's current position after snake: " + position);
                        break;
                    default:
                        Console.WriteLine("Case: No Play");
                        Console.WriteLine("Player's current position after no play: " + position);
                        break;
                }
            }
            Console.WriteLine("Player's final position after play: " + position);
            Console.WriteLine("Number of times the die was played to win the game: " + rollsCounter);
        }
    }
}
