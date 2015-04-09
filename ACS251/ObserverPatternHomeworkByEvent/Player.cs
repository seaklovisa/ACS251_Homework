using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternHomeworkByEvent
{
    internal abstract class Player
    {
        public string Name { get; set; }

        public int HP { get; set; }

        public int Level { get; set; }

        public string DisplayMessage { get; set; }

        public string StatusMessage { get; set; }

        public abstract void MurderAttack(object sender, EventArgs e);
    }
}