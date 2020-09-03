/*
* Author: Austen Clemons
* Class name: GardenOrcOmelette.cs
* Purpose: To contain the properties of the Garden Orc Omelette
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        private const double PRICE = 4.57;
        private const uint CALORIES = 404;
        public List<string> SpecialInstructions { get; } = new List<string>();

        private bool broc = true;
        private bool mushrooms = true;
        private bool tomato = true; //all of the ingredients that be removed
        private bool cheddar = true;
        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
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
        public bool Broccoli
        {
            get => broc;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold broccoli");
                }
                broc = value;
            }
        }
        //whether or not eggs should be included
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mushrooms");
                }
                mushrooms = value;
            }
        }
        //whether or not there should be hash browns
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold tomato");
                }
                tomato = value;
            }
        }
        //whether or not there should be pancakes
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold cheddar");
                }
                cheddar = value;
            }
        }
    }
}