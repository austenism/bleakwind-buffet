/*
* Author: Austen Clemons
* Class name: SailorSoda.cs
* Purpose: To contain the properties of the Sailor Soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {
        public Size size { get; set; } = Size.Small;
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;
        public List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = true;
        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} {Flavor}Sailor Soda";
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
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    default: //case: Size.Large
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    default: //case: Size.Large
                        return 205;
                }
            }
        }

        public bool Ice
        {
            get => ice;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold ice");
                }
                ice = value;
            }

        }

    }
}
