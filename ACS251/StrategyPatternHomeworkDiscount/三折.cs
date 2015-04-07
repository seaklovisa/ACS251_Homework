using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternHomeworkDiscount
{
    internal class 三折 : Discount
    {
        #region Discount 成員

        public string DiscountName
        {
            get { return "三折"; }
        }

        public double Calculate(double price)
        {
            return price * 0.3;
        }

        #endregion Discount 成員
    }
}