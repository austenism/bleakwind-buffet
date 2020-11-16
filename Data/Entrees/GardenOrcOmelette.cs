/*
* Author: Austen Clemons
* Class name: GardenOrcOmelette.cs
* Purpose: To contain the properties of the Garden Orc Omelette
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        private const double PRICE = 4.57;
        private const uint CALORIES = 404;
        public override List<string> SpecialInstructions { get; } = new List<string>();

        private bool broc = true;
        private bool mushrooms = true;
        private bool tomato = true; //all of the ingredients that be removed
        private bool cheddar = true;

        public override string Description { get { return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese."; } }

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
            return $"Garden Orc Omelette{sbi}\n{Price}";
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
        public bool Broccoli
        {
            get => broc;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold broccoli");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold broccoli"))
                    {
                        SpecialInstructions.Remove("Hold broccoli");
                    }
                }
                broc = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not eggs should be included
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold mushrooms");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold mushrooms"))
                    {
                        SpecialInstructions.Remove("Hold mushrooms");
                    }
                }
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not there should be hash browns
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold tomato");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold tomato"))
                    {
                        SpecialInstructions.Remove("Hold tomato");
                    }
                }
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        //whether or not there should be pancakes
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold cheddar");
                }
                if (value == true)
                {
                    if (SpecialInstructions.Contains("Hold cheddar"))
                    {
                        SpecialInstructions.Remove("Hold cheddar");
                    }
                }
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}