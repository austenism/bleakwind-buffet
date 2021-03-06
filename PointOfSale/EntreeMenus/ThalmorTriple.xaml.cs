﻿/*
* Author: Austen Clemons
* Class name: ThalmorTriple.xaml.cs
* Purpose: contains all c# code for the ThalmorTriple
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
    /// Interaction logic for ThalmorTriple.xaml
    /// </summary>
    public partial class ThalmorTriple : UserControl
    {
        public ThalmorTriple()
        {
            InitializeComponent();
            //Bun.DataContext = burg.Bun;
            //Ketchup.DataContext = burg.Ketchup;
            //Mustard.DataContext = burg.Mustard;
            //Pickle.DataContext = burg.Pickle;
            //Cheese.DataContext = burg.Cheese;
            //Tomato.DataContext = burg.Tomato;
            //Lettuce.DataContext = burg.Lettuce;
            //Mayo.DataContext = burg.Mayo;
            //Bacon.DataContext = burg.Bacon;
            //Egg.DataContext = burg.Egg;
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
            BleakwindBuffet.Data.Entrees.ThalmorTriple burg = new BleakwindBuffet.Data.Entrees.ThalmorTriple();

            burg.Bun = !(bool)Bun.IsChecked;
            burg.Cheese = !(bool)Cheese.IsChecked;
            burg.Mustard = !(bool)Mustard.IsChecked;
            burg.Pickle = !(bool)Pickle.IsChecked;
            burg.Ketchup = !(bool)Ketchup.IsChecked;
            burg.Tomato = !(bool)Tomato.IsChecked;
            burg.Lettuce = !(bool)Lettuce.IsChecked;
            burg.Mayo = !(bool)Mayo.IsChecked;
            burg.Egg = !(bool)Egg.IsChecked;
            burg.Bacon = !(bool)Bacon.IsChecked;
            order.Add(burg);


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
