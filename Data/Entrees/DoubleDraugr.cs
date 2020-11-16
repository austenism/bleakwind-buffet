/*
* Author: Austen Clemons
* Class name: DoubleDraugr.cs
* Purpose: To contain the properties of the Double Draugr
*/

using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        private const double PRICE = 7.32;
        private const uint CALORIES = 843;
        public override List<string> SpecialInstructions { get; } = new List<string>();
        
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;    //all of the ingredients that be removed
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        public override string Description { get { return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo."; } }

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
            return $"Double Draugr{sbi}\n{Price}";
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not tomatoes should be on the burger
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold tomato");
                }

                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not lettuce should be on the burger
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold lettuce");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold lettuce"))
                    {
                        SpecialInstructions.Remove("Hold lettuce");
                    }
                }
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not mayo should be on the burger
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mayo");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold mayo"))
                    {
                        SpecialInstructions.Remove("Hold mayo");
                    }
                }
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

    }
}
