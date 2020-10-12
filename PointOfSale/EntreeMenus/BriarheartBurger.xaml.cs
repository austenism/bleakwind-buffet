/*
* Author: Austen Clemons
* Class name: BriarheartBurger.xaml.cs
* Purpose: contains all c# code for the burger
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

namespace PointOfSale.EntreeMenus
{
    /// <summary>
    /// Interaction logic for BriarheartBurger.xaml
    /// </summary>
    public partial class BriarheartBurger : UserControl
    {
        public BriarheartBurger()
        {
            InitializeComponent();
            /*Bun.DataContext = burg.Bun;
            Ketchup.DataContext = burg.Ketchup;
            Mustard.DataContext = burg.Mustard;
            Pickle.DataContext = burg.Pickle;
            Cheese.DataContext = burg.Cheese;*/
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
            BleakwindBuffet.Data.Entrees.BriarheartBurger burg = new BleakwindBuffet.Data.Entrees.BriarheartBurger();

            burg.Bun = !(bool)Bun.IsChecked;
            burg.Cheese = !(bool)Cheese.IsChecked;
            burg.Mustard = !(bool)Mustard.IsChecked;
            burg.Pickle = !(bool)Pickle.IsChecked;
            burg.Ketchup = !(bool)Ketchup.IsChecked;
            order.Add(burg);
            
            
            //navigates to the main window and the order list window
            Border mainWindowBorder = (Border)this.Parent;
            Grid mainWindowGrid = (Grid)mainWindowBorder.Parent;
            MainWindow mainWindow = (MainWindow)mainWindowGrid.Parent;
            OrderWindow orderWindow = (OrderWindow)mainWindow.orderWindowBorder.Child;

            orderWindow.orderList.Items.Clear();
            foreach(IOrderItem item in order.Items)
            {
                orderWindow.orderList.Items.Add(item);
            }
            
            
        }
    }
}
