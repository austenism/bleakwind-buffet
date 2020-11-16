/*
* Author: Austen Clemons
* Class name: Smokehouse Skeleton.cs
* Purpose: To contain the properties of the Smokehouse Skeleton
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        private const double PRICE = 5.62;
        private const uint CALORIES = 602;
        public override List<string> SpecialInstructions { get; } = new List<string>();

        private bool sausage = true;
        private bool egg = true;
        private bool hashbrowns = true; //all of the ingredients that be removed
        private bool pancake = true;

        public override string Description { get { return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice."; } }

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// returns the name of the entree
        /// </summary>
        /// <returns>the name of the entree</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in SpecialInstructions)
            {
                sb.Append("\n" + "-" + s);
            }
            string sbi = sb.ToString();
            return $"Smokehouse Skeleton{sbi}\n{Price}";
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
        /// whether or not a sausage should be on the meal
        /// </summary>
        public bool SausageLink
        {
            get => sausage;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold sausage");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold sausage"))
                    {
                        SpecialInstructions.Remove("Hold sausage");
                    }
                }
                sausage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not eggs should be included
        public bool Egg
        {
            get => egg;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold eggs");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold eggs"))
                    {
                        SpecialInstructions.Remove("Hold eggs");
                    }
                }
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not there should be hash browns
        public bool HashBrowns
        {
            get => hashbrowns;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold hashbrowns");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold hashbrowns"))
                    {
                        SpecialInstructions.Remove("Hold hashbrowns");
                    }
                }
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not there should be pancakes
        public bool Pancake
        {
            get => pancake;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold pancake");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold pancake"))
                    {
                        SpecialInstructions.Remove("Hold pancake");
                    }
                }
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}
