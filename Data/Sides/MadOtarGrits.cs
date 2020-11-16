/*
* Author: Austen Clemons
* Class name: MadOtarGrits.cs
* Purpose: To contain the properties of the Mad Otar Grits
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, INotifyPropertyChanged
    {
        //public Size Size { get; set; } = Size.Small;
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private Size size;

        public override string Description { get { return "Cheesey Grits."; } }

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
            return $"{Size} Mad Otar Grits{sbi}\n{Price}";
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
                        return 1.22;
                    case Size.Medium:
                        return 1.58;
                    default: //case: Size.Large
                        return 1.93;
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
                        return 105;
                    case Size.Medium:
                        return 142;
                    default: //case: Size.Large
                        return 179;
                }
            }
        }
    }
}