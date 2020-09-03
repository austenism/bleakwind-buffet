/*
* Author: Austen Clemons
* Class name: DoubleDraugr.cs
* Purpose: To contain the properties of the Double Draugr
*/

using System.Collections.Generic;
namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        private const double PRICE = 7.32;
        private const uint CALORIES = 843;
        public List<string> SpecialInstructions { get; } = new List<string>();
        
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;    //all of the ingredients that be removed
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
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

    }
}
