/*
* Author: Austen Clemons
* Class name: MarkarthMilk.cs
* Purpose: To contain the properties of the Sailor Soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        //public Size Size { get; set; } = Size.Small;
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = false;
        private Size size;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in SpecialInstructions)
            {
                sb.Append("\n" + "-" + s);
            }
            string sbi = sb.ToString();
            return $"{Size} Markarth Milk{sbi}\n{Price}";
        }

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
        /// property that holds the price
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    default: //case: Size.Large
                        return 1.22;
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
                        return 56;
                    case Size.Medium:
                        return 72;
                    default: //case: Size.Large
                        return 93;
                }
            }
        }

        public bool Ice
        {
            get => ice;
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add ice");
                }
                if (value == false)
                {
                    if (SpecialInstructions.Contains("Add ice"))
                    {
                        SpecialInstructions.Remove("Add ice");
                    }
                }
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }

        }
    }
}
