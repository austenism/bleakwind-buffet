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
    /// Interaction logic for Entrees.xaml
    /// </summary>
    public partial class Entrees : UserControl
    {
        public Entrees()
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
        /// goes to Briarheart Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Briarheart_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.BriarheartBurger();
        }
        /// <summary>
        /// goes to Double draugr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Draugr_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.DoubleDraugr();
        }
        /// <summary>
        /// goes to Thalmor Triple
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thalmor_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.ThalmorTriple();
        }
        /// <summary>
        /// goes to goes to Garden orc omelette
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Garden_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.GardenOrcOmelette();
        }
        /// <summary>
        /// goes to Philly Poacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Philly_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.PhillyPoacher();
        }
        /// <summary>
        /// goes to smokehouse skeleton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Skeleton_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.SmokehouseSkeleton();
        }
        /// <summary>
        /// goes to Thugs T-Bone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thug_Click(object sender, RoutedEventArgs e)
        {
            Border parent = ExtensionMethod.ExtensionMethod.FindAncestor<Border>(this);
            parent.Child = new EntreeMenus.ThugsTBone();
        }
    }
}
