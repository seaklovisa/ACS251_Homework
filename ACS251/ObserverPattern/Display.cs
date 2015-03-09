using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal abstract class Display : IObserver
    {
        public string Name { get; set; }

        public abstract void Update(NewsData newsData);
    }
}