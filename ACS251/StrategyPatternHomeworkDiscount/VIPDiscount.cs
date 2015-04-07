using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPatternHomeworkDiscount
{
    public class VIPDiscount:Discount
    {
        #region Discount 成員

        public string DiscountName
        {
            get { return "花旗卡折扣"; }
        }

        public double Calculate(double price)
        {
            return price * 0.5;
        }

        #endregion
    }
}