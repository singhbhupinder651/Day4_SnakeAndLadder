using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public static class DoublePlayerCompetition
    {
        public static void StartGame()
        {
            int playerOnePosition = 0, playerTwoPosition = 0;
            const int LADDER = 0, SNAKE = 1;
            Random random = new Random();

            while (playerOnePosition < 100 && playerTwoPosition < 100)
            {
                int firstPlayer = random.Next(0, 2);
                const int PLAYER_ONE_PLAYS_FIRST = 0;
                const int PLAYER_TWO_PLAYS_FIRST = 1;

                switch (firstPlayer)    //to choose the first player randomly between Player One and Player Two 
                {
                    case PLAYER_ONE_PLAYS_FIRST:                            //player One starts the game
                        int playerOneDieRollFirst = random.Next(1, 7);      //player One's first die roll
                        int playerOneOptionCheck = random.Next(0, 3);

                        switch (playerOneOptionCheck)                       //player One checks for options after first die roll
                        {
                            case LADDER:
                                Console.WriteLine("Option: Ladder");
                                playerOnePosition += playerOneDieRollFirst;
                                if (playerOnePosition > 100)
                                {
                                    playerOnePosition -= playerOneDieRollFirst;
                                }
                                int playerOneExitLoop = 0;
                                while (playerOneExitLoop == 0)   //if player gets ladder after first die roll, they roll the die a second time
                                {
                                    int playerOneDieRollSecond = random.Next(1, 7);
                                    int playerOneOptionAgain = random.Next(0, 3);   //to determine which option user gets after second die roll

                                    switch (playerOneOptionAgain)
                                    {
                                        case LADDER:
                                            playerOnePosition += playerOneDieRollSecond;
                                            if (playerOnePosition > 100)
                                            {
                                                playerOnePosition -= playerOneDieRollSecond;
                                            }
                                            playerOneExitLoop = random.Next(0, 3);   //for value 0, it will run this while loop again to simulate another die roll
                                            break;                                   //for values 1 and 2, it will exit the loop
                                        case SNAKE:
                                            playerOnePosition -= playerOneDieRollSecond;
                                            if (playerOnePosition < 0)
                                            {
                                                playerOnePosition = 0;
                                            }
                                            playerOneExitLoop = 1;                  //will exit the while loop
                                            break;
                                        default:
                                            Console.WriteLine("Option: No Play");
                                            playerOneExitLoop = 2;                  //will exit the while loop
                                            break;
                                    }
                                }
                                break;
                            case SNAKE:
                                Console.WriteLine("Option: Snake");
                                playerOnePosition -= playerOneDieRollFirst;
                                if (playerOnePosition < 0)
                                {
                                    playerOnePosition = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("Option: No Play");
                                break;
                        }

                        //playerTwo plays second
                        int playerTwoDieRollFirst = random.Next(1, 7);      //player Two's first die roll
                        int playerTwoOptionCheck = random.Next(0, 3);

                        switch (playerTwoOptionCheck)                      //player Two checks for options after first die roll
                        {
                            case LADDER:
                                Console.WriteLine("Option: Ladder");
                                playerTwoPosition += playerTwoDieRollFirst;
                                if (playerTwoPosition > 100)
                                {
                                    playerTwoPosition -= playerTwoDieRollFirst;
                                }
                                int playerTwoExitLoop = 0;
                                while (playerTwoExitLoop == 0)   //if player gets ladder after first die roll, they roll the die a second time
                                {
                                    int playerTwoDieRollSecond = random.Next(1, 7);
                                    int playerTwoOptionAgain = random.Next(0, 3);   //to determine which option user gets after second die roll

                                    switch (playerTwoOptionAgain)
                                    {
                                        case LADDER:
                                            playerTwoPosition += playerTwoDieRollSecond;
                                            if (playerTwoPosition > 100)
                                            {
                                                playerTwoPosition -= playerTwoDieRollSecond;
                                            }
                                            playerTwoExitLoop = random.Next(0, 3);   //for value 0, it will run this while loop again to simulate another die roll
                                            break;                                   //for values 1 and 2, it will exit the loop
                                        case SNAKE:
                                            playerTwoPosition -= playerTwoDieRollSecond;
                                            if (playerTwoPosition < 0)
                                            {
                                                playerTwoPosition = 0;
                                            }
                                            playerTwoExitLoop = 1;                  //will exit the while loop
                                            break;
                                        default:
                                            Console.WriteLine("Option: No Play");
                                            playerTwoExitLoop = 2;                  //will exit the while loop
                                            break;
                                    }
                                }
                                break;
                            case SNAKE:
                                Console.WriteLine("Option: Snake");
                                playerTwoPosition -= playerTwoDieRollFirst;
                                if (playerTwoPosition < 0)
                                {
                                    playerTwoPosition = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("Option: No Play");
                                break;
                        }
                        break;

                    case PLAYER_TWO_PLAYS_FIRST:    //playerTwo starts the game

                        int playerTwoRollFirst = random.Next(1, 7);  //player Two's first die roll
                        int playerTwoOptions = random.Next(0, 3);

                        switch (playerTwoOptions)   //player Two checks for options after first die roll
                        {
                            case LADDER:
                                Console.WriteLine("Option: Ladder");
                                playerTwoPosition += playerTwoRollFirst;
                                if (playerTwoPosition > 100)
                                {
                                    playerTwoPosition -= playerTwoRollFirst;
                                }
                                int playerTwoExitLoop = 0;
                                while (playerTwoExitLoop == 0)   //if player gets ladder after first die roll, they roll the die a second time
                                {
                                    int playerTwoRollSecond = random.Next(1, 7);
                                    int playerTwoOptionsAgain = random.Next(0, 3);   //to determine which option user gets after second die roll

                                    switch (playerTwoOptionsAgain)
                                    {
                                        case LADDER:
                                            playerTwoPosition += playerTwoRollSecond;
                                            if (playerTwoPosition > 100)
                                            {
                                                playerTwoPosition -= playerTwoRollSecond;
                                            }
                                            playerTwoExitLoop = random.Next(0, 3);   //for value 0, it will run this while loop again to simulate another die roll
                                            break;                                   //for values 1 and 2, it will exit the loop
                                        case SNAKE:
                                            playerTwoPosition -= playerTwoRollSecond;
                                            if (playerTwoPosition < 0)
                                            {
                                                playerTwoPosition = 0;
                                            }
                                            playerTwoExitLoop = 1;                  //will exit the while loop
                                            break;
                                        default:
                                            Console.WriteLine("Option: No Play");
                                            playerTwoExitLoop = 2;                  //will exit the while loop
                                            break;
                                    }
                                }
                                break;
                            case SNAKE:
                                Console.WriteLine("Option: Snake");
                                playerTwoPosition -= playerTwoRollFirst;
                                if (playerTwoPosition < 0)
                                {
                                    playerTwoPosition = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("Option: No Play");
                                break;
                        }

                        //player One plays second
                        int playerOneRollFirst = random.Next(1, 7);  //player One's first die roll
                        int playerOneOptions = random.Next(0, 3);

                        switch (playerOneOptions)                   //player One checks for options after first die roll
                        {
                            case LADDER:
                                Console.WriteLine("Option: Ladder");
                                playerOnePosition += playerOneRollFirst;
                                if (playerOnePosition > 100)
                                {
                                    playerOnePosition -= playerOneRollFirst;
                                }
                                int playerOneExitLoop = 0;
                                while (playerOneExitLoop == 0)   //if player gets ladder after first die roll, they roll the die a second time
                                {
                                    int playerOneRollSecond = random.Next(1, 7);
                                    int playerOneOptionsAgain = random.Next(0, 3);   //to determine which option user gets after second die roll

                                    switch (playerOneOptionsAgain)
                                    {
                                        case LADDER:
                                            playerOnePosition += playerOneRollSecond;
                                            if (playerOnePosition > 100)
                                            {
                                                playerOnePosition -= playerOneRollSecond;
                                            }
                                            playerOneExitLoop = random.Next(0, 3);   //for value 0, it will run this while loop again to simulate another die roll
                                            break;                                   //for values 1 and 2, it will exit the loop
                                        case SNAKE:
                                            playerOnePosition -= playerOneRollSecond;
                                            if (playerOnePosition < 0)
                                            {
                                                playerOnePosition = 0;
                                            }
                                            playerOneExitLoop = 1;                  //will exit the while loop
                                            break;
                                        default:
                                            Console.WriteLine("Option: No Play");
                                            playerOneExitLoop = 2;                  //will exit the while loop
                                            break;
                                    }
                                }
                                break;
                            case SNAKE:
                                Console.WriteLine("Option: Snake");
                                playerOnePosition -= playerOneRollFirst;
                                if (playerOnePosition < 0)
                                {
                                    playerOnePosition = 0;
                                }
                                break;
                            default:
                                Console.WriteLine("Option: No Play");
                                break;
                        }

                        break;
                    default:
                        Console.Write("Check code for bugs!");
                        break;
                }



            }



            Console.WriteLine("Player One's final position after game is over: " + playerOnePosition);
            Console.WriteLine("Player Two's final position after game is over: " + playerTwoPosition);

            if (playerOnePosition > playerTwoPosition)
            {
                Console.WriteLine("Winner: Player One");
            }
            else
            {
                Console.WriteLine("Winner: Player Two");
            }
        }
    }
}

