/*
* Author: Austen Clemons
* Class name: DragonbornWaffleFries.xaml.cs
* Purpose: contains all c# code for the Waffle fries
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
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFries : UserControl
    {
        public DragonbornWaffleFries()
        {
            InitializeComponent();
            //Size.DataContext = side.Size;
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
            BleakwindBuffet.Data.Sides.DragonbornWaffleFries side = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();

            side.Size = (BleakwindBuffet.Data.Enums.Size)Size.SelectedIndex;
            order.Add(side);


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
