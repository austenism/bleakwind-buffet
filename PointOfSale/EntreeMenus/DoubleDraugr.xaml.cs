/*
* Author: Austen Clemons
* Class name: DoubleDraugr.xaml.cs
* Purpose: contains all c# code for the double draugr
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
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugr : UserControl
    {
        BleakwindBuffet.Data.Entrees.DoubleDraugr burg = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
        public DoubleDraugr()
        {
            InitializeComponent();
            Bun.DataContext = burg.Bun;
            Ketchup.DataContext = burg.Ketchup;
            Mustard.DataContext = burg.Mustard;
            Pickle.DataContext = burg.Pickle;
            Cheese.DataContext = burg.Cheese;
            Tomato.DataContext = burg.Tomato;
            Lettuce.DataContext = burg.Lettuce;
            Mayo.DataContext = burg.Mayo;
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
            order.Add(burg);
        }
    }
}
