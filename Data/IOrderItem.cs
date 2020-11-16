using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// the price of the item
        /// </summary>
        /// <value>
        /// in US dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// the calories of the item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the item
        /// </summary>
        List<string> SpecialInstructions { get; }
        /// <summary>
        /// the description of each item
        /// </summary>
        string Description { get; }
    }
}
