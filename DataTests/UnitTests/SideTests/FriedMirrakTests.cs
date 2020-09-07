/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.Equal(Size.Small, side.size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak side = new FriedMiraak();
            side.size = Size.Large;
            Assert.Equal(Size.Large, side.size);
            side.size = Size.Medium;
            Assert.Equal(Size.Medium, side.size);
            side.size = Size.Small;
            Assert.Equal(Size.Small, side.size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak side = new FriedMiraak();
            side.size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak side = new FriedMiraak();
            side.size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak side = new FriedMiraak();
            side.size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}