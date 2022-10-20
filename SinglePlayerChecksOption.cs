using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public static class SinglePlayerChecksOption
    {
        public static void CheckOption()
        {
            int position = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            int option = random.Next(0, 3);

            Console.WriteLine("Die roll number: " + dieRoll);

            switch (option)
            {
                case 0:
                    Console.WriteLine("Case: Ladder");
                    position += dieRoll;
                    break;
                case 1:
                    Console.WriteLine("Case: Snake");
                    position -= dieRoll;
                    break;
                default:
                    Console.WriteLine("Case: No Play");
                    break;
            }


            Console.WriteLine("Player's current position after play: " + position);
        }
    }
}

