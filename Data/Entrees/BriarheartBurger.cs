﻿/*
* Author: Austen Clemons
* Class name: BriarheartBurger.cs
* Purpose: To contain the properties of the Briarheart Burger
*/

using System.Collections.Generic;
using System.ComponentModel;
namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        private const double PRICE    = 6.32;
        private const uint   CALORIES = 743;
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
       

        /// <summary>
        /// property that holds the price
        /// </summary>
        public override double Price 
        {
            get => PRICE;
        }
        /// <summary>
        /// represents the calorie count
        /// </summary>
        public override uint Calories
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold bun"))
                    {
                        SpecialInstructions.Remove("Hold bun");
                    }
                }
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold ketchup"))
                    {
                        SpecialInstructions.Remove("Hold ketchup");
                    }
                }
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold mustard"))
                    {
                        SpecialInstructions.Remove("Hold mustard");
                    }
                }
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold pickle"))
                    {
                        SpecialInstructions.Remove("Hold pickle");
                    }
                }
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold cheese"))
                    {
                        SpecialInstructions.Remove("Hold cheese");
                    }
                }
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }

    }
}
