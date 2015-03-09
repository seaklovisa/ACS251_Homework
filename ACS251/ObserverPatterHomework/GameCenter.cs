using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    /// <summary>
    /// 遊戲中心 模擬攻擊
    /// </summary>
    internal class GameCenter : IOberserable
    {
        private List<IObserver> players;
        private GameData gameData;

        public int PlayersCount { get { return players.Count; } }

        public List<IObserver> GetPlayers()
        {
            List<IObserver> tmp = players;
            return tmp;
        }

        //人在踢掉 不在加入
        public void IsExistsPlayer(IObserver player)
        {
            if (players.Contains(player))
                ExitGame(player);
            else
                JoinGame(player);
        }

        public GameCenter()
        {
            players = new List<IObserver>();
            gameData = new GameData();
        }

        public void JoinGame(IObserver player)
        {
            players.Add(player);
        }

        public void ExitGame(IObserver player)
        {
            players.Remove(player);
        }

        public string Notify()
        {
            gameData.Damage = new Random().Next(1000, 1500);
            //傳回訊息 表示廣播受到攻擊 ?(好像怪怪)
            string msg = players[new Random().Next(0, players.Count)].Update(gameData);

            return msg;
        }
    }
}