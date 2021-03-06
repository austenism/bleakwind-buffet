﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// The base class representing common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// the size of the side
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// the price of the side
        /// </summary>
        /// <value>
        /// in US dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// the calories of the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// the description of the item
        /// </summary>
        public abstract string Description { get; }
    }
}
