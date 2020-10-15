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
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private static uint NextOrderNumber = 1;

        private double salestaxrate = 0.12;

        public Collection<IOrderItem> Items = new Collection<IOrderItem>();

        public Order()
        {
            Number = NextOrderNumber;
            ++NextOrderNumber;
        }

        public double SalesTaxRate
        {
            get => salestaxrate;
            set
            {
                salestaxrate = value;
            }
        }
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
        public double Tax
        {
            get
            {
                return Math.Round(Subtotal * SalesTaxRate, 2);
            }
        }
        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax, 2);
            }
        }

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
