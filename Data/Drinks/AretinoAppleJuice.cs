/*
* Author: Austen Clemons
* Class name: AretinoAppleJuice.cs
* Purpose: To contain the properties of the Aretino Apple Juice
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event handler for when a property is changed
        /// </summary>
        //public event PropertyChangedEventHandler PropertyChanged;
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
            return $"{Size} Aretino Apple Juice{sbi}\n{Price}";
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
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    default: //case: Size.Large
                        return 1.01;
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    default: //case: Size.Large
                        return 132;
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