using BleakwindBuffet.Data;
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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : UserControl
    {
        public PaymentWindow(uint n, List<IOrderItem> i, double sub, double ta, double tot)
        {
            InitializeComponent();
            number = n;
            items = i;
            subtotal = sub;
            tax = ta;
            total = tot;
        }

        private uint number;
        private List<IOrderItem> items;
        private double subtotal;
        private double tax;
        private double total;

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            Border border = (Border)this.Parent;
            border.Child = new FrontPage();
        }
        /// <summary>
        /// either DEBIT or CREDIT is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardButton_Click(object sender, RoutedEventArgs e)
        {
            CardTransactionResult result = CardReader.RunCard(total);
            if(result == CardTransactionResult.Approved)
            {
                Border mainBorder = (Border)Parent;
                Grid mainGrid = (Grid)mainBorder.Parent;
                MainWindow mainWindow = (MainWindow)mainGrid.Parent;
                OrderWindow orderWindow = (OrderWindow)mainWindow.orderWindowBorder.Child;
                Order order = (Order)orderWindow.DataContext;


                //PRINT RECIEPT
                RecieptPrinter.PrintLine($"Order #{order.Number}"); //Order number
                RecieptPrinter.PrintLine(DateTime.Now.ToString());                //Date and Time
                //loop for each item in the list
                foreach (IOrderItem item in order.Items)
                {
                    string itemString = item.ToString();
                    int firstIndex = 0;
                    for (int i = 0; i < itemString.Length; i++)
                    {
                        if (itemString[i] == '\n')
                        { //iterate through the string to print things out one line at a time
                            RecieptPrinter.PrintLine(itemString.Substring(firstIndex, (i) - firstIndex));
                            firstIndex = i + 1;
                        }
                    }
                    //RecieptPrinter.PrintLine(item.ToString());  //ALL THE ITEMS
                }
                RecieptPrinter.PrintLine($"Subtotal: {order.Subtotal}"); //SUBTOTAL
                RecieptPrinter.PrintLine($"Tax: {order.Tax}");          //TAX
                RecieptPrinter.PrintLine($"Total {order.Total}");       //TOTAL
                RecieptPrinter.PrintLine("Payed with: CARD");         //Payment type
                RecieptPrinter.PrintLine($"Change Due: 0");
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
            else
            {
                MessageBox.Show(result.ToString());
            }
        }
        /// <summary>
        /// handler for doing cash payments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            Border border = (Border)this.Parent;
            border.Child = new CashPayment(number, items, subtotal, tax, total);
        }
    }
}
