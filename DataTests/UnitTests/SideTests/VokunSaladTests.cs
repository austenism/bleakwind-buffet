﻿/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void DescriptionReturnsCorrectString()
        {
            VokunSalad item = new VokunSalad();
            Assert.Equal("A seasonal fruit salad of melons, berries, mango, grape, apple, and oranges.", item.Description);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var side = new VokunSalad();

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
            var side = new VokunSalad();

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
            var side = new VokunSalad();

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
            VokunSalad side = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            VokunSalad side = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad side = new VokunSalad();
            Assert.IsAssignableFrom<Side>(side);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad side = new VokunSalad();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad side = new VokunSalad();
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
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad side = new VokunSalad();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        //[Theory]
        //[InlineData(Size.Small, "Small Vokun Salad")]
        //[InlineData(Size.Medium, "Medium Vokun Salad")]
        //[InlineData(Size.Large, "Large Vokun Salad")]
        //public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        //{
        //    VokunSalad side = new VokunSalad();
        //    side.Size = size;
        //    Assert.Equal(name, side.ToString());
        //}
    }
}