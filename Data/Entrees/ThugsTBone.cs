/*
* Author: Austen Clemons
* Class name: ThugsTBone.cs
* Purpose: To contain the properties of the Thugs T-Bone
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        private const double PRICE = 6.44;
        private const uint CALORIES = 982;
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
        /// <summary>
        /// property that holds the price
        /// </summary>
        public double Price
        {
            get => PRICE;
        }
        /// <summary>
        /// represents the calorie count
        /// </summary>
        public uint Calories
        {
            get => CALORIES;
        }
    }
}
       