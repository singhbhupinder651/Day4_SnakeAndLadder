using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public static class SinglePlayerExactWinningPosition
    {
        public static void ExactPositionHundred()
        {
            int position = 0;
            Random random = new Random();

            while (position < 100)
            {
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
                        break;
                    case 1:
                        Console.WriteLine("Case: Snake");
                        position -= dieRoll;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Case: No Play");
                        break;
                }
            }

            Console.WriteLine("Player's final position after play: " + position);
        }
    }
}
