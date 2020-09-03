/*
* Author: Austen Clemons
* Class name: WarriorWater.cs
* Purpose: To contain the properties of the Warrior Water
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        public Size size { get; set; } = Size.Small;
        public List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = true;
        private bool lemon = false;

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Warrior Water";
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
                        return 0.0;
                    case Size.Medium:
                        return 0.0;
                    default: //case: Size.Large
                        return 0.0;
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
                        return 0;
                    case Size.Medium:
                        return 0;
                    default: //case: Size.Large
                        return 0;
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
        public bool Lemon
        {
            get => lemon;
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add lemon");
                }
                lemon = value;
            }

        }
    }
}