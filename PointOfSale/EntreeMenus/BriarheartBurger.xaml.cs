/*
* Author: Austen Clemons
* Class name: BriarheartBurger.xaml.cs
* Purpose: contains all c# code for the burger
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

namespace PointOfSale.EntreeMenus
{
    /// <summary>
    /// Interaction logic for BriarheartBurger.xaml
    /// </summary>
    public partial class BriarheartBurger : UserControl
    {
        BleakwindBuffet.Data.Entrees.BriarheartBurger burg = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
        public BriarheartBurger()
        {
            InitializeComponent();
            Bun.DataContext = burg.Bun;
            Ketchup.DataContext = burg.Ketchup;
            Mustard.DataContext = burg.Mustard;
            Pickle.DataContext = burg.Pickle;
            Cheese.DataContext = burg.Cheese;
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

        }
    }
}
