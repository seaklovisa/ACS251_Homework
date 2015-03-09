using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NewspaperOffice newspaperOffice = new NewspaperOffice();
            MobileDisplayer mb = new MobileDisplayer();
            newspaperOffice.Attach(mb);

            newspaperOffice.OnNewsChanged(1, 2, 3);

            Console.ReadLine();
        }
    }
}