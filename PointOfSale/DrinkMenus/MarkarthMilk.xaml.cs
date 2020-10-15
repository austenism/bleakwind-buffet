﻿/*
* Author: Austen Clemons
* Class name: MarkarthMilk.xaml.cs
* Purpose: contains all c# code for the Markarth milk
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
    /// Interaction logic for MarkarthMilk.xaml
    /// </summary>
    public partial class MarkarthMilk : UserControl
    {
        public MarkarthMilk()
        {
            InitializeComponent();
            //Size.DataContext = drink.Size;
            //Ice.DataContext = drink.Ice;
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
            BleakwindBuffet.Data.Drinks.MarkarthMilk drink = new BleakwindBuffet.Data.Drinks.MarkarthMilk();

            drink.Size = (BleakwindBuffet.Data.Enums.Size)Size.SelectedIndex;
            drink.Ice = (bool)Ice.IsChecked;
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
