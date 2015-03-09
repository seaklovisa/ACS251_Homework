using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal interface IOberserable
    {
        void JoinGame(IObserver player);

        void ExitGame(IObserver player);

        string Notify();
    }
}