using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBall
{
    internal class 觀眾 : IBallEventHandler
    {
        public string Name { get; set; }

        public string DisplayMessage { get; set; }

        public void HandleFunction(EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Angle <= 30 && ballEventArgs.distance >= 400)
                {
                    this.DisplayMessage = string.Format("這球打得好，我要來搶這球");
                }
            }
        }
    }
}