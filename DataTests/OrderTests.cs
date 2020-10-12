using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void AddingItemNotifiesProperties()
        {
            Order order = new Order();
            
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(new AretinoAppleJuice());
            });
        }
        [Fact]
        public void RemovingItemNotifiesProperties()
        {
            Order order = new Order();
            AretinoAppleJuice item = new AretinoAppleJuice();
            order.Add(item);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(item);
            });
            order.Add(item);
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(item);
            });
            order.Add(item);
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(item);
            });
            order.Add(item);
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(item);
            });
        }
        [Fact]
        public void OrdersShouldHaveCorrectNumbers()
        {
            Order order = new Order();
            Order order2 = new Order();
            Order order3 = new Order();

            Assert.Equal(1, (double)order.Number);
            Assert.Equal(2, (double)order2.Number);
            Assert.Equal(3, (double)order3.Number);

        }

        
        [Fact]
        public void SendsCorrectPriceAndCaloriesTotalForItems()
        {
            Order order = new Order();
            order.Items.Add(new BriarheartBurger());
            order.Items.Add(new AretinoAppleJuice());
            order.Items.Add(new DragonbornWaffleFries());

            Assert.Equal(7.36, order.Subtotal);
            Assert.Equal(864, (double)order.Calories);
            Assert.Equal(0.8832, order.Tax);
            Assert.Equal(8.2432, order.Total);
        }

    }
}
