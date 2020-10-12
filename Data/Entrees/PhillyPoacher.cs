/*
* Author: Austen Clemons
* Class name: PhillyPoacher.cs
* Purpose: To contain the properties of the Philly Poacher
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        private const double PRICE = 7.23;
        private const uint CALORIES = 784;
        public override List<string> SpecialInstructions { get; } = new List<string>();

        private bool sirloin = true; //all of the ingredients that be removed
        private bool onion = true;
        private bool roll = true;

        public override event PropertyChangedEventHandler PropertyChanged;

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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold sirloin"))
                    {
                        SpecialInstructions.Remove("Hold sirloin");
                    }
                }
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold onions"))
                    {
                        SpecialInstructions.Remove("Hold onions");
                    }
                }
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold roll"))
                    {
                        SpecialInstructions.Remove("Hold roll");
                    }
                }
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}