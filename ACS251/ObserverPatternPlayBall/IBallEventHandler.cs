using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBall
{
    internal interface IBallEventHandler
    {
        void HandleFunction(EventArgs e);
    }
}