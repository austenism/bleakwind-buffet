/*
* Author: Austen Clemons
* Class name: MadOtarGrits.xaml.cs
* Purpose: contains all c# code for the grits
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

namespace PointOfSale.SideMenus
{
    /// <summary>
    /// Interaction logic for MadOtarGrits.xaml
    /// </summary>
    public partial class MadOtarGrits : UserControl
    {
        BleakwindBuffet.Data.Sides.MadOtarGrits side = new BleakwindBuffet.Data.Sides.MadOtarGrits();
        public MadOtarGrits()
        {
            InitializeComponent();
            Size.DataContext = side.Size;
        }
        /// <summary>
        /// goes back to the prvious menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new TypeMenus.Sides();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            order.Add(side);
        }
    }
}
