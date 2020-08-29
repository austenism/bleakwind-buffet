/*
* Author: Austen Clemons
* Class name: AretinoAppleJuice.cs
* Purpose: To contain the properties of the Aretino Apple Juice
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {
        public Size size { get; set; } = Size.Small;
        public List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = false;

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Aretino Apple Juice";
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
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    default: //case: Size.Large
                        return 1.01;
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    default: //case: Size.Large
                        return 132;
                }
            }
        }

        public bool Ice
        {
            get => ice;
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add ice");
                }
                ice = value;
            }

        }
    }
}