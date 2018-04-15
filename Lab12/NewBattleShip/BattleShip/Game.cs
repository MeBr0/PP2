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

    enum GameMode
    {
        construction,
        play
    }

    class Game
    {
        public PlayerPanel human;
        public PlayerPanel bot;

        public bool isEnded;
        PlayerType current;
        GameMode mode;

        public Game(PlayerType pl1, PlayerType pl2)
        {
            human = new PlayerPanel(pl1, PanelPos.left, BotTurn, GameOver);
            bot = new PlayerPanel(pl2, PanelPos.right, BotTurn, GameOver);

            isEnded = false;
            mode = GameMode.construction;
            current = pl1;
        }

        public void Start()
        {
            while (!isEnded)
            {
                switch (mode)
                {
                    case GameMode.construction:
                        Construction();
                        break;
                    case GameMode.play:
                        Play();
                        break;
                }
            }
        }

        private void Construction()
        {
            bot.Enabled = false;
            human.Enabled = true;

            switch (current)
            {
                case PlayerType.human:
                    human.HumanPlacement();
                    current = PlayerType.bot;
                    break;
                case PlayerType.bot:
                    bot.BotPlacement();
                    current = PlayerType.human;
                    mode = GameMode.play;
                    break;
            }
        }

        private void Play()
        {
            bot.Enabled = true;
            human.Enabled = false;

            switch (current)
            {
                case PlayerType.human:
                    bot.HumanShot();
                    break;
                case PlayerType.bot:
                    human.BotShot();
                    break;
            }
        }

        private void BotTurn()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, bot.brain.notShooted.Count);
            int i = bot.brain.notShooted[a] / 10;
            int j = bot.brain.notShooted[a] % 10;

            while (human.brain.Play(string.Format("{0}_{1}", i, j)))
            {
                Thread.Sleep(500);

                bot.brain.notShooted.Remove(bot.brain.notShooted[a]);
                a = rnd.Next(0, bot.brain.notShooted.Count);
                i = bot.brain.notShooted[a] / 10;
                j = bot.brain.notShooted[a] % 10;
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
