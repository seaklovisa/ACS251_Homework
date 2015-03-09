using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal class GameData
    {
        public int Damage { get; set; }

        public GameData()
        {
            Random random = new Random();
            Damage = random.Next(1000, 1500);
        }
    }
}