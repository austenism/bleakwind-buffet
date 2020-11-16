/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void DescriptionReturnsCorrectString()
        {
            MarkarthMilk item = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", item.Description);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var drink = new MarkarthMilk();

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
            var drink = new MarkarthMilk();

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
            var drink = new MarkarthMilk();

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
            var drink = new MarkarthMilk();

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
            MarkarthMilk drink = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk drink = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk drink = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(drink);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk drink = new MarkarthMilk();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk drink = new MarkarthMilk();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.Size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.Size = size;
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add ice", drink.SpecialInstructions);
            }
        }

        //[Theory]
        //[InlineData(Size.Small, "Small Markarth Milk")]
        //[InlineData(Size.Medium, "Medium Markarth Milk")]
        //[InlineData(Size.Large, "Large Markarth Milk")]
        //public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        //{
        //    MarkarthMilk drink = new MarkarthMilk();
        //    drink.Size = size;
        //    Assert.Equal(name, drink.ToString());
        //}
    }
}