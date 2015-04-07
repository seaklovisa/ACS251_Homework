using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternHomework
{
    internal class SimpleFactory
    {
        public static MovieTicket TicketStore(string type)
        {
            if (type.Equals("學生票"))
                return new StudentTicket { Price = 500, TicketName = "學生票" };
            else if (type.Equals("屁孩票"))
                return new ChildrenTicket { Price = 400, TicketName = "屁孩票" };
            else if (type.Equals("少年票"))
                return new YoungTicketh { Price = 450, TicketName = "少年票" };
            else
                return new AdultTicket { Price = 550, TicketName = "成人票" };
        }
    }
}