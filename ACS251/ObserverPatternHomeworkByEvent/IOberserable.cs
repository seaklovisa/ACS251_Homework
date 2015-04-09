using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternHomeworkByEvent
{
    internal interface IOberserable
    {
        void JoinGame(IObserver player);

        void ExitGame(IObserver player);

        void Notify();
    }
}