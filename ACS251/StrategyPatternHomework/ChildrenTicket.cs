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
    internal class ChildrenTicket : MovieTicket
    {
        public ChildrenTicket()
        {
            this.discount = (Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(ConfigurationManager.AppSettings[ConfigurationManager.AppSettings["ChildDefaultOff"].ToString()]);
            this.benefit = (IBenefit)Assembly.Load("StrategyPatternHomeworkBenefit").CreateInstance(ConfigurationManager.AppSettings["VisaBenefit"].ToString());
        }
    }
}