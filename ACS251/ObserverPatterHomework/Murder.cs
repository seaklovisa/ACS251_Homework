using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal class Murder : IOberserable
    {
        public List<IObserver> players;

        public GameEventArgs gameEventArgs;

        public Murder()
        {
            players = new List<IObserver>();
        }

        public void JoinGame(IObserver player)
        {
            players.Add(player);
        }

        public void ExitGame(IObserver player)
        {
            players.Remove(player);
        }

        public void OnMurderFire(EventArgs e)
        {
            if (e is GameEventArgs)
            {
                gameEventArgs = e as GameEventArgs;
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var player in players)
            {
                player.MurderAttack(this.gameEventArgs);
            }
        }
    }
}