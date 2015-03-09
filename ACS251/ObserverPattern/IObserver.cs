using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal interface IObserver
    {
        void Update(NewsData newsData);
    }
}