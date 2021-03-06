﻿/*
* Author: Austen Clemons
* Class name: GardenOrcOmelette.xaml.cs
* Purpose: contains all c# code for the omelette
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
    /// Interaction logic for GardenOrcOmelette.xaml
    /// </summary>
    public partial class GardenOrcOmelette : UserControl
    {
        public GardenOrcOmelette()
        {
            InitializeComponent();
            //Broccoli.DataContext = notBurg.Broccoli;
            //Mushrooms.DataContext = notBurg.Mushrooms;
            //Tomato.DataContext = notBurg.Tomato;
            //Cheddar.DataContext = notBurg.Cheddar;
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
            BleakwindBuffet.Data.Entrees.GardenOrcOmelette notBurg = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();

            notBurg.Broccoli = !((bool)Broccoli.IsChecked);
            notBurg.Mushrooms = !((bool)Mushrooms.IsChecked);
            notBurg.Tomato = !((bool)Tomato.IsChecked);
            notBurg.Cheddar = !((bool)Cheddar.IsChecked);
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
