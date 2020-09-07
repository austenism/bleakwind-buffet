/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, side.size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
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
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}