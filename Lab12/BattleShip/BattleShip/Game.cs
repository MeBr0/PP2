﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleShip
{
    enum PlayerType
    {
        human,
        bot
    }

    class Game
    {
        public PlayerPanel player1;
        public PlayerPanel player2;

        public bool isEnded;

        public Game(PlayerType pl1, PlayerType pl2)
        {
            player1 = new PlayerPanel(pl1, PanelPos.left, BotTurn, GameOver);
            player2 = new PlayerPanel(pl2, PanelPos.right, BotTurn, GameOver);

            isEnded = false;
        }

        private void BotTurn()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, player2.brain.notShooted.Count);
            int i = player2.brain.notShooted[a] / 10;
            int j = player2.brain.notShooted[a] % 10;

            while (player1.brain.Play(string.Format("{0}_{1}", i, j)))
            {
                Thread.Sleep(500);

                player2.brain.notShooted.Remove(player2.brain.notShooted[a]);

                a = rnd.Next(0, player2.brain.notShooted.Count);
                i = player2.brain.notShooted[a] / 10;
                j = player2.brain.notShooted[a] % 10;
            }
        }

        private void GameOver()
        {
            player1.Enabled = false;
            player2.Enabled = false;

            isEnded = true;

            if (player1.brain.isWinner)
                player1.Victory("player1");

            else
                player2.Victory("player2");
        }
    }
}