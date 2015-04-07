using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    /// <summary>
    /// 詹姆士
    /// </summary>
    internal class JamesPlayer : Player
    {
        public override void MurderAttack(EventArgs e)
        {
            if (e is GameEventArgs)
            {
                GameEventArgs gameEventArgs = e as GameEventArgs;

                if (gameEventArgs.PlayerAttacted.Equals(this.Name))
                {
                    this.HP = (this.HP - gameEventArgs.Damage) <= 0 ? 0 : (this.HP - gameEventArgs.Damage);
                    this.DisplayMessage += String.Format("我是{0},我被攻擊了，{1}、{2}、{3}快來救我，我的生命值只剩{4}\n"
                        , this.Name, gameEventArgs.Partner[0], gameEventArgs.Partner[1], gameEventArgs.Partner[2], this.HP);
                }
            }
        }
    }
}