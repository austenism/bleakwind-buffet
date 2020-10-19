using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        PaymentViewModel pvm = new PaymentViewModel();
        uint Number;
        List<IOrderItem> Items;
        double Subtotal;
        double Tax;
        double Total;
        public CashPayment(uint n, List<IOrderItem> i, double sub, double ta, double tot)
        {
            Number = n;
            Items = i;
            Subtotal = sub;
            Tax = ta;
            Total = tot;
            
            InitializeComponent();
            DataContext = pvm;
            
            PayedHundreds.Text = pvm.PayHundreds.ToString();
            PayedFiftys.Text = pvm.PayFifties.ToString();
            PayedTwenties.Text = pvm.PayTwenties.ToString();
            PayedTens.Text = pvm.PayTens.ToString();
            PayedFives.Text = pvm.PayFives.ToString();
            PayedTwos.Text = pvm.PayTwos.ToString();
            PayedOneBills.Text = pvm.PayOneBills.ToString();
            PayedOneCoins.Text = pvm.PayOneCoins.ToString();
            PayedHalfDollars.Text = pvm.PayHalfDollars.ToString();
            PayedQuarters.Text = pvm.PayQuarters.ToString();
            PayedDimes.Text = pvm.PayDimes.ToString();
            PayedNickels.Text = pvm.PayNickels.ToString();
            PayedPennies.Text = pvm.PayPennies.ToString();

            UpdateChange();
        }
        /// <summary>
        /// goes back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Border border = (Border)this.Parent;
            border.Child = new FrontPage();
        }





        private void HundredplusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayHundreds += 1;
            pvm.MakeChange(Total);
            PayedHundreds.Text = pvm.PayHundreds.ToString();
            UpdateChange();
        }

        private void HundredminusButton_Click(object sender, RoutedEventArgs e)
        {
            if(pvm.PayHundreds > 0) pvm.PayHundreds -= 1;
            pvm.MakeChange(Total);
            PayedHundreds.Text = pvm.PayHundreds.ToString();
            UpdateChange();
        }

        private void FiftyplusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayFifties += 1;
            pvm.MakeChange(Total);
            PayedFiftys.Text = pvm.PayFifties.ToString();
            UpdateChange();
        }
        private void FiftyminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayFifties > 0) pvm.PayFifties -= 1;
            pvm.MakeChange(Total);
            PayedFiftys.Text = pvm.PayFifties.ToString();
            UpdateChange();
        }

        private void twentyPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayTwenties += 1;
            pvm.MakeChange(Total);
            PayedTwenties.Text = pvm.PayTwenties.ToString();
            UpdateChange();
        }

        private void TwentyminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayTwenties > 0) pvm.PayTwenties -= 1;
            pvm.MakeChange(Total);
            PayedTwenties.Text = pvm.PayTwenties.ToString();
            UpdateChange();
        }

        private void tenPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayTens += 1;
            pvm.MakeChange(Total);
            PayedTens.Text = pvm.PayTens.ToString();
            UpdateChange();
        }

        private void tenminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayTens > 0) pvm.PayTens -= 1;
            pvm.MakeChange(Total);
            PayedTens.Text = pvm.PayTens.ToString();
            UpdateChange();
        }

        private void fivePlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayFives += 1;
            pvm.MakeChange(Total);
            PayedFives.Text = pvm.PayFives.ToString();
            UpdateChange();
        }

        private void fiveminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayFives > 0) pvm.PayFives -= 1;
            pvm.MakeChange(Total);
            PayedFives.Text = pvm.PayFives.ToString();
            UpdateChange();
        }

        private void twoPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayTwos += 1;
            pvm.MakeChange(Total);
            PayedTwos.Text = pvm.PayTwos.ToString();
            UpdateChange();
        }

        private void twominusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayTwos > 0) pvm.PayTwos -= 1;
            pvm.MakeChange(Total);
            PayedTwos.Text = pvm.PayTwos.ToString();
            UpdateChange();
        }

        private void onePlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayOneBills += 1;
            pvm.MakeChange(Total);
            PayedOneBills.Text = pvm.PayOneBills.ToString();
            UpdateChange();
        }

        private void oneminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayOneBills > 0) pvm.PayOneBills -= 1;
            pvm.MakeChange(Total);
            PayedOneBills.Text = pvm.PayOneBills.ToString();
            UpdateChange();
        }

        private void oneCoinPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayOneCoins += 1;
            pvm.MakeChange(Total);
            PayedOneCoins.Text = pvm.PayOneCoins.ToString();
            UpdateChange();
        }

        private void oneCoinminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayOneCoins > 0) pvm.PayOneCoins -= 1;
            pvm.MakeChange(Total);
            PayedOneCoins.Text = pvm.PayOneCoins.ToString();
            UpdateChange();
        }

        private void halfDollarPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayHalfDollars += 1;
            pvm.MakeChange(Total);
            PayedHalfDollars.Text = pvm.PayHalfDollars.ToString();
            UpdateChange();
        }

        private void halfDollarminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayHalfDollars > 0) pvm.PayHalfDollars -= 1;
            pvm.MakeChange(Total);
            PayedHalfDollars.Text = pvm.PayHalfDollars.ToString();
            UpdateChange();
        }

        private void quarterPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayQuarters += 1;
            pvm.MakeChange(Total);
            PayedQuarters.Text = pvm.PayQuarters.ToString();
            UpdateChange();
        }

        private void quarterminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayQuarters > 0) pvm.PayQuarters -= 1;
            pvm.MakeChange(Total);
            PayedQuarters.Text = pvm.PayQuarters.ToString();
            UpdateChange();
        }

        private void dimePlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayDimes += 1;
            pvm.MakeChange(Total);
            PayedDimes.Text = pvm.PayDimes.ToString();
            UpdateChange();
        }

        private void dimeminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayDimes > 0) pvm.PayDimes -= 1;
            pvm.MakeChange(Total);
            PayedDimes.Text = pvm.PayDimes.ToString();
            UpdateChange();
        }

        private void nickelPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayNickels += 1;
            pvm.MakeChange(Total);
            PayedNickels.Text = pvm.PayNickels.ToString();
            UpdateChange();
        }

        private void nickelminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayNickels > 0) pvm.PayNickels -= 1;
            pvm.MakeChange(Total);
            PayedNickels.Text = pvm.PayNickels.ToString();
            UpdateChange();
        }

        private void penniesPlusButton_Click(object sender, RoutedEventArgs e)
        {
            pvm.PayPennies += 1;
            pvm.MakeChange(Total);
            PayedPennies.Text = pvm.PayPennies.ToString();
            UpdateChange();
        }

        private void penniesminusButton_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.PayPennies > 0) pvm.PayPennies -= 1;
            pvm.MakeChange(Total);
            PayedPennies.Text = pvm.PayPennies.ToString();
            UpdateChange();
        }

        private void UpdateChange()
        {
            ChangeHundreds.Text = pvm.ChangeHundreds.ToString();
            ChangeFifties.Text = pvm.ChangeFifties.ToString();
            ChangeTwenties.Text = pvm.ChangeTwenties.ToString();
            ChangeTens.Text = pvm.ChangeTens.ToString();
            ChangeFives.Text = pvm.ChangeFives.ToString();
            ChangeTwos.Text = pvm.ChangeTwos.ToString();
            ChangeOneBills.Text = pvm.ChangeOneBills.ToString();
            ChangeOneCoins.Text = pvm.ChangeOneCoins.ToString();
            ChangeHalfDollar.Text = pvm.ChangeHalfDollars.ToString();
            ChangeQuarters.Text = pvm.ChangeQuarters.ToString();
            ChangeDimes.Text = pvm.ChangeDimes.ToString();
            ChangeNickels.Text = pvm.ChangeNickels.ToString();
            ChangePennnies.Text = pvm.ChangePennies.ToString();

            if(Total - pvm.TotalUsingToPay >= 0) amountDue.Text = (Math.Round(Total - pvm.TotalUsingToPay, 2)).ToString();
            else
            {
                amountDue.Text = "0";
            }
            if (pvm.TotalUsingToPay - Total >= 0) changeDue.Text = (Math.Round(pvm.TotalUsingToPay - Total, 2)).ToString();
            else
            {
                changeDue.Text = "0";
            }
        }
        /// <summary>
        /// event handler for when the Complete order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeOrderButton_Click(object sender, RoutedEventArgs e)
        { 
            if (Total - pvm.TotalUsingToPay <= 0)
            {
                Border mainBorder = (Border)Parent;
                Grid mainGrid = (Grid)mainBorder.Parent;
                MainWindow mainWindow = (MainWindow)mainGrid.Parent; //get the order item
                OrderWindow orderWindow = (OrderWindow)mainWindow.orderWindowBorder.Child;
                Order order = (Order)orderWindow.DataContext;

                MessageBox.Show($"Order #{order.Number} Complete");

                pvm.FinalizeTransaction();
                //PRINT RECIEPT
                RecieptPrinter.PrintLine($"Order #{order.Number}"); //Order number
                RecieptPrinter.PrintLine(DateTime.Now.ToString());                //Date and Time
                //loop for each item in the list
                foreach(IOrderItem item in order.Items)
                {
                    string itemString = item.ToString();
                    int firstIndex = 0;
                    for(int i = 0; i < itemString.Length; i++)
                    {
                        if(itemString[i] == '\n')
                        {
                            RecieptPrinter.PrintLine(itemString.Substring(firstIndex, (i) - firstIndex));
                            firstIndex = i + 1;
                        }
                    }
                    //RecieptPrinter.PrintLine(item.ToString());  //ALL THE ITEMS
                }
                RecieptPrinter.PrintLine($"Subtotal: {order.Subtotal}"); //SUBTOTAL
                RecieptPrinter.PrintLine($"Tax: {order.Tax}");          //TAX
                RecieptPrinter.PrintLine($"Total {order.Total}");       //TOTAL
                RecieptPrinter.PrintLine("Payed with: CASH");         //Payment type
                if (pvm.TotalUsingToPay - Total > 0) RecieptPrinter.PrintLine($"Change Due: {Math.Round(pvm.TotalUsingToPay - Total, 2)}");

                else
                {
                    RecieptPrinter.PrintLine($"Change Due: 0");
                }
                RecieptPrinter.CutTape();
                //START NEW ORDER


                if (order.Items.Count > 0)
                {
                    while (order.Items.Count > 0)
                    {
                        order.Items.RemoveAt(0);
                    }
                    ++order.Number;
                }

                orderWindow.numberLabel.Content = "Order Number: " + order.Number;
                orderWindow.orderList.Items.Clear();
                foreach (IOrderItem item in order.Items)
                {
                    orderWindow.orderList.Items.Add(item);
                }

                Border border = (Border)this.Parent;
                border.Child = new FrontPage();
            }


            else MessageBox.Show("There is still a remaining charge.");
        
                    
        }
    }
}
