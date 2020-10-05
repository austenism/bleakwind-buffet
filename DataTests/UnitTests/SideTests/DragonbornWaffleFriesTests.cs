/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var side = new DragonbornWaffleFries();

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var side = new DragonbornWaffleFries();

            Assert.PropertyChanged(side, "Price", () =>
            {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Price", () =>
            {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Price", () =>
            {
                side.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var side = new DragonbornWaffleFries();

            Assert.PropertyChanged(side, "Calories", () =>
            {
                side.Size = Size.Large;
            });

            Assert.PropertyChanged(side, "Calories", () =>
            {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Calories", () =>
            {
                side.Size = Size.Large;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(side);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = Size.Large;
            Assert.Equal(Size.Large, side.Size);
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
            side.Size = Size.Small;
            Assert.Equal(Size.Small, side.Size);
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
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}