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
        public override string Update(GameData gameData)
        {
            this.HP = this.HP - gameData.Damage;
            return help(gameData);
        }
    }
}