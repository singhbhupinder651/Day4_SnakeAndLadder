using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public static class SinglePlayerRollsDie
    {
        public static void RollDie()
        {
            int position = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);

            Console.WriteLine("Die roll number: " + dieRoll);
        }
    }
}
