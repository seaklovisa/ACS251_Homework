using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal class GameCenter
    {
        private JamesPlayer james;
        private BearPlayer bear;
        private BreadPlayer bread;
        private RabbitPlayer rabbit;
        private Murder murder;

        public string DisplayMessage { get; set; }

        public GameCenter()
        {
            james = new JamesPlayer { Name = "詹姆士", HP = 4200, Level = 11 };
            bear = new BearPlayer { Name = "雄大", HP = 5000, Level = 10 };
            bread = new BreadPlayer { Name = "饅頭人", HP = 4600, Level = 11 };
            rabbit = new RabbitPlayer { Name = "兔兔", HP = 4300, Level = 10 };
            murder = new Murder();

            murder.JoinGame(james);
            murder.JoinGame(bear);
            murder.JoinGame(bread);
            murder.JoinGame(rabbit);
        }

        public void IsExistsPlayer()
        {
        }

        public void StartMurder()
        {
            GameEventArgs gameEventArgs = new GameEventArgs();
            gameEventArgs.Damage = new Random().Next(1000, 1500);
            gameEventArgs.PlayerAttacted = ((Player)murder.players[new Random().Next(0, 4)]).Name;

            List<string> partner = new List<string>();
            foreach (var player in murder.players)
            {
                if (((Player)player).Name != gameEventArgs.PlayerAttacted)
                    partner.Add(((Player)player).Name);
            }
            gameEventArgs.Partner = partner;
            murder.OnMurderFire(gameEventArgs);

            foreach (var player in murder.players)
            {
                this.DisplayMessage += ((Player)player).DisplayMessage;
            }
        }
    }
}