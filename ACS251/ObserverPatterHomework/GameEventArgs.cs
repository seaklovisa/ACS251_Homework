using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal class GameEventArgs : EventArgs
    {
        public int Damage { get; set; }

        public IObserver PlayerAttacted { get; set; }

        public List<string> Partner { get; set; }
    }
}