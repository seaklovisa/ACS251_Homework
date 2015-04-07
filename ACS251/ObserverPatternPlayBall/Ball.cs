using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBall
{
    internal class Ball : IBallEventProvider
    {
        private List<IBallEventHandler> handlers;

        private BallEventArgs ballEventArgs;

        public Ball()
        {
            handlers = new List<IBallEventHandler>();
        }

        public void RegisteHandler(IBallEventHandler handler)
        {
            handlers.Add(handler);
        }

        public void RemoveHandler(IBallEventHandler handler)
        {
            handlers.Remove(handler);
        }

        public void OnBallInPlay(EventArgs e)
        {
            if (e is BallEventArgs)
            {
                this.ballEventArgs = e as BallEventArgs;
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var handler in handlers)
                handler.HandleFunction(this.ballEventArgs);
        }
    }
}