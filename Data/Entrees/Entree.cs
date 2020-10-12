using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// The base class representing common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// the price of the entree
        /// </summary>
        /// <value>
        /// in US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        
    }
}
