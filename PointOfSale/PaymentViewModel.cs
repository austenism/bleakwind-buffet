using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace PointOfSale
{
    public class PaymentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        //PROPERTIES
        
        //in the drawer
        public int DrawerHundreds { get => CashDrawer.Hundreds;}
        public int DrawerFifties { get => CashDrawer.Fifties; }
        public int DrawerTwenties { get => CashDrawer.Twenties; }
        public int DrawerTens { get => CashDrawer.Tens; }
        public int DrawerFives { get => CashDrawer.Fives; }
        public int DrawerTwos { get => CashDrawer.Twos; }
        public int DrawerOneBills { get => CashDrawer.Ones; }
        public int DrawerOneCoins { get => CashDrawer.Dollars; }
        public int DrawerHalfDollars { get => CashDrawer.HalfDollars; }
        public int DrawerQuarters { get => CashDrawer.Quarters; }
        public int DrawerDimes { get => CashDrawer.Dimes; }
        public int DrawerNickels { get => CashDrawer.Nickels; }
        public int DrawerPennies { get => CashDrawer.Pennies; }

        public double TotalInDrawer { 
            get
            {
                return CashDrawer.Total;
            } 
        }
        //using to pay
        public int PayHundreds { get; set; } = 0;
        public int PayFifties { get; set; } = 0;
        public int PayTwenties { get; set; } = 0;
        public int PayTens { get; set; } = 0;
        public int PayFives { get; set; } = 0;
        public int PayTwos { get; set; } = 0;
        public int PayOneBills { get; set; } = 0;
        public int PayOneCoins { get; set; } = 0;
        public int PayHalfDollars { get; set; } = 0;
        public int PayQuarters { get; set; } = 0;
        public int PayDimes { get; set; } = 0;
        public int PayNickels { get; set; } = 0;
        public int PayPennies { get; set; } = 0;

        public double TotalUsingToPay
        {
            get
            {
                return (PayHundreds * 100) +
                    (PayFifties * 50) +
                    (PayTwenties * 20) +
                    (PayTens * 10) +
                    (PayFives * 5) +
                    (PayTwos * 2) +
                    (PayOneBills * 1) +
                    (PayOneCoins * 1) +
                    (PayHalfDollars * 0.5) +
                    (PayQuarters * 0.25) +
                    (PayDimes * 0.10) +
                    (PayNickels * 0.05) +
                    (PayPennies * 0.01);
            }
        }

        //change to give
        public int ChangeHundreds { get; private set; } = 0;
        public int ChangeFifties { get; private set; } = 0;
        public int ChangeTwenties { get; private set; } = 0;
        public int ChangeTens { get; private set; } = 0;
        public int ChangeFives { get; private set; } = 0;
        public int ChangeTwos { get; private set; } = 0;
        public int ChangeOneBills { get; private set; } = 0;
        public int ChangeOneCoins { get; private set; } = 0;
        public int ChangeHalfDollars { get; private set; } = 0;
        public int ChangeQuarters { get; private set; } = 0;
        public int ChangeDimes { get; private set; } = 0;
        public int ChangeNickels { get; private set; } = 0;
        public int ChangePennies { get; private set; } = 0;


        public void MakeChange(double amountOwed)
        {
            //if theres is not enough to make change
            if (TotalUsingToPay - amountOwed > TotalInDrawer)
            {
                MessageBox.Show("WARNING: Not enough change in drawer");
                return;
            }

            double changeToMake = TotalUsingToPay - amountOwed;

            //RESET ALL CHANGE VALUES AND RECALCULATE THEM
            ChangeHundreds = 0;
            ChangeFifties = 0;
            ChangeTwenties = 0;
            ChangeTens = 0;
            ChangeFives = 0;
            ChangeTwos = 0;
            ChangeOneBills = 0;
            ChangeOneCoins = 0;
            ChangeHalfDollars = 0;
            ChangeQuarters = 0;
            ChangeDimes = 0;
            ChangeNickels = 0;
            ChangePennies = 0;

            if(changeToMake >= 100)
            {
                while(changeToMake >= 100 && DrawerHundreds > 0)
                {
                    changeToMake -= 100;
                    ChangeHundreds += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                }
            }
            if(changeToMake >= 50 && DrawerFifties > 0)
            {
                while(changeToMake >= 50)
                {
                    changeToMake -= 50;
                    ChangeFifties += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                }
            }
            if (changeToMake >= 20 && DrawerTwenties > 0)
            {
                while (changeToMake >= 20)
                {
                    changeToMake -= 20;
                    ChangeTwenties += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                }
            }
            if (changeToMake >= 10 && DrawerTens > 0)
            {
                while (changeToMake >= 10)
                {
                    changeToMake -= 10;
                    ChangeTens += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                }
            }
            if (changeToMake >= 5 && DrawerFives > 0)
            {
                while (changeToMake >= 5)
                {
                    changeToMake -= 5;
                    ChangeFives += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                }
            }
            if (changeToMake >= 2 && DrawerTwos > 0)
            {
                while (changeToMake >= 2)
                {
                    changeToMake -= 2;
                    ChangeTwos += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                }
            }
            if (changeToMake >= 1 && DrawerOneBills > 0)
            {
                while (changeToMake >= 1)
                {
                    changeToMake -= 1;
                    ChangeOneBills += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOneBills"));
                }
            }
            if (changeToMake >= 1 && DrawerOneCoins > 0)
            {
                while (changeToMake >= 1)
                {
                    changeToMake -= 1;
                    ChangeOneCoins += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOneCoins"));
                }
            }
            if (changeToMake >= 0.5 && DrawerHalfDollars > 0)
            {
                while (changeToMake >= 0.5)
                {
                    changeToMake -= 0.5;
                    ChangeHalfDollars += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
                }
            }
            if (changeToMake >= 0.25 && DrawerQuarters > 0)
            {
                while (changeToMake >= 0.25)
                {
                    changeToMake -= 0.25;
                    ChangeQuarters += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                }
            }
            if (changeToMake >= 0.1 && DrawerDimes > 0)
            {
                while (changeToMake >= 0.1)
                {
                    changeToMake -= 0.1;
                    ChangeDimes += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                }
            }
            if (changeToMake >= 0.05 && DrawerNickels > 0)
            {
                while (changeToMake >= 0.05)
                {
                    changeToMake -= 0.05;
                    ChangeNickels += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                }
            }
            if (changeToMake >= 0.01 && DrawerPennies > 0)
            {
                while (changeToMake >= 0.01)
                {
                    changeToMake -= 0.01;
                    ChangePennies += 1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                }
            }
        }
        /// <summary>
        /// finalizes the transaction
        /// </summary>
        public void FinalizeTransaction()
        {
            CashDrawer.OpenDrawer();

            //add what was paid
            CashDrawer.Hundreds += PayHundreds;
            CashDrawer.Fifties += PayFifties;
            CashDrawer.Twenties += PayTwenties;
            CashDrawer.Tens += PayTens;
            CashDrawer.Fives += PayFives;
            CashDrawer.Twos += PayTwos;
            CashDrawer.Ones += PayOneBills;
            CashDrawer.Dollars += PayOneCoins;
            CashDrawer.HalfDollars += PayHalfDollars;
            CashDrawer.Quarters += PayQuarters;
            CashDrawer.Dimes += PayDimes;
            CashDrawer.Nickels += PayNickels;
            CashDrawer.Pennies += PayPennies;

            //subtract what was given as change
            CashDrawer.Hundreds -= ChangeHundreds;
            CashDrawer.Fifties -= ChangeFifties;
            CashDrawer.Twenties -= ChangeTwenties;
            CashDrawer.Tens -= ChangeTens;
            CashDrawer.Fives -= ChangeFives;
            CashDrawer.Twos -= ChangeTwos;
            CashDrawer.Ones -= ChangeOneBills;
            CashDrawer.Dollars -= ChangeOneCoins;
            CashDrawer.HalfDollars -= ChangeHalfDollars;
            CashDrawer.Quarters -= ChangeQuarters;
            CashDrawer.Dimes -= ChangeDimes;
            CashDrawer.Nickels -= ChangeNickels;
            CashDrawer.Pennies -= ChangePennies;

        }

    }
}
