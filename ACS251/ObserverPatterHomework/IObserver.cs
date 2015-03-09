using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPatterHomework
{
    internal interface IObserver
    {
        string Update(GameData gameData);
    }
}