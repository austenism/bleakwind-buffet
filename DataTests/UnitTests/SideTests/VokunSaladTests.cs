/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad side = new VokunSalad();
            Assert.Equal(Size.Small, side.size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad side = new VokunSalad();
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
            VokunSalad side = new VokunSalad();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad side = new VokunSalad();
            side.size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad side = new VokunSalad();
            side.size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad side = new VokunSalad();
            side.size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}