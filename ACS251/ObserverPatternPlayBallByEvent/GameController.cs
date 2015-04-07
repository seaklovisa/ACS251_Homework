using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternPlayBallByEvent
{
    internal class GameController
    {
        private 投手 田中將大;
        private 觀眾 張元鴻;
        private Ball ball;

        public string DisplayMessage { get; set; }

        public GameController()
        {
            田中將大 = new 投手 { Name = "田中將大" };
            張元鴻 = new 觀眾 { Name = "張元鴻" };
            ball = new Ball();
            this.DisplayMessage = string.Format("現在投手是{0}，場上有觀眾{1}", this.田中將大.Name, this.張元鴻.Name);
            ball.BallInPlay += new EventHandler<BallEventArgs>(this.田中將大.接滾地球);
            ball.BallInPlay += (this.張元鴻.搶全壘打球);
        }

        //打擊
        public void PlayBall(double angle, double distance)
        {
            ball.OnBallInPlay(new BallEventArgs { Angle = angle, distance = distance });
            this.DisplayMessage += this.田中將大.DisplayMessage;
            this.DisplayMessage += this.張元鴻.DisplayMessage;
        }
    }
}