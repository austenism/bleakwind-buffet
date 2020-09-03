﻿/*
* Author: Austen Clemons
* Class name: ThalmorTriple.cs
* Purpose: To contain the properties of the Thalmor Triple
*/

using System.Collections.Generic;
namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        private const double PRICE = 8.32;
        private const uint CALORIES = 943;
        public List<string> SpecialInstructions { get; } = new List<string>();

        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;    //all of the ingredients that be removed
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;
        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
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
        /// whether or not a bun should be on the burger
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold bun");
                }
                bun = value;
            }
        }
        /// <summary>
        /// whether or not ketchup should be on the burger
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold ketchup");
                }
                ketchup = value;
            }
        }
        /// <summary>
        /// whether or not mustard should be on the burger
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mustard");
                }
                mustard = value;
            }
        }
        //whether or not pickles should be on the burger
        public bool Pickle
        {
            get => pickle;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold pickle");
                }
                pickle = value;
            }
        }
        //whether or not cheese should be on the burger
        public bool Cheese
        {
            get => cheese;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold cheese");
                }
                cheese = value;
            }
        }
        //whether or not tomatoes should be on the burger
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
        //whether or not lettuce should be on the burger
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold lettuce");
                }
                lettuce = value;
            }
        }
        //whether or not mayo should be on the burger
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mayo");
                }
                mayo = value;
            }
        }
        //whether or not there should be bacon on the burger
        public bool Bacon 
        {
            get => bacon;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold bacon");
                }
                bacon = value;
            }
        }
        //whether or not there should be an egg on the burger
        public bool Egg
        {
            get => egg;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold egg");
                }
                egg = value;
            }
        }



    }
}
