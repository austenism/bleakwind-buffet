/*
* Author: Austen Clemons
* Class name: FriedMiraak.cs
* Purpose: To contain the properties of the Fried Miraak
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private Size size;

        public override string Description { get { return "Perfectly prepared hash brown pancakes."; } }

        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// size of the side
        /// </summary>
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
            StringBuilder sb = new StringBuilder();
            foreach (string s in SpecialInstructions)
            {
                sb.Append("\n" + "-" + s);
            }
            string sbi = sb.ToString();
            return $"{Size} Fried Miraak{sbi}\n{Price}";
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
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    default: //case: Size.Large
                        return 2.88;
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
                        return 151;
                    case Size.Medium:
                        return 236;
                    default: //case: Size.Large
                        return 306;
                }
            }
        }
    }
}
