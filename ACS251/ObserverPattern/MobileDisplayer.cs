using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal class MobileDisplayer : Display
    {
        public override void Update(NewsData newsData)
        {
            Console.WriteLine("娛樂新聞：{0},頭條：{0},社會新聞：{0}", newsData.EntertainmentNews, newsData.HeadLinesNews, newsData.SocietyNews);
        }
    }
}