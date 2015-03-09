using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal class NewsData
    {
        public int HeadLinesNews { get; set; }

        public int EntertainmentNews { get; set; }

        public int SocietyNews { get; set; }

        public NewsData()
        {
            Random random = new Random();
            HeadLinesNews = random.Next(1, 10);
            EntertainmentNews = random.Next(20, 30);
            SocietyNews = random.Next(50, 60);
        }
    }
}