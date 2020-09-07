/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuice
    {
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
            Assert.Equal(Size.Small, drink.size);
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
            drink.size = Size.Large;
            Assert.Equal(Size.Large, drink.size);
            drink.size = Size.Medium;
            Assert.Equal(Size.Medium, drink.size);
            drink.size = Size.Small;
            Assert.Equal(Size.Small, drink.size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Data.Drinks.AretinoAppleJuice drink = new Data.Drinks.AretinoAppleJuice();
            drink.size = size;
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
            drink.size = size;
            Assert.Equal(name, drink.ToString());
        }
    }
}