using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ObserverPatternHomeworkByEvent
{
    internal class Murder
    {
        public GameEventArgs gameEventArgs;

        private static readonly object murderFireKey = new object();

        public object MurderFireKey
        {
            get { return murderFireKey; }
        }

        public int MurderFireInvocationListCount
        {
            get
            {
                return (players[murderFireKey].GetInvocationList()).Length;
            }
        }

        public event EventHandler<GameEventArgs> MurderFire
        {
            add { players.AddHandler(murderFireKey, value); }
            remove { players.RemoveHandler(murderFireKey, value); }
        }

        //public event EventHandler<GameEventArgs> MurderFire;

        public EventHandlerList players;

        public Murder()
        {
            players = new EventHandlerList();
        }

        public virtual void OnMurderFire(EventArgs e)
        {
            if (e is GameEventArgs)
            {
                gameEventArgs = e as GameEventArgs;

                ((EventHandler<GameEventArgs>)players[murderFireKey])(this, gameEventArgs);

                //MurderFire(this, gameEventArgs);
            }
        }

        /*
        public void Notify()
        {
            foreach (var player in players)
            {
                player.MurderAttack(this.gameEventArgs);
            }
        }
        */
    }
}