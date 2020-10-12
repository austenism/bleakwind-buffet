using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data
{
    public class Combo : ObservableCollection<IOrderItem>, IOrderItem, INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;


        private Entree entree = new BriarheartBurger();
        private Side side = new DragonbornWaffleFries();
        private Drink drink = new AretinoAppleJuice();

        public Entree Entree
        {
            get => entree;
            set
            {
                if (value != default) entree.PropertyChanged -= ItemChangedListener;

                value.PropertyChanged += ItemChangedListener;
                entree = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Entree"));
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public Side Side
        {
            get => side;
            set
            {
                if (value != null) side.PropertyChanged -= ItemChangedListener;

                
                value.PropertyChanged += ItemChangedListener;
                side = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Side"));
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public Drink Drink
        {
            get => drink;
            set
            {
                if (value != default) drink.PropertyChanged -= ItemChangedListener;

                value.PropertyChanged += ItemChangedListener;
                drink = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Drink"));
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        

        public double Price
        {
            get
            {
                return entree.Price + side.Price + drink.Price - 1.00;
            }
        }

        public uint Calories
        {
            get
            {
                return entree.Calories + side.Calories + drink.Calories;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                list.Add(entree.ToString());
                foreach(string s in entree.SpecialInstructions)
                {
                    list.Add("-" + s);
                }
                list.Add(side.ToString());
                foreach (string s in side.SpecialInstructions)
                {
                    list.Add("-" + s);
                }
                list.Add(drink.ToString());
                foreach (string s in drink.SpecialInstructions)
                {
                    list.Add("-" + s);
                }
                
                return list;
            }
        }


        void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price") OnPropertyChanged(new PropertyChangedEventArgs("Price"));

            if (e.PropertyName == "Calories") OnPropertyChanged(new PropertyChangedEventArgs("Calories"));

            if (e.PropertyName == "SpecialInstructions") OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
