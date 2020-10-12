/*
* Author: Austen Clemons
* Class name: DragonbornWafflesFries.cs
* Purpose: To contain the properties of the Dragonborn Waffle Fries
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged
    {
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private Size size;

        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// size of the side
        /// </summary>
        public override Size Size { get => size;
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
            return $"{Size} Dragonborn Waffle Fries";
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
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    default: //case: Size.Large
                        return 0.96;
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
                        return 77;
                    case Size.Medium:
                        return 89;
                    default: //case: Size.Large
                        return 100;
                }
            }
        }
    }
}
