using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternHomeworkDiscount
{
    internal class 沒折 : Discount
    {
        public string DiscountName
        {
            get { return "沒折"; }
        }

        public double Calculate(double price)
        {
            return price * 1;
        }
    }
}