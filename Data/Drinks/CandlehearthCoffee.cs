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
    public class CandlehearthCoffee : Drink
    {
        //public Size Size { get; set; } = Size.Small;
        public override List<string> SpecialInstructions { get; } = new List<string>();
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
                return $"{Size} Candlehearth Coffee";
            }
            else
            {
                return $"{Size} Decaf Candlehearth Coffee";
            }
        }

        /// <summary>
        /// property that holds the price
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
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
        public override uint Calories
        {
            get
            {
                switch (Size)
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
                if (value == false)
                {
                    if (SpecialInstructions.Contains("Add ice"))
                    {
                        SpecialInstructions.Remove("Add ice");
                    }
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
                if (value == false)
                {
                    if (SpecialInstructions.Contains("Add cream"))
                    {
                        SpecialInstructions.Remove("Add cream");
                    }
                }
                cream = value;
            }

        }
    }
}