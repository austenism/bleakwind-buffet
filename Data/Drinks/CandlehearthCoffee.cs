/*
* Author: Austen Clemons
* Class name: CandlehearthCoffee.cs
* Purpose: To contain the properties of the Candlehearth Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        //public Size Size { get; set; } = Size.Small;
        public override List<string> SpecialInstructions { get; } = new List<string>();
        private bool ice = false;
        private bool cream = false;
        private Size size;
        private bool decaf = false;

        public override string Description { get { return "Fair trade, fresh ground dark roast coffee."; } }

        public override event PropertyChangedEventHandler PropertyChanged;

        public bool Decaf { get => decaf; 
            set {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                decaf = value;
            } }

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
            if (!Decaf)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in SpecialInstructions)
                {
                    sb.Append("\n" + "-" + s);
                }
                string sbi = sb.ToString();
                return $"{Size} Candlehearth Coffee{sbi}\n{Price}";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in SpecialInstructions)
                {
                    sb.Append("\n" + "-" + s);
                }
                string sbi = sb.ToString();
                return $"{Size} Decaf Candlehearth Coffee{sbi}\n{Price}";
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
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    default: //case: Size.Large
                        return 1.75;
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    default: //case: Size.Large
                        return 20;
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
        public bool RoomForCream
        {
            get => cream;
            set
            {
                if (value == true)
                {
                    SpecialInstructions.Add("Add cream");
                }
                if (value == false)
                {
                    if (SpecialInstructions.Contains("Add cream"))
                    {
                        SpecialInstructions.Remove("Add cream");
                    }
                }
                cream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
            }

        }
    }
}