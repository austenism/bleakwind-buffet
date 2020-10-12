/*
* Author: Austen Clemons
* Class name: OrderWindow.xaml.cs
* Purpose: contains all c# code for the order window
*/

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : UserControl
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            object ob = orderList.SelectedItem;
            if(ob != null)
            {
                order.Remove((IOrderItem)ob);
            }

            orderList.Items.Clear();
            foreach (IOrderItem item in order.Items)
            {
                orderList.Items.Add(item);
            }
        }
    }
}
