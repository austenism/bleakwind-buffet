/*
* Author: Austen Clemons
* Class name: SailorSoda.cs
* Purpose: To contain the properties of the Sailor Soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        //public Size Size { get; set; } = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry; 
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = true;
        private Size size;

        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }
        public override event PropertyChangedEventHandler PropertyChanged;

        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
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
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    default: //case: Size.Large
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    default: //case: Size.Large
                        return 205;
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
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold ice"))
                    {
                        SpecialInstructions.Remove("Hold ice");
                    }
                }
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }

        }

    }
}
