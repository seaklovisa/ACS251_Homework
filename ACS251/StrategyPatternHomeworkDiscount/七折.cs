using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternHomeworkDiscount
{
    internal class 七折 : Discount
    {
        #region Discount 成員

        public string DiscountName
        {
            get { return "七折"; }
        }

        public double Calculate(double price)
        {
            return price * 0.7;
        }

        #endregion Discount 成員
    }
}