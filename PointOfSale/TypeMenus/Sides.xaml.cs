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
    /// Interaction logic for Sides.xaml
    /// </summary>
    public partial class Sides : UserControl
    {
        public Sides()
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
        /// goes to Dragonborn Waffle Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dragonborn_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new SideMenus.DragonbornWaffleFries();
        }
        /// <summary>
        /// goes to Fried Miraak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Miraak_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new SideMenus.FriedMiraak();
        }
        /// <summary>
        /// goes to Mad Otar Grits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtar_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new SideMenus.MadOtarGrits();
        }
        /// <summary>
        /// goes to Vokun Salad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vokun_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new SideMenus.VokunSalad();
        }
    }
}
