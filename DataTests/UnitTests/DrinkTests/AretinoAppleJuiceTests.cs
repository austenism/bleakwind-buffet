/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = true;
            });

            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Price", () =>
            {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Price", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Price", () =>
            {
                drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Calories", () =>
            {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Calories", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Calories", () =>
            {
                drink.Size = Size.Large;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(drink);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add ice", drink.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(name, drink.ToString());
        }
    }
}