using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    enum CellState
    {
        empty,
        busy,
        adjacent,
        striked,
        destroyed,
        missed
    }

    delegate void DrawCells(CellState[,] map);

    class Brain
    {
        CellState[,] map = new CellState[10, 10];
        PlayerType playerType;

        public List<int> notShooted = new List<int>();

        public ShipType[] st = { ShipType.d4,
                                 ShipType.d3, ShipType.d3,
                                 ShipType.d2, ShipType.d2, ShipType.d2,
                                 ShipType.d1, ShipType.d1, ShipType.d1, ShipType.d1 };

        List<Ship> ships;
        DrawCells draw;
        Point direction;

        public int index = -1;

        public Brain(DrawCells draw, PlayerType playerType)
        {
            this.draw = draw;
            this.playerType = playerType;
            ships = new List<Ship>();
            direction = new Point(1, 0);

            for(int i = 0; i < 10; ++i)
            {
                for(int j = 0; j < 10; ++j)
                {
                    map[i, j] = CellState.empty;
                    notShooted.Add(10 * i + j);
                }
            }

            draw.Invoke(map);
        }

        public void Switch(string msg)
        {
            if (direction.X == 1)
                direction = new Point(0, 1);

            else
                direction = new Point(1, 0);
        }

        public bool Play(string msg)
        {
            string[] values = msg.Split('_');

            int i = int.Parse(values[0]);
            int j = int.Parse(values[1]);

            Point p = new Point(i, j);

            bool isShooted = false;

            if (isStriked(p))
            {
                MarkCell(p, CellState.striked);
                isShooted = true;
                CheckDestroyedShip(p);
            }
            else
            {
                MarkCell(p, CellState.missed);
            }

            /*switch (map[p.X, p.Y])
            {
                case CellState.empty:
                case CellState.adjacent:
                    MarkCell(p, CellState.missed);
                    break;
                case CellState.busy:
                    MarkCell(p, CellState.striked);
                    isShooted = true;
                    CheckDestroyedShip(p);
                    break;
            }*/

            draw.Invoke(map);
            return isShooted;
        }

        public void Process(string msg)
        {
            string[] values = msg.Split('_');

            int i = int.Parse(values[0]);
            int j = int.Parse(values[1]);

            Point p = new Point(i, j);

            PlaceShip(p);
        }

        private bool isStriked(Point p)
        {
            bool isStriked = false;

            for (int i = 0; i < ships.Count; ++i)
            {
                if(ships[i].body.Contains(p))
                {
                    isStriked = true;
                    break;
                }
            }

            return isStriked;
        }

        private void CheckDestroyedShip(Point p)
        {
            int ind = -1;

            for (int i = 0; i < ships.Count; ++i)
            {
                if (ships[i].body.Contains(p))
                {
                    ind = i;
                    break;
                }
            }

            if (ind != -1)
            {
                bool isKilled = true;

                foreach (Point f in ships[ind].body)
                {
                    if (map[f.X, f.Y] != CellState.striked)
                    {
                        isKilled = false;
                        break;
                    }
                }

                if (isKilled)
                {
                    foreach (Point f in ships[ind].body)
                    {
                        MarkCell(f, CellState.destroyed);
                    }
                }
            }
        }

        private void PlaceShip(Point p)
        {
            if (index + 1 < st.Length)
            {
                index++;

                Ship ship = new Ship(st[index], p , direction);

                if (IsValidLocation(ship))
                {
                    ships.Add(ship);
                    MarkLocation(ship, CellState.busy);
                    draw.Invoke(map);
                }
                else
                {
                    index--;
                }

                if (index + 1 == st.Length)
                {
                    if (playerType == PlayerType.bot)
                    {
                        for (int i = 0; i < 10; ++i)
                        {
                            for (int j = 0; j < 10; ++j)
                            {
                                MarkCell(new Point(i, j), CellState.empty);
                                draw.Invoke(map);
                                index++;
                            }
                        }
                    }
                }
            }
        }

        private void CheckAdjCell(int i ,int j)
        {
            if (i < 0 || i > 9) return;
            if (j < 0 || j > 9) return;
            if (map[i, j] == CellState.busy) return;

            MarkCell(new Point(i, j), CellState.adjacent);
        }

        private void CheckAdjLocation(Point p)
        {
            CheckAdjCell(p.X - 1, p.Y - 1);
            CheckAdjCell(p.X - 1, p.Y);
            CheckAdjCell(p.X - 1, p.Y + 1);
            CheckAdjCell(p.X, p.Y + 1);
            CheckAdjCell(p.X + 1, p.Y + 1);
            CheckAdjCell(p.X + 1, p.Y);
            CheckAdjCell(p.X + 1, p.Y - 1);
            CheckAdjCell(p.X, p.Y - 1);
        }

        private void MarkCell(Point p, CellState state) => map[p.X, p.Y] = state;


        private void MarkLocation(Ship ship, CellState state)
        {
            for(int i = 0; i < ship.body.Count; ++i)
            {
                MarkCell(ship.body[i], state);
            }
            for (int i = 0; i < ship.body.Count; ++i)
            {
                CheckAdjLocation(ship.body[i]);
            }
        }

        private bool IsValidCell(Point p)
        {
            if (p.X < 0 || p.X > 9) return false;
            if (p.Y < 0 || p.Y > 9) return false;

            return map[p.X, p.Y] == CellState.empty;
        }

        private bool IsValidLocation(Ship ship)
        {
            for(int i = 0; i < ship.body.Count; ++i)
            {
                if (!IsValidCell(ship.body[i]))
                    return false;
            }

            return true;
        }

    }
}
