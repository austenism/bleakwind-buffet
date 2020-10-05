/*
* Author: Austen Clemons
* Class name: PhillyPoacher.xaml.cs
* Purpose: contains all c# code for the philly poacher
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
    /// Interaction logic for PhillyPoacher.xaml
    /// </summary>
    public partial class PhillyPoacher : UserControl
    {
        BleakwindBuffet.Data.Entrees.PhillyPoacher notBurg = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
        public PhillyPoacher()
        {
            InitializeComponent();
            Sirloin.DataContext = notBurg.Sirloin;
            Onion.DataContext = notBurg.Onion;
            Roll.DataContext = notBurg.Roll;
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
