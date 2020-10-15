/*
* Author: Austen Clemons
* Class name: MainWindow.xaml.cs
* Purpose: contains all c# code for the main window
*/

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// when the program starts it smacks a frontpage on there and also an orderwindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            

            mainWindowBorder.Child = new FrontPage();

            orderWindowBorder.Child = new OrderWindow();


            DataContext = new Order();
            Order order = (Order)DataContext;
            OrderWindow orderWindow = (OrderWindow)orderWindowBorder.Child;
            orderWindow.numberLabel.Content = "Order Number: " + order.Number;


            mainWindowBorder.DataContext = this.DataContext;
            orderWindowBorder.DataContext = this.DataContext;
        }

        private void newOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //DataContext = new Order();
            Order order = (Order)DataContext;

            if (order.Items.Count > 0)
            {
                while(order.Items.Count > 0)
                {
                    order.Items.RemoveAt(0);
                }
                ++order.Number;
            }
            

            OrderWindow orderWindow = (OrderWindow)orderWindowBorder.Child;
            orderWindow.numberLabel.Content = "Order Number: " + order.Number;
            orderWindow.orderList.Items.Clear();
            foreach (IOrderItem item in order.Items)
            {
                orderWindow.orderList.Items.Add(item);
            }
        }
    }
}
