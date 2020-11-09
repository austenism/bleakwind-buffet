/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var dish = new PhillyPoacher();

            Assert.PropertyChanged(dish, "Sirloin", () =>
            {
                dish.Sirloin = true;
            });

            Assert.PropertyChanged(dish, "Sirloin", () =>
            {
                dish.Sirloin = false;
            });
        }
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var dish = new PhillyPoacher();

            Assert.PropertyChanged(dish, "Onion", () =>
            {
                dish.Onion = true;
            });

            Assert.PropertyChanged(dish, "Onion", () =>
            {
                dish.Onion = false;
            });
        }
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var dish = new PhillyPoacher();

            Assert.PropertyChanged(dish, "Roll", () =>
            {
                dish.Roll = true;
            });

            Assert.PropertyChanged(dish, "Roll", () =>
            {
                dish.Roll = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dish);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.True(dish.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.True(dish.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.True(dish.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher dish = new PhillyPoacher();
            dish.Sirloin = false;
            Assert.False(dish.Sirloin);
            dish.Sirloin = true;
            Assert.True(dish.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher dish = new PhillyPoacher();
            dish.Onion = false;
            Assert.False(dish.Onion);

            dish.Onion = true;
            Assert.True(dish.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher dish = new PhillyPoacher();
            dish.Roll = false;
            Assert.False(dish.Roll);
            dish.Roll = true;
            Assert.True(dish.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.Equal(7.23, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher dish = new PhillyPoacher();
            bool result = dish.Calories.Equals(784);
            Assert.True(result);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher dish = new PhillyPoacher();
            dish.Sirloin = includeSirloin;
            dish.Roll = includeRoll;
            dish.Onion = includeOnion;

            if (!includeSirloin)
            {
                Assert.Contains("Hold sirloin", dish.SpecialInstructions);
            }
            if (!includeRoll)
            {
                Assert.Contains("Hold roll", dish.SpecialInstructions);
            }
            if (!includeOnion)
            {
                Assert.Contains("Hold onions", dish.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher dish = new PhillyPoacher();
            Assert.Equal("Philly Poacher\n" + dish.Price, dish.ToString());
        }
    }
}