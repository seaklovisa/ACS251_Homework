using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    /// <summary>
    /// 饅頭人
    /// </summary>
    internal class BreadPlayer : Player
    {
        public override void MurderAttack(EventArgs e)
        {
            if (e is GameEventArgs)
            {
                GameEventArgs gameEventArgs = e as GameEventArgs;

                string partner = "";
                foreach (var player in gameEventArgs.Partner)
                {
                    partner += player + "，";
                }

                this.DisplayMessage = String.Format("我是{0},我被攻擊了，{1}快來救我，我的生命值只剩{2}\n"
                   , this.Name, partner, ((Player)(gameEventArgs.PlayerAttacted)).HP);
            }
        }
    }
}