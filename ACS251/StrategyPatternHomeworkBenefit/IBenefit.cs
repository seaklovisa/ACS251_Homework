using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHomeworkBenefit
{
    public interface IBenefit
    {
        int VisaBenefit(double price);
    }
}