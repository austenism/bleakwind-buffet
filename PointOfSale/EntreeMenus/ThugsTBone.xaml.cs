﻿/*
* Author: Austen Clemons
* Class name: ThugsTBone.xaml.cs
* Purpose: contains all c# code for the t bone
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
    /// Interaction logic for ThugsTBone.xaml
    /// </summary>
    public partial class ThugsTBone : UserControl
    {
        public ThugsTBone()
        {
            InitializeComponent();
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
