using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBallByEvent
{
    internal class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;

        private BallEventArgs ballEventArgs;

        public Ball()
        {
        }

        public void OnBallInPlay(EventArgs e)
        {
            if (e is BallEventArgs)
            {
                this.ballEventArgs = e as BallEventArgs;
                BallInPlay(this, this.ballEventArgs);
            }
        }
    }
}