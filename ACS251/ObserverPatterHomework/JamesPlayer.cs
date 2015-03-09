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
        public override string Update(GameData gameData)
        {
            this.HP = this.HP - gameData.Damage;
            return help(gameData);
        }
    }
}