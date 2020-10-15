/*
* Author: Austen Clemons
* Class name: CandlehearthCoffee.xaml.cs
* Purpose: contains all c# code for the candlehearth coffee
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

namespace PointOfSale.DrinkMenus
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        public CandlehearthCoffee()
        {
            InitializeComponent();
            //Size.DataContext = drink.Size;
            //Ice.DataContext = drink.Ice;
            //Cream.DataContext = drink.RoomForCream;
            //Decaf.DataContext = drink.Decaf;
        }
        /// <summary>
        /// goes back to the prvious menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new TypeMenus.Drinks();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee drink = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();

            drink.Size = (BleakwindBuffet.Data.Enums.Size)Size.SelectedIndex;
            drink.Ice = (bool)Ice.IsChecked;
            drink.RoomForCream = (bool)Cream.IsChecked;
            drink.Decaf = ((bool)Decaf.IsChecked);
            order.Add(drink);


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
