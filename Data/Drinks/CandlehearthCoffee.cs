/*
* Author: Austen Clemons
* Class name: CandlehearthCoffee.cs
* Purpose: To contain the properties of the Candlehearth Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        public Size size { get; set; } = Size.Small;
        public List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = false;
        private bool cream = false;
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!Decaf)
            {
                return $"{size} Candlehearth Coffee";
            }
            else
            {
                return $"{size} Decaf Candlehearth Coffee";
            }
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
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    default: //case: Size.Large
                        return 1.75;
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    default: //case: Size.Large
                        return 20;
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
        public bool RoomForCream
        {
            get => cream;
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add cream");
                }
                cream = value;
            }

        }
    }
}