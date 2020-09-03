/*
* Author: Austen Clemons
* Class name: MadOtarGrits.cs
* Purpose: To contain the properties of the Mad Otar Grits
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        public Size size { get; set; } = Size.Small;
        public List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Mad Otar Grits";
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
                        return 1.22;
                    case Size.Medium:
                        return 1.58;
                    default: //case: Size.Large
                        return 1.93;
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
                        return 105;
                    case Size.Medium:
                        return 142;
                    default: //case: Size.Large
                        return 179;
                }
            }
        }
    }
}