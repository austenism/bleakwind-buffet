﻿/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void DescriptionReturnsCorrectString()
        {
            SailorSoda item = new SailorSoda();
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item.Description);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var drink = new SailorSoda();

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
            var drink = new SailorSoda();

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
            var drink = new SailorSoda();

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
            var drink = new SailorSoda();

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
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            var drink = new SailorSoda();

            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.Blackberry;
            });
            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.Cherry;
            });
            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.Grapefruit;
            });
            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.Lemon;
            });
            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.Peach;
            });
            Assert.PropertyChanged(drink, "Flavor", () =>
            {
                drink.Flavor = SodaFlavor.Watermelon;
            });


        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SailorSoda drink = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda drink = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda drink = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(drink);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda soda = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = false;
            Assert.False(soda.Ice);

            soda.Ice = false;
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = Size.Large;
            Assert.Equal(Size.Large, soda.Size);
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
            soda.Size = Size.Small;
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda soda = new SailorSoda();
            soda.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, soda.Flavor);
            soda.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, soda.Flavor);
            soda.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, soda.Flavor);
            soda.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, soda.Flavor);
            soda.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, soda.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(price, soda.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda soda = new SailorSoda();
            soda.Size = size;
            Assert.Equal(cal, soda.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda soda = new SailorSoda();
            soda.Ice = includeIce;
            if (includeIce)
            {
                Assert.Empty(soda.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold ice", soda.SpecialInstructions);
            }
        }
        
        //[Theory]
        //[InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        //[InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        //[InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        //[InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        //[InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        //[InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        //[InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        //[InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        //[InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        //[InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        //[InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        //[InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        //[InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        //[InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        //[InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        //[InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        //[InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        //[InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        //public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        //{
        //    SailorSoda soda = new SailorSoda();
        //    soda.Size = size;
        //    soda.Flavor = flavor;
        //    Assert.Equal(name, soda.ToString());
        //}
    }
}
