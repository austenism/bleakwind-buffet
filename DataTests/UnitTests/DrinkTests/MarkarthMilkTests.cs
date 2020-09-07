/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
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
            Assert.Equal(Size.Small, drink.size);
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
            drink.size = Size.Large;
            Assert.Equal(Size.Large, drink.size);
            drink.size = Size.Medium;
            Assert.Equal(Size.Medium, drink.size);
            drink.size = Size.Small;
            Assert.Equal(Size.Small, drink.size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.size = size;
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

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk drink = new MarkarthMilk();
            drink.size = size;
            Assert.Equal(name, drink.ToString());
        }
    }
}