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

        public string StatusMessage { get; set; }

        public int PlayersCount { get { return murder.players.Count; } }

        public GameCenter()
        {
            //james = new JamesPlayer { Name = "詹姆士", HP = 4200, Level = 11 };
            //bear = new BearPlayer { Name = "雄大", HP = 5000, Level = 10 };
            //bread = new BreadPlayer { Name = "饅頭人", HP = 4600, Level = 11 };
            //rabbit = new RabbitPlayer { Name = "兔兔", HP = 4300, Level = 10 };
            murder = new Murder();
        }

        public string setJamesStatus()
        {
            if (murder.players.Contains(james))
                return String.Format("LV：{0} \n HP：{1}", james.Level, james.HP);
            else
                return "";
        }

        public string setbreadStatus()
        {
            if (murder.players.Contains(bread))
                return String.Format("LV：{0} \n HP：{1}", bread.Level, bread.HP);
            else
                return "";
        }

        public string setrabbitStatus()
        {
            if (murder.players.Contains(rabbit))
                return String.Format("LV：{0} \n HP：{1}", rabbit.Level, rabbit.HP);
            else
                return "";
        }

        public string setBearStatus()
        {
            if (murder.players.Contains(bear))
                return String.Format("LV：{0} \n HP：{1}", bear.Level, bear.HP);
            else
                return "";
        }

        public string JamesJoinOrLeaveGame()
        {
            james = new JamesPlayer { Name = "詹姆士", HP = 4200, Level = 11 };
            IsExistsPlayer(james);
            return james.Name;
        }

        public string BearJoinOrLeaveGame()
        {
            bear = new BearPlayer { Name = "雄大", HP = 5000, Level = 10 };
            IsExistsPlayer(bear);
            return bear.Name;
        }

        public string BreadJoinOrLeaveGame()
        {
            bread = new BreadPlayer { Name = "饅頭人", HP = 4600, Level = 11 };
            IsExistsPlayer(bread);
            return bread.Name;
        }

        public string RabbitJoinOrLeaveGame()
        {
            rabbit = new RabbitPlayer { Name = "兔兔", HP = 4300, Level = 10 };
            IsExistsPlayer(rabbit);
            return rabbit.Name;
        }

        private void IsExistsPlayer(IObserver player)
        {
            if (murder.players.Contains(player))
                murder.players.Remove(player);
            else
                murder.players.Add(player);
        }

        public void StartMurder()
        {
            GameEventArgs gameEventArgs = new GameEventArgs();
            gameEventArgs.Damage = new Random().Next(1000, 1500);
            gameEventArgs.PlayerAttacted = ((Player)murder.players[new Random().Next(0, murder.players.Count)]);

            ((Player)gameEventArgs.PlayerAttacted).HP =
                (((Player)gameEventArgs.PlayerAttacted).HP - gameEventArgs.Damage) <= 0 ? 0 : (((Player)gameEventArgs.PlayerAttacted).HP - gameEventArgs.Damage);

            List<string> partner = new List<string>();
            foreach (var player in murder.players)
            {
                if (((Player)player).Name != (((Player)gameEventArgs.PlayerAttacted).Name))
                    partner.Add(((Player)player).Name);
            }
            gameEventArgs.Partner = partner;

            murder.OnMurderFire(gameEventArgs);

            foreach (var player in murder.players)
            {
                this.DisplayMessage += ((Player)player).DisplayMessage + Environment.NewLine;
            }

            if ((((Player)gameEventArgs.PlayerAttacted).HP == 0))
                IsExistsPlayer(gameEventArgs.PlayerAttacted);
        }
    }
}