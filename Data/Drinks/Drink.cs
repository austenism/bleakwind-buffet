using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The base class representing common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        
        /// <summary>
        /// the size of the drink
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// the price of the drink
        /// </summary>
        /// <value>
        /// in US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


        
    }
}
