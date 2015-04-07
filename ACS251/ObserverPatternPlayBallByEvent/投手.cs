﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBallByEvent
{
    internal class 投手
    {
        public string Name { get; set; }

        public string DisplayMessage { get; set; }

        public void 接滾地球(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEvnetArgs = e as BallEventArgs;
                if (ballEvnetArgs.Angle <= 60 && ballEvnetArgs.distance <= 95)
                {
                    this.DisplayMessage = string.Format("這球仰角不高才{0}度，看起來大約飛{1}英尺，我應該街的到\n", ballEvnetArgs.Angle, ballEvnetArgs.distance);
                }
            }
        }
    }
}