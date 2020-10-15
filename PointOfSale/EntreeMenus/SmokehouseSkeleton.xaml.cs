/*
* Author: Austen Clemons
* Class name: SmokehouseSkeleton.xaml.cs
* Purpose: contains all c# code for the smokehouse skeleton
*/

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
using BleakwindBuffet.Data;

namespace PointOfSale.EntreeMenus
{
    /// <summary>
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeleton : UserControl
    {
        public SmokehouseSkeleton()
        {
            InitializeComponent();
            //Sausage.DataContext = notBurg.SausageLink;
            //Egg.DataContext = notBurg.Egg;
            //Hashbrowns.DataContext = notBurg.HashBrowns;
            //Pancake.DataContext = notBurg.Pancake;
        }
        /// <summary>
        /// goes back to the prvious menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new TypeMenus.Entrees();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            BleakwindBuffet.Data.Entrees.SmokehouseSkeleton notBurg = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();

            notBurg.SausageLink = !((bool)Sausage.IsChecked);
            notBurg.Egg = !((bool)Egg.IsChecked);
            notBurg.HashBrowns = !((bool)Hashbrowns.IsChecked);
            notBurg.Pancake = !((bool)Pancake.IsChecked);
            order.Add(notBurg);


            //navigates to the main window and the order list window
            Border mainWindowBorder = (Border)this.Parent;
            Grid mainWindowGrid = (Grid)mainWindowBorder.Parent;
            MainWindow mainWindow = (MainWindow)mainWindowGrid.Parent;
            OrderWindow orderWindow = (OrderWindow)mainWindow.orderWindowBorder.Child;

            orderWindow.orderList.Items.Clear();
            foreach (IOrderItem item in order.Items)
            {
                orderWindow.orderList.Items.Add(item);
            }
        }
    }
}
