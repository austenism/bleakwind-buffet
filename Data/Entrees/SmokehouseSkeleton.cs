/*
* Author: Austen Clemons
* Class name: Smokehouse Skeleton.cs
* Purpose: To contain the properties of the Smokehouse Skeleton
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        private const double PRICE = 5.62;
        private const uint CALORIES = 602;
        public List<string> SpecialInstructions { get; } = new List<string>();

        private bool sausage = true;
        private bool egg = true;
        private bool hashbrowns = true; //all of the ingredients that be removed
        private bool pancake = true;
        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
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
        /// whether or not a sausage should be on the meal
        /// </summary>
        public bool SausageLink
        {
            get => sausage;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold sausage");
                }
                sausage = value;
            }
        }
        //whether or not eggs should be included
        public bool Egg
        {
            get => egg;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold eggs");
                }
                egg = value;
            }
        }
        //whether or not there should be hash browns
        public bool HashBrowns
        {
            get => hashbrowns;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold hash browns");
                }
                hashbrowns = value;
            }
        }
        //whether or not there should be pancakes
        public bool Pancake
        {
            get => pancake;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold pancakes");
                }
                pancake = value;
            }
        }
    }
}
