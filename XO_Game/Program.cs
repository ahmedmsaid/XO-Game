namespace XO_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char XorO;

            int input, n = 9;

            XO game= new XO();

            Console.WriteLine("Welcome");
            game.GenerateTable();

            while (n > 0)
            {
                Console.Write("Enter X or O: ");
                char.TryParse(Console.ReadLine(), out XorO);
                game.SetDecision(XorO);

                Console.WriteLine();

                Console.Write("Enter a place number: ");
                int.TryParse(Console.ReadLine(), out input);
                game.SetKey(input);

                game.ChangeTable();
                game.GenerateTable();

                if(game.IsXWinner())
                {
                    Console.WriteLine("X wins");
                    break;
                }

                if (game.IsOWinner())
                {
                    Console.WriteLine("O wins");
                    break;
                }

                n--;
            }
        }
    }

    public class XO {
        private int key;

        private char[] _decisions = { 'X', 'O' };

        private char _decision;

        private char[,] _table =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        //public char this[int row, int col]
        //{
        //    get
        //    {
        //        return _table[row, col];
        //    }
        //    set
        //    {
        //        _table[row, col] = value;
        //    }
        //}

        public void GenerateTable()
        {
            Console.WriteLine($"{_table[0, 0]} | {_table[0, 1]} | {_table[0, 2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{_table[1, 0]} | {_table[1, 1]} | {_table[1, 2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{_table[2, 0]} | {_table[2, 1]} | {_table[2, 2]}");
        }

        public void SetDecision(char decision)
        {
            if (decision == 'X') _decision = _decisions[0];
            else if (decision == 'O') _decision = _decisions[1];
        }

        public void SetKey(int key)
        {
            this.key = key;
        }

        public void ChangeTable()
        {
            switch(this.key)
            {
                case 1:
                    _table[0, 0] = _decision;
                    break;
                case 2:
                    _table[0, 1] = _decision;
                    break;
                case 3:
                    _table[0, 2] = _decision;
                    break;
                case 4:
                    _table[1, 0] = _decision;
                    break;
                case 5:
                    _table[1, 1] = _decision;
                    break;
                case 6:
                    _table[1, 2] = _decision;
                    break;
                case 7:
                    _table[2, 0] = _decision;
                    break;
                case 8:
                    _table[2, 1] = _decision;
                    break;
                case 9:
                    _table[2, 2] = _decision;
                    break;
                default:
                    Console.WriteLine();
                    break;

            }
        }

        public bool IsXWinner()
        {
            if ((_table[0, 0] == 'X' && _table[1, 0] == 'X' && _table[2, 0] == 'X') ||
                (_table[0, 0] == 'X' && _table[0, 1] == 'X' && _table[0, 2] == 'X') ||
                (_table[0, 0] == 'X' && _table[1, 1] == 'X' && _table[2, 2] == 'X') ||
                (_table[1, 0] == 'X' && _table[1, 1] == 'X' && _table[1, 2] == 'X') ||
                (_table[2, 0] == 'X' && _table[2, 1] == 'X' && _table[2, 2] == 'X') ||
                (_table[0, 1] == 'X' && _table[1, 1] == 'X' && _table[2, 1] == 'X') ||
                (_table[0, 2] == 'X' && _table[1, 2] == 'X' && _table[2, 2] == 'X'))
                return true;
            return false;
        }
        public bool IsOWinner()
        {
            if ((_table[0, 0] == 'O' && _table[1, 0] == 'O' && _table[2, 0] == 'O') ||
                (_table[0, 0] == 'O' && _table[0, 1] == 'O' && _table[0, 2] == 'O') ||
                (_table[0, 0] == 'O' && _table[1, 1] == 'O' && _table[2, 2] == 'O') ||
                (_table[1, 0] == 'O' && _table[1, 1] == 'O' && _table[1, 2] == 'O') ||
                (_table[2, 0] == 'O' && _table[2, 1] == 'O' && _table[2, 2] == 'O') ||
                (_table[0, 1] == 'O' && _table[1, 1] == 'O' && _table[2, 1] == 'O') ||
                (_table[0, 2] == 'O' && _table[1, 2] == 'O' && _table[2, 2] == 'O'))
                return true;
            return false;
        }
    }
}