using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBallByEvent
{
    internal interface IBallEventProvider
    {
        void RegisteHandler(IBallEventHandler handler);

        void RemoveHandler(IBallEventHandler handler);

        void OnBallInPlay(EventArgs e);

        void Notify();
    }
}