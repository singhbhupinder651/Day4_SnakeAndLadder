namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");
            Console.WriteLine("Use case #1: Single Player at Position Zero");
            Console.WriteLine("Use case #2: Single Player Rolls the Die");

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
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
            
        }
    }
}