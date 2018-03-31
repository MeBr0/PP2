using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class main : Form
    {
        Brain brain;
        int CellSize;

        public main()
        {
            InitializeComponent();
            CellSize = 30;
        }

        private void StartGame(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; ++i)
            {
                for(int j = 0; j < 10; ++j)
                {
                    Button btn = new Button();

                    btn.Name = i + "_" + j;
                    btn.Click += BtnClick;
                    btn.Size = new Size(CellSize, CellSize);
                    btn.Location = new Point(i * CellSize, j * CellSize);

                    mainPanel.Controls.Add(btn);
                }
            }

            Button switcher = new Button();

            switcher.Name = "switcher";
            switcher.Click += SwitchClick;
            switchPanel.Controls.Add(switcher);
            switcher.Size = new Size(CellSize, CellSize);

            brain = new Brain(DrawBtns);
        }

        private void SwitchClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Switch();

            if (switcherText.Text == "Ship Direction: Up-to-Down")
                switcherText.Text = "Ship Direction: Left-to-Right";

            else
                switcherText.Text = "Ship Direction: Up-to-Down";
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Process(btn.Name);
        }

        private void DrawBtns(CellState[,] map)
        {
            Color color = Color.White;

            for(int i = 0; i < 10; ++i)
            {
                for(int j = 0; j < 10; ++j)
                {
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
                            color = Color.Red;
                            break;
                        case CellState.missed:
                            color = Color.Gray;
                            break;
                        case CellState.masked:
                            color = Color.DarkGray;
                            break;
                    }

                    mainPanel.Controls[10 * i + j].BackColor = color;
                }
            }
        }
    }
}
