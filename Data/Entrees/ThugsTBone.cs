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
    public class ThugsTBone : Entree
    {
        private const double PRICE = 6.44;
        private const uint CALORIES = 982;
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in SpecialInstructions)
            {
                sb.Append("\n" + "-" + s);
            }
            string sbi = sb.ToString();
            return $"Thugs T-Bone{sbi}\n{Price}";
        }
        /// <summary>
        /// property that holds the price
        /// </summary>
        public override double Price
        {
            get => PRICE;
        }
        /// <summary>
        /// represents the calorie count
        /// </summary>
        public override uint Calories
        {
            get => CALORIES;
        }
    }
}
       