using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternHomeworkDiscount
{
    public interface Discount
    {
         string DiscountName { get; }

        double Calculate(double price);
    }
}