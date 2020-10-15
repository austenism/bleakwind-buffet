/*
* Author: Austen Clemons
* Class name: OrderWindow.xaml.cs
* Purpose: contains all c# code for the order window
*/

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.EntreeMenus;
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
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : UserControl
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            object ob = orderList.SelectedItem;
            if(ob != null)
            {
                order.Remove((IOrderItem)ob);
            }

            orderList.Items.Clear();
            foreach (IOrderItem item in order.Items)
            {
                orderList.Items.Add(item);
            }
        }

        //private void orderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
            //IOrderItem item = (IOrderItem)orderList.SelectedItem;
            ////entrees
            //if(item is BleakwindBuffet.Data.Entrees.BriarheartBurger)
            //{
            //    BleakwindBuffet.Data.Entrees.BriarheartBurger food = (BleakwindBuffet.Data.Entrees.BriarheartBurger)item;

            //    EntreeMenus.BriarheartBurger menu = new EntreeMenus.BriarheartBurger();
            //    menu.Bun.IsChecked = !food.Bun;
            //    menu.Cheese.IsChecked = !food.Cheese;
            //    menu.Ketchup.IsChecked = !food.Ketchup;
            //    menu.Mustard.IsChecked = !food.Mustard;
            //    menu.Pickle.IsChecked = !food.Pickle;
                
            //    Border orderBorder = (Border)this.Parent;
            //    Grid mainGrid = (Grid)orderBorder.Parent;
            //    MainWindow mainWindow = (MainWindow)mainGrid.Parent;
            //    mainWindow.mainWindowBorder.Child = menu;


            //}
            //else if(item is BleakwindBuffet.Data.Entrees.DoubleDraugr)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Entrees.ThalmorTriple)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Entrees.GardenOrcOmelette)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Entrees.PhillyPoacher)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Entrees.SmokehouseSkeleton)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Entrees.ThugsTBone)
            //{

            //}
            ////sides
            //else if(item is BleakwindBuffet.Data.Sides.DragonbornWaffleFries)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Sides.FriedMiraak)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Sides.MadOtarGrits)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Sides.VokunSalad)
            //{

            //}
            ////DRINKS
            //else if(item is BleakwindBuffet.Data.Drinks.AretinoAppleJuice)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Drinks.CandlehearthCoffee)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Drinks.MarkarthMilk)
            //{

            //}
            //else if(item is BleakwindBuffet.Data.Drinks.SailorSoda)
            //{

            //}
            //else if (item is BleakwindBuffet.Data.Drinks.WarriorWater)
            //{

            //}
            //else //should not be reached
            //{
            //    throw new NotImplementedException("unknown type detected");
            //}
        //}
    }
}
