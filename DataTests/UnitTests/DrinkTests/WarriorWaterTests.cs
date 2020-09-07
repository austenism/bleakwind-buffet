﻿/*
 * Author: Austen Clemons
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.True(drink.Ice);
        }
        
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.False(drink.Lemon);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal(Size.Small, drink.size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = false;
            Assert.False(drink.Ice);
            drink.Ice = true;
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldByAbleToSetLemon()
        {
            WarriorWater drink = new WarriorWater();
            drink.Lemon = true;
            Assert.True(drink.Lemon);
            drink.Lemon = false;
            Assert.False(drink.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater drink = new WarriorWater();
            drink.size = Size.Large;
            Assert.Equal(Size.Large, drink.size);
            drink.size = Size.Medium;
            Assert.Equal(Size.Medium, drink.size);
            drink.size = Size.Small;
            Assert.Equal(Size.Small, drink.size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater drink = new WarriorWater();
            drink.size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater drink = new WarriorWater();
            drink.size = size;
            Assert.Equal(cal, drink.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = includeIce;
            drink.Lemon = includeLemon;
            if (!includeIce)
            {
                Assert.Contains("Hold ice", drink.SpecialInstructions);
            }
            if (includeLemon)
            {
                Assert.Contains("Add lemon", drink.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater drink = new WarriorWater();
            drink.size = size;
            Assert.Equal(name, drink.ToString());
        }
    }

}
