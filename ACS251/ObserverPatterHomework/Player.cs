using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal abstract class Player : IObserver
    {
        public string Name { get; set; }

        public int HP { get; set; }

        public int Level { get; set; }

        public System.Windows.Forms.Label status { get; set; }

        public List<IObserver> Members { get; set; }

        public abstract string Update(GameData gameData);

        public void UpdateStatus(System.Windows.Forms.Label status)
        {
            status.Text = "生命值:" + (HP < 0 ? 0 : HP) + Environment.NewLine + "等級:" + Level;
        }

        //處理廣播訊息 ?(由gamecenter發出?)
        public string help(GameData gameData)
        {
            string message = "我是" + Name + ",我被攻擊了,";
            foreach (Player player in Members)
            {
                if (player.Name == Name)
                    continue;
                message += player.Name + ",";
            }
            message += "快來救我,我的生命只剩下:" + (this.HP < 0 ? 0 : this.HP);
            return message;
        }
    }
}