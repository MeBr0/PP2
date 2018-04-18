using System;
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
        public PlayerPanel human;
        public PlayerPanel bot;

        public bool isEnded;

        public Game(PlayerType pl1, PlayerType pl2)
        {
            human = new PlayerPanel(pl1, PanelPos.left, BotTurn, GameOver, CheckReady);
            bot = new PlayerPanel(pl2, PanelPos.right, BotTurn, GameOver, CheckReady);

            isEnded = false;
        }

        private void BotTurn()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, human.brain.notShooted.Count);
            int i = human.brain.notShooted[a] / 10;
            int j = human.brain.notShooted[a] % 10;

            while (human.brain.Play(string.Format("{0}_{1}", i, j)))
            {
                //Thread.Sleep(500);

                human.brain.notShooted.Remove(human.brain.notShooted[a]);
                a = rnd.Next(0, human.brain.notShooted.Count);
                i = human.brain.notShooted[a] / 10;
                j = human.brain.notShooted[a] % 10;
            }
        }

        private void CheckReady()
        {
            if (human.brain.state == State.ready && bot.brain.state == State.ready)
            {
                human.brain.state = State.game;
                bot.brain.state = State.game;

                if (human.playerType == PlayerType.bot)
                    bot.Enabled = false;

                else if (bot.playerType == PlayerType.bot)
                    human.Enabled = false;
            }
        }

        private void GameOver()
        {
            human.Enabled = false;
            bot.Enabled = false;

            isEnded = true;

            if (human.brain.isWinner)
                human.Victory("player2");

            else
                bot.Victory("player1");
        }
    }
}
