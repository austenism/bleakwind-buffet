/*
* Author: Austen Clemons
* Class name: SailorSoda.xaml.cs
* Purpose: contains all c# code for the sailor soda
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
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSoda : UserControl
    {
        BleakwindBuffet.Data.Drinks.SailorSoda drink = new BleakwindBuffet.Data.Drinks.SailorSoda();
        public SailorSoda()
        {
            InitializeComponent();
            Ice.DataContext = drink.Ice;
            Flavor.DataContext = drink.Flavor;
            Size.DataContext = drink.Size;
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
