using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    /// <summary>
    /// 兔兔
    /// </summary>
    internal class RabbitPlayer : Player
    {
        public override string Update(GameData gameData)
        {
            this.HP = this.HP - gameData.Damage;
            return help(gameData);
        }
    }
}