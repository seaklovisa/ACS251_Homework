using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBallByEvent
{
    internal interface IBallEventHandler
    {
        void HandleFunction(EventArgs e);
    }
}