/*
* Author: Austen Clemons
* Class name: PhillyPoacher.cs
* Purpose: To contain the properties of the Philly Poacher
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        private const double PRICE = 7.23;
        private const uint CALORIES = 784;
        public List<string> SpecialInstructions { get; } = new List<string>();

        private bool sirloin = true; //all of the ingredients that be removed
        private bool onion = true;
        private bool roll = true;
        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
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
        /// <summary>
        /// whether or not a Sirloin should be on the meal
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold sirloin");
                }
                sirloin = value;
            }
        }
        //whether or not onions should be included
        public bool Onion
        {
            get => onion;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold onions");
                }
                onion = value;
            }
        }
        //whether or not the roll should be included
        public bool Roll
        {
            get => roll;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold roll");
                }
                roll = value;
            }
        }
    }
}