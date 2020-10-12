/*
* Author: Austen Clemons
* Class name: AretinoAppleJuice.xaml.cs
* Purpose: contains all c# code for the aretino apple juice
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
    /// Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        BleakwindBuffet.Data.Drinks.AretinoAppleJuice drink = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
        public AretinoAppleJuice()
        {
            InitializeComponent();
            Size.DataContext = drink.Size;
            Ice.DataContext = drink.Ice;
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
            order.Add(drink);
        }
    }
}
