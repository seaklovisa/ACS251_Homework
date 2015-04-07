using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBall
{
    internal class BallEventArgs : EventArgs
    {
        public double Angle { get; set; }

        public double distance { get; set; }
    }
}