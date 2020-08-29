/*
* Author: Austen Clemons
* Class name: VokunSalad.cs
* Purpose: To contain the properties of the Vokun Salad
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
    {
        public Size size { get; set; } = Size.Small;
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }

        /// <summary>
        /// property that holds the price
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    default: //case: Size.Large
                        return 1.82;
                }
            }
        }
        /// <summary>
        /// property that holds the calorie count
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 41;
                    case Size.Medium:
                        return 52;
                    default: //case: Size.Large
                        return 73;
                }
            }
        }
    }
}
