/*
*Author: Austen Clemons
* Class name: Combo.cs
* Purpose: To contain the properties of an entire Order
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyCollectionChanged, INotifyPropertyChanged
    {
        //Listeners for event changes
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private static uint NextOrderNumber = 1;

        private double salestaxrate = 0.12;
        //the collection of items that make up the order
        public Collection<IOrderItem> Items = new Collection<IOrderItem>();
        /// <summary>
        /// constuctor for the order class
        /// </summary>
        public Order()
        {
            Number = NextOrderNumber;
            ++NextOrderNumber;
        }
        /// <summary>
        /// the property holding the sales tax rate. can be changed from the underlying variable
        /// </summary>
        public double SalesTaxRate
        {
            get => salestaxrate;
            set
            {
                salestaxrate = value;
            }
        }
        /// <summary>
        /// the subtotal of the order not counting tax
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0.00;
                foreach(IOrderItem item in Items)
                {
                    total += item.Price;
                }
                return Math.Round(total, 2);
            }
        }
        /// <summary>
        /// the total tax of the order
        /// </summary>
        public double Tax
        {
            get
            {
                return Math.Round(Subtotal * SalesTaxRate, 2);
            }
        }
        /// <summary>
        /// the total of the order including tax
        /// </summary>
        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax, 2);
            }
        }
        /// <summary>
        /// the total calories of the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint total = 0;
                foreach (IOrderItem item in Items)
                {
                    total += item.Calories;
                }
                return total;
            }
        }

        public uint Number;

        

        public void Add(IOrderItem item)
        {
            Items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public void Remove(IOrderItem item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }

        }
    }
}
