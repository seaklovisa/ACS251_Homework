using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal class NewspaperOffice : IObservable
    {
        private List<IObserver> observers;
        private NewsData newsData;

        public NewspaperOffice()
        {
            observers = new List<IObserver>();
            newsData = new NewsData();
        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void DeAttach(IObserver o)
        {
            observers.Remove(o);
        }

        public void OnNewsChanged(int headLinesNews, int entertainmentNews, int societyNews)
        {
            if (newsData.HeadLinesNews != headLinesNews || newsData.EntertainmentNews != entertainmentNews || newsData.SocietyNews != societyNews)
                Notify();
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(newsData);
            }
        }
    }
}