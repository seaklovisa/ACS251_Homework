using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StrategyPatternHomework
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private TicketController ticketController;

        public MainWindow()
        {
            InitializeComponent();
            ticketController = new TicketController();

            this.StudentOff.ItemsSource = ticketController.StudenOffList();
            ChildOff.ItemsSource = ticketController.ChildrenOffList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ticketType = this.TicketType.SelectionBoxItem.ToString();
            ticketController.Calculate(int.Parse(this.ticketNumber.Text), ticketType, StudentOff.SelectedValue == null ? "" : StudentOff.SelectedValue.ToString(), ChildOff.SelectedValue == null ? "" : ChildOff.SelectedValue.ToString());
            text1.Text = ticketController.DisplayMessage;
        }

        private void StudentOff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ChildOff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void TicketType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}