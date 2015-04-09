using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternHomeworkByEvent
{
    internal interface IObserver
    {
        void MurderAttack(EventArgs e);
    }
}