namespace XO_Game
{
    public class XO
    {
        private int key;

        private char[] decisions = { 'X', 'O' };

        private char decision;

        private char lastDecision = 'e';

        private char[,] table =
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
            Console.WriteLine($"{table[0, 0]} | {table[0, 1]} | {table[0, 2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{table[1, 0]} | {table[1, 1]} | {table[1, 2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{table[2, 0]} | {table[2, 1]} | {table[2, 2]}");
        }

        public bool CheckLastDecision(char decision)
        {
            if(lastDecision == decision || lastDecision == decision+32 || lastDecision == decision-32)
            {
                return true;
            }

            lastDecision = decision;

            return false;
        }

        public void ChangeColor() {
            if (this.decision == 'X' || this.decision == 'x') Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public char GetLastDecision()
        {
            return lastDecision;
        }

        public void SetDecision(char decision)
        {
            if (decision == 'X' || decision == 'x') this.decision = decisions[0];
            else if (decision == 'O' || decision == 'o') this.decision = decisions[1];
            else
            {
                Console.WriteLine("Choose only X or O");
            }
        }

        public bool IsDecisionCorrect(char decision)
        {
            if (decision == 'X' || decision =='x' || decision == 'O' || decision =='o') return true;
            else return false;
        }

        public bool IsValidOrPlaceAlreadyChecked(int key)
        {

            foreach (var item in table)
            {
                if (item == key+48) return false;
            }
            return true;
        }

        public void SetKey(int key)
        {
            this.key = key;
        }

        public void ChangeTable()
        {
            switch (this.key)
            {
                case 1:
                    table[0, 0] = decision;
                    break;
                case 2:
                    table[0, 1] = decision;
                    break;
                case 3:
                    table[0, 2] = decision;
                    break;
                case 4:
                    table[1, 0] = decision;
                    break;
                case 5:
                    table[1, 1] = decision;
                    break;
                case 6:
                    table[1, 2] = decision;
                    break;
                case 7:
                    table[2, 0] = decision;
                    break;
                case 8:
                    table[2, 1] = decision;
                    break;
                case 9:
                    table[2, 2] = decision;
                    break;
                default:
                    Console.WriteLine();
                    break;

            }
        }

        public bool IsXWinner()
        {
            if ((table[0, 0] == 'X' && table[1, 0] == 'X' && table[2, 0] == 'X') ||
                (table[0, 0] == 'X' && table[0, 1] == 'X' && table[0, 2] == 'X') ||
                (table[0, 0] == 'X' && table[1, 1] == 'X' && table[2, 2] == 'X') ||
                (table[1, 0] == 'X' && table[1, 1] == 'X' && table[1, 2] == 'X') ||
                (table[2, 0] == 'X' && table[2, 1] == 'X' && table[2, 2] == 'X') ||
                (table[0, 1] == 'X' && table[1, 1] == 'X' && table[2, 1] == 'X') ||
                (table[0, 2] == 'X' && table[1, 2] == 'X' && table[2, 2] == 'X'))
                return true;
            return false;
        }
        public bool IsOWinner()
        {
            if ((table[0, 0] == 'O' && table[1, 0] == 'O' && table[2, 0] == 'O') ||
                (table[0, 0] == 'O' && table[0, 1] == 'O' && table[0, 2] == 'O') ||
                (table[0, 0] == 'O' && table[1, 1] == 'O' && table[2, 2] == 'O') ||
                (table[1, 0] == 'O' && table[1, 1] == 'O' && table[1, 2] == 'O') ||
                (table[2, 0] == 'O' && table[2, 1] == 'O' && table[2, 2] == 'O') ||
                (table[0, 1] == 'O' && table[1, 1] == 'O' && table[2, 1] == 'O') ||
                (table[0, 2] == 'O' && table[1, 2] == 'O' && table[2, 2] == 'O'))
                return true;
            return false;
        }
    }
}