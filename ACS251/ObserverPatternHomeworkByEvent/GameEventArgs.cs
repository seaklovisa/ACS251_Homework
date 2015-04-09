using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternHomeworkByEvent
{
    internal class GameEventArgs : EventArgs
    {
        public int Damage { get; set; }

        public Player PlayerAttacted { get; set; }

        public List<string> Partner { get; set; }
    }
}