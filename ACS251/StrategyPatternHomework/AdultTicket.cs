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
    internal class AdultTicket : MovieTicket
    {
        public AdultTicket()
        {
            this.discount = (Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(ConfigurationManager.AppSettings[ConfigurationManager.AppSettings["StudentDefaultOff"].ToString()]);
            this.benefit = (IBenefit)Assembly.Load("StrategyPatternHomeworkBenefit").CreateInstance(ConfigurationManager.AppSettings["VisaBenefit"].ToString());
        }
    }
}