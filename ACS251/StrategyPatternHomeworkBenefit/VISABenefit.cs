using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHomeworkBenefit
{
    internal class VISABenefit : IBenefit
    {
        public int VisaBenefit(double price)
        {
            return (int)(price / 300);
        }
    }
}