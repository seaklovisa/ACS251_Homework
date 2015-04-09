using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatternHomeworkByEvent
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

        public int PlayersCount { get { return murder.players[murder.MurderFireKey] == null ? 0 : murder.players[murder.MurderFireKey].GetInvocationList().Count(); } }

        public GameCenter()
        {
            murder = new Murder();
        }

        public string setJamesStatus()
        {
            return IsExistsPlayer(james) == false ? "" : james.StatusMessage;
        }

        public string setBreadStatus()
        {
            return IsExistsPlayer(bread) == false ? "" : bread.StatusMessage;
        }

        public string setRabbitStatus()
        {
            return IsExistsPlayer(rabbit) == false ? "" : rabbit.StatusMessage;
        }

        public string setBearStatus()
        {
            return IsExistsPlayer(bear) == false ? "" : bear.StatusMessage;
        }

        public string JamesJoinOrLeaveGame()
        {
            james = new JamesPlayer { Name = "詹姆士", HP = 4200, Level = 11 };
            james.StatusMessage = String.Format("LV：{0} \n HP：{1}", james.Level, james.HP);
            AddIsExistsPlayer(james);
            return james.Name;
        }

        public string BearJoinOrLeaveGame()
        {
            bear = new BearPlayer { Name = "雄大", HP = 5000, Level = 10, StatusMessage = String.Format("LV：{0} \n HP：{1}", 5000, 10) };
            bear.StatusMessage = String.Format("LV：{0} \n HP：{1}", bear.Level, bear.HP);
            AddIsExistsPlayer(bear);
            return bear.Name;
        }

        public string BreadJoinOrLeaveGame()
        {
            bread = new BreadPlayer { Name = "饅頭人", HP = 4600, Level = 11, StatusMessage = String.Format("LV：{0} \n HP：{1}", 4600, 11) };
            bread.StatusMessage = String.Format("LV：{0} \n HP：{1}", bread.Level, bread.HP);
            AddIsExistsPlayer(bread);
            return bread.Name;
        }

        public string RabbitJoinOrLeaveGame()
        {
            rabbit = new RabbitPlayer { Name = "兔兔", HP = 4300, Level = 10, StatusMessage = String.Format("LV：{0} \n HP：{1}", 4300, 10) };
            rabbit.StatusMessage = String.Format("LV：{0} \n HP：{1}", rabbit.Level, rabbit.HP);
            AddIsExistsPlayer(rabbit);
            return rabbit.Name;
        }

        private void AddIsExistsPlayer(Player player)
        {
            if (murder.players[murder.MurderFireKey] != null)
            {
                var q = from playerr in murder.players[murder.MurderFireKey].GetInvocationList()
                        where playerr.Target == player
                        select playerr;

                if (q.Count() > 0)
                    murder.MurderFire -= player.MurderAttack;
                else
                    murder.MurderFire += player.MurderAttack;
            }
            else
                murder.MurderFire += player.MurderAttack;
        }

        private bool IsExistsPlayer(Player player)
        {
            if (murder.players[murder.MurderFireKey] == null)
                return false;
            else
            {
                var q = from playerr in murder.players[murder.MurderFireKey].GetInvocationList()
                        where playerr.Target == player
                        select playerr;

                if (q.Count() > 0) return true;
                else
                    return false;
            }
        }

        public void StartMurder()
        {
            GameEventArgs gameEventArgs = new GameEventArgs();

            gameEventArgs.Damage = new Random().Next(1000, 1500);

            gameEventArgs.PlayerAttacted = ((Player)((murder.players[murder.MurderFireKey].GetInvocationList())[new Random().Next(0

                , murder.MurderFireInvocationListCount)]).Target);

            (gameEventArgs.PlayerAttacted).HP =
                ((gameEventArgs.PlayerAttacted).HP - gameEventArgs.Damage) <= 0 ? 0 : ((gameEventArgs.PlayerAttacted).HP - gameEventArgs.Damage);

            List<string> partner = new List<string>();

            foreach (var player in (murder.players[murder.MurderFireKey].GetInvocationList()))
            {
                if (((Player)player.Target).Name != ((gameEventArgs.PlayerAttacted).Name))
                    partner.Add(((Player)player.Target).Name);
            }
            gameEventArgs.Partner = partner;

            murder.OnMurderFire(gameEventArgs);

            foreach (var player in murder.players[murder.MurderFireKey].GetInvocationList())
            {
                this.DisplayMessage += ((Player)player.Target).DisplayMessage + Environment.NewLine;
            }

            if (((gameEventArgs.PlayerAttacted).HP == 0))
                murder.MurderFire -= gameEventArgs.PlayerAttacted.MurderAttack;
        }
    }
}