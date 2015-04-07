using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPatternHomeworkBenefit;
using StrategyPatternHomeworkDiscount;

namespace StrategyPatternHomework
{
    internal abstract class MovieTicket
    {
        public Discount discount;
        public IBenefit benefit;

        public double Price { get; set; }

        public string TicketName { get; set; }

        public double DiscountOff(double price)
        {
            return discount.Calculate(price);
        }

        public int Benefit(double price)
        {
            return benefit.VisaBenefit(price);
        }
    }
}