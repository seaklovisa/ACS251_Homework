using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal interface IObservable
    {
        void Attach(IObserver o);

        void DeAttach(IObserver o);

        void Notify();
    }
}