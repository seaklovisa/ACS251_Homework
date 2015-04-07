using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal abstract class Player : IObserver
    {
        public string Name { get; set; }

        public int HP { get; set; }

        public int Level { get; set; }

        public string DisplayMessage { get; set; }

        public abstract void MurderAttack(EventArgs e);
    }
}