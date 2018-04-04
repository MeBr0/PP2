using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    enum PanelPos
    {
        left,
        right
    }

    delegate void TurnDelegate();

    class PlayerPanel : Panel
    {
        int cellSize;

        public Brain brain;
        TurnDelegate turn;

        PlayerType playerType;
        PanelPos panelPos;

        public PlayerPanel(PlayerType playerType, PanelPos panelPos, TurnDelegate turn)
        {
            this.playerType = playerType;
            this.panelPos = panelPos;
            this.turn = turn;

            cellSize = 25;

            CreateBtns();

            brain = new Brain(DrawBtns);

            if (playerType == PlayerType.human)
                CreateSwitchBtn();

            if (playerType == PlayerType.bot)
            {
                while (brain.index < brain.st.Length - 1)
                {
                    int row = new Random().Next(0, 10);
                    int column = new Random().Next(0, 10);
                    string msg = string.Format("{0}_{1}", row, column);

                    brain.Process(msg);
                }
            }
        }

        private void CreateSwitchBtn()
        {
            Button btn = new Button();

            btn.Name = "switcher";
            btn.Click += Btn_Click;
            btn.Size = new Size(cellSize, cellSize);
            btn.Location = new Point(0, 10 * cellSize + cellSize);
            btn.BackColor = Color.Coral;

            Controls.Add(btn);
        }

        private void CreateBtns()
        {
            Location = new Point(cellSize, 2 * cellSize);
            Size = new Size(10 * cellSize, 12 * cellSize);

            if (panelPos == PanelPos.right)
                Location = new Point(10 * cellSize + 2 * cellSize, 2 * cellSize);

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Button btn = new Button();

                    btn.Name = i + "_" + j;
                    btn.Click += Btn_Click;
                    btn.Size = new Size(cellSize, cellSize);
                    btn.Location = new Point(i * cellSize, j * cellSize);

                    Controls.Add(btn);
                }
            }
        }

        private void DrawBtns(CellState[,] map)
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Color color = Color.White;
                    bool isEnabled = true;

                    switch (map[i, j])
                    {
                        case CellState.empty:
                        case CellState.adjacent:
                            color = Color.White;
                            break;
                        case CellState.busy:
                            color = Color.Blue;
                            break;
                        case CellState.striked:
                            isEnabled = false;
                            color = Color.Red;
                            break;
                        case CellState.missed:
                            isEnabled = false;
                            color = Color.Gray;
                            break;
                        case CellState.destroyed:
                            isEnabled = false;
                            color = Color.DarkRed;
                            break;
                    }

                    Controls[10 * i + j].BackColor = color;
                    Controls[10 * i + j].Enabled = isEnabled;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name == "switcher")
                brain.Switch(btn.Name);
                
            else if (brain.index < brain.st.Length - 1)
                brain.Process(btn.Name);


            else if (!brain.Play(btn.Name))
            {
                Thread.Sleep(300);
                turn.Invoke();
            }
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Switch(btn.Name);
        }

    }
}
