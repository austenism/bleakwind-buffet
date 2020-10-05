/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var side = new MadOtarGrits();

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
            var side = new MadOtarGrits();

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
            var side = new MadOtarGrits();

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
            MadOtarGrits side = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(side);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Equal(Size.Small, side.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = Size.Large;
            Assert.Equal(Size.Large, side.Size);
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
            side.Size = Size.Small;
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }
    }
}