using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    enum GameState
    {
        ship4,
        ship3_1,
        ship3_2,
        ship2_1,
        ship2_2,
        ship2_3,
        ship1_1,
        ship1_2,
        ship1_3,
        ship1_4,
        game
    }

    public enum CellState
    {
        empty,
        busy,
        adjacent,
        striked,
        missed,
        masked
    }

    public delegate void Invoker(CellState[,] map);

    class Brain
    {
        CellState[,] map = new CellState[10, 10];
        GameState current;
        Invoker invoker;

        int x;
        int y;

        public Brain(Invoker invoker)
        {
            this.invoker = invoker;
            current = GameState.ship4;

            x = 0;
            y = 1;

            for(int i = 0; i < 10; ++i)
            {
                for(int j = 0; j < 10; ++j)
                {
                    map[i, j] = CellState.empty;
                }
            }

            invoker.Invoke(map);
        }

        public void Switch()
        {
            if (y == 1)
            {
                x = 1;
                y = 0;
            }
            else
            {
                x = 0;
                y = 1;
            }
        }

        public void Process(string msg)
        {
            switch (current)
            {
                case GameState.ship4:
                    Ship4(false, msg);
                    break;
                case GameState.ship3_1:
                    Ship3_1(false, msg);
                    break;
                case GameState.ship3_2:
                    Ship3_2(false, msg);
                    break;
                case GameState.ship2_1:
                    Ship2_1(false, msg);
                    break;
                case GameState.ship2_2:
                    Ship2_2(false, msg);
                    break;
                case GameState.ship2_3:
                    Ship2_3(false, msg);
                    break;
                case GameState.ship1_1:
                    Ship1_1(false, msg);
                    break;
                case GameState.ship1_2:
                    Ship1_2(false, msg);
                    break;
                case GameState.ship1_3:
                    Ship1_3(false, msg);
                    break;
                case GameState.ship1_4:
                    Ship1_4(false, msg);
                    break;
                case GameState.game:
                    Game(false, msg);
                    break;
            }
        }

        private void CheckCell(int i, int j)
        {
            if (i < 0 || i > 9) return;
            if (j < 0 || j > 9) return;
            if (map[i, j] == CellState.busy) return;

            map[i, j] = CellState.adjacent;
        }

        private void CheckAdjCells(int i, int j)
        {
            CheckCell(i - 1, j - 1);
            CheckCell(i - 1, j);
            CheckCell(i - 1, j + 1);
            CheckCell(i , j + 1);
            CheckCell(i + 1, j + 1);
            CheckCell(i + 1, j);
            CheckCell(i + 1, j - 1);
            CheckCell(i, j - 1);
        }

        private void MarkCell(int i, int j, CellState state) => map[i, j] = state;


        private void MarkLocation(string msg, CellState state)
        {
            string[] coor = msg.Split('_');

            int i = int.Parse(coor[0]);
            int j = int.Parse(coor[1]);

            switch (current)
            {
                case GameState.ship4:
                    MarkCell(i, j, state);
                    MarkCell(i + x, j + y, state);
                    MarkCell(i + 2 * x, j + 2 * y, state);
                    MarkCell(i + 3 * x, j + 3 * y, state);
                    CheckAdjCells(i, j);
                    CheckAdjCells(i + x, j + y);
                    CheckAdjCells(i + 2 * x, j + 2 * y);
                    CheckAdjCells(i + 3 * x, j + 3 * y);
                    break;
                case GameState.ship3_1:
                case GameState.ship3_2:
                    MarkCell(i, j, state);
                    MarkCell(i + x, j + y, state);
                    MarkCell(i + 2 * x, j + 2 * y, state);
                    CheckAdjCells(i, j);
                    CheckAdjCells(i + x, j + y);
                    CheckAdjCells(i + 2 * x, j + 2 * y);
                    break;
                case GameState.ship2_1:
                case GameState.ship2_2:
                case GameState.ship2_3:
                    MarkCell(i, j, state);
                    MarkCell(i + x, j + y, state);
                    CheckAdjCells(i, j);
                    CheckAdjCells(i + x, j + y);
                    break;
                case GameState.ship1_1:
                case GameState.ship1_2:
                case GameState.ship1_3:
                case GameState.ship1_4:
                    MarkCell(i, j, state);
                    CheckAdjCells(i, j);
                    break;
                case GameState.game:
                    break;
            }
        }

        private bool IsValidCell(int i, int j)
        {
            if (i < 0 || i > 9) return false;
            if (j < 0 || j > 9) return false;

            return map[i, j] == CellState.empty;
        }

        private bool IsValidLocation(string msg)
        {
            string[] coor = msg.Split('_');

            int i = int.Parse(coor[0]);
            int j = int.Parse(coor[1]);

            bool res = false;

            switch (current)
            {
                case GameState.ship4:
                    res = IsValidCell(i, j) && IsValidCell(i + x, j + y) && IsValidCell(i + 2 * x, j + 2 * y) && IsValidCell(i + 3 * x, j + 3 * y);
                    break;
                case GameState.ship3_1:
                case GameState.ship3_2:
                    res = IsValidCell(i, j) && IsValidCell(i + x, j + y) && IsValidCell(i + 2 * x, j + 2 * y);
                    break;
                case GameState.ship2_1:
                case GameState.ship2_2:
                case GameState.ship2_3:
                    res = IsValidCell(i, j) && IsValidCell(i + x, j + y);
                    break;
                case GameState.ship1_1:
                case GameState.ship1_2:
                case GameState.ship1_3:
                case GameState.ship1_4:
                    res = IsValidCell(i, j);
                    break;
                case GameState.game:
                    break;
            }

            return res;
        }

        private void Ship4(bool isInput, string msg)
        {
            if (isInput)
            {
                invoker.Invoke(map);
                current = GameState.ship4;
            }

            else if (IsValidLocation(msg))
                Ship3_1(true, msg);
        }

        private void Ship3_1(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship3_1;
            }

            else if (IsValidLocation(msg))
                Ship3_2(true, msg);
        }

        private void Ship3_2(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship3_2;
            }

            else if (IsValidLocation(msg))
                Ship2_1(true, msg);
        }

        private void Ship2_1(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship2_1;
            }


            else if (IsValidLocation(msg))
                Ship2_2(true, msg);
        }

        private void Ship2_2(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship2_2;
            }

            else if (IsValidLocation(msg))
                Ship2_3(true, msg);
        }

        private void Ship2_3(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship2_3;
            }

            else if (IsValidLocation(msg))
                Ship1_1(true, msg);
        }

        private void Ship1_1(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship1_1;
            }

            else if (IsValidLocation(msg))
                Ship1_2(true, msg);
        }

        private void Ship1_2(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship1_2;
            }

            else if (IsValidLocation(msg))
                Ship1_3(true, msg);
        }

        private void Ship1_3(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship1_3;
            }

            else if (IsValidLocation(msg))
                Ship1_4(true, msg);
        }

        private void Ship1_4(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.ship1_4;
            }

            else if (IsValidLocation(msg))
                Game(true, msg);
        }

        private void Game(bool isInput, string msg)
        {
            if (isInput)
            {
                MarkLocation(msg, CellState.busy);
                invoker.Invoke(map);
                current = GameState.game;
            }

            else
            {

            }
        }
    }
}
