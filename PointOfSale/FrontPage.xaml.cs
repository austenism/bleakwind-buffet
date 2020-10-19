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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

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

        private void makeAComboButton_Click(object sender, RoutedEventArgs e)
        {
            Border mainBorder = (Border)Parent;
            Grid mainGrid = (Grid)mainBorder.Parent;
            MainWindow mainWindow = (MainWindow)mainGrid.Parent; //get the order item
            OrderWindow orderWindow = (OrderWindow)mainWindow.orderWindowBorder.Child;
            Order order = (Order)orderWindow.DataContext;

            bool containsEntree = false;
            bool containsDrink = false;
            bool containsSide = false;
            IOrderItem entree = default;
            IOrderItem drink = default;
            IOrderItem side = default;

            Combo combo = new Combo();


            //lets remove some items to make a combo since the specific items dosent affect the discount
            foreach(IOrderItem item in order.Items)
            {
                if (item is Entree) 
                { 
                    containsEntree = true;
                    entree = item;
                }
                if (item is Drink)
                {
                    containsDrink = true;
                    drink = item;
                } 
                if (item is Side)
                {
                    containsSide = true;
                    side = item;
                }
            }

            if(containsEntree && containsDrink && containsSide)
            {
                MessageBox.Show("Combo created");
                order.Remove(entree);
                order.Remove(drink);
                order.Remove(side);

                combo.Entree = (Entree)entree;
                combo.Side = (Side)side;
                combo.Drink = (Drink)drink;

                order.Add(combo);
            }
            else
            {
                MessageBox.Show("Not enough items for combo");
            }

            orderWindow.orderList.Items.Clear();
            foreach (IOrderItem item in order.Items)
            {
                orderWindow.orderList.Items.Add(item);
            }

        }
    }
}
