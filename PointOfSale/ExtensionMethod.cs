/*
 * Author: Nathan Bean
 * Class: ExtensionMethod.cs
 * Purpose: Switching Screens
 */
using System.Windows;
using System.Windows.Media;


namespace PointOfSale.ExtensionMethod
{
    /// <summary>
    /// finds the control passed to the function
    /// </summary>
    /// <typeparam name="T">some control</typeparam>
    /// <param name="element"></param>
    /// <returns>the control we were looking for when found</returns>
    public static class ExtensionMethod
    {
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
