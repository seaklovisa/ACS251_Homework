using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using StrategyPatternHomeworkDiscount;

namespace StrategyPatternHomework
{
    internal class TicketController
    {
        private double total = 0.0;
        private int totalBenefit = 0;
        private MovieTicket movieTicket;

        private List<Discount> discount;
        private List<ComboItems> studentOff;
        private List<ComboItems> childrenOff;

        public string DisplayMessage { get; set; }

        public int Benefit { get; set; }

        private string TmpMessage { get; set; }

        public TicketController()
        {
            studentOff = new List<ComboItems>();
            childrenOff = new List<ComboItems>();
            discount = new List<Discount>();

            System.Collections.Specialized.NameValueCollection appsettings = ConfigurationManager.AppSettings;

            foreach (var key in appsettings.AllKeys)
            {
                if ((Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(appsettings[key]) is Discount)
                {
                    discount.Add((Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(appsettings[key]));
                }
            }
        }

        public List<ComboItems> StudenOffList()
        {
            foreach (var unit in discount)
            {
                studentOff.Add(new ComboItems { OffName = unit.DiscountName, OffValue = unit.DiscountName });
            }

            return studentOff;
        }

        public List<ComboItems> ChildrenOffList()
        {
            foreach (var unit in discount)
            {
                childrenOff.Add(new ComboItems { OffName = unit.DiscountName, OffValue = unit.DiscountName });
            }

            return childrenOff;
        }

        public void StudentOff(string ticketOff)
        {
            movieTicket.discount = (Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(ConfigurationManager.AppSettings[ticketOff].ToString());
        }

        public void ChildrenOff(string ticketOff)
        {
            movieTicket.discount = (Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(ConfigurationManager.AppSettings[ticketOff].ToString());
        }

        public void YoungOff(string ticketOff)
        {
            movieTicket.discount = (Discount)Assembly.Load("StrategyPatternHomeworkDiscount").CreateInstance(ConfigurationManager.AppSettings[ticketOff].ToString());
        }

        public void Calculate(int ticketNumber, string ticketType, string studentOff, string childOff)
        {
            movieTicket = SimpleFactory.TicketStore(ticketType);

            if (movieTicket.TicketName == "學生票" && studentOff != "")
                StudentOff(studentOff);
            else if (movieTicket.TicketName == "屁孩票" && childOff != "")
                ChildrenOff(childOff);

            total += ticketNumber * movieTicket.DiscountOff(movieTicket.Price);
            Benefit = movieTicket.Benefit(ticketNumber * movieTicket.DiscountOff(movieTicket.Price));
            totalBenefit += Benefit;

            TmpMessage += String.Format("一張{0} 原價{1}元 特價{2}元 共{3}張 小計：{4} ，點數：{5}", ticketType, movieTicket.Price
                , movieTicket.DiscountOff(movieTicket.Price), ticketNumber, ticketNumber * movieTicket.DiscountOff(movieTicket.Price), Benefit);
            TmpMessage += "\n";

            DisplayMessage = TmpMessage;
            DisplayMessage += String.Format("總計：{0}，點數：{1}", total, totalBenefit);
        }
    }

    internal class ComboItems
    {
        public string OffName { get; set; }

        public string OffValue { get; set; }
    }
}