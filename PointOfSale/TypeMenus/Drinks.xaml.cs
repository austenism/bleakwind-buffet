/*
* Author: Austen Clemons
* Class name: Drinks.xaml.cs
* Purpose: contains all c# code for the drinks
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

namespace PointOfSale.TypeMenus
{
    /// <summary>
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : UserControl
    {
        public Drinks()
        {
            InitializeComponent();
        }
        /// <summary>
        /// takes the menu back a step from here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new FrontPage();
        }
        /// <summary>
        /// goes to Aretino Apple Juice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apple_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new DrinkMenus.AretinoAppleJuice();
        }
        /// <summary>
        /// Goes to Candlehearth Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coffee_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new DrinkMenus.CandlehearthCoffee();
        }
        /// <summary>
        /// goes to Markarth Milk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Milk_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new DrinkMenus.MarkarthMilk();
        }
        /// <summary>
        /// goes to Sailor Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new DrinkMenus.SailorSoda();
        }
        /// <summary>
        /// goes to Warrior Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new DrinkMenus.WarriorWater();
        }
    }
}
