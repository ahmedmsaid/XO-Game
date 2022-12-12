namespace XO_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char XorO;

            int input, n = 9;

            XO game = new XO();

            Console.WriteLine("Welcome");
            game.GenerateTable();

            while (n > 0)
            {
                Console.Write("Enter X or O: ");
                char.TryParse(Console.ReadLine(), out XorO);

                while (!game.IsDecisionCorrect(XorO))
                {
                    Console.WriteLine("Invalid, Enter only X or O");
                    char.TryParse(Console.ReadLine(), out XorO);

                }

                game.SetDecision(XorO);

                Console.WriteLine();

                Console.Write("Enter a place number: ");
                int.TryParse(Console.ReadLine(), out input);

                while (game.IsPlaceAlreadyChecked(input))
                {
                    Console.WriteLine("Already Checked, Enter a place number: ");
                    int.TryParse(Console.ReadLine(), out input);
                }

                game.SetKey(input);

                game.ChangeTable();

                game.GenerateTable();

                Console.WriteLine();

                if (game.IsXWinner())
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("X wins");
                    break;
                }

                if (game.IsOWinner())
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("O wins");
                    break;
                }

                n--;
            }

            if (game.IsXWinner() == false && game.IsOWinner() == false)
            {
                Console.WriteLine("\nTIE");
            }

        }
    }
}