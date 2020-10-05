/*
* Author: Austen Clemons
* Class name: FrontPage.xaml.cs
* Purpose: contains all c# code for the FrontPage
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FrontPage.xaml
    /// </summary>
    public partial class FrontPage : UserControl
    {
        public FrontPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sets screen to the entrees menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrees_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new TypeMenus.Entrees();
        }
        /// <summary>
        /// sets the screen to the sides menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sides_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new TypeMenus.Sides();
        }
        /// <summary>
        /// sets screen to the drinks menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drinks_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new TypeMenus.Drinks();
        }


    }
}
