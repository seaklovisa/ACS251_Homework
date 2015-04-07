using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

using StrategyPatternHomeworkBenefit;
using StrategyPatternHomeworkDiscount;

namespace StrategyPatternHomework
{
    internal class YoungTicketh : MovieTicket
    {
        public YoungTicketh()
        {
            this.discount = (Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(ConfigurationManager.AppSettings[ConfigurationManager.AppSettings["YoungDefaultOff"].ToString()]);
            this.benefit = (IBenefit)Assembly.Load("StrategyPatternHomeworkBenefit").CreateInstance(ConfigurationManager.AppSettings["VisaBenefit"].ToString());
        }
    }
}