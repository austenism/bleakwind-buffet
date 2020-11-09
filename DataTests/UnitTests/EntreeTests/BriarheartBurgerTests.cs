/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dish = new BriarheartBurger();

            Assert.PropertyChanged(dish, "Bun", () =>
            {
                dish.Bun = true;
            });

            Assert.PropertyChanged(dish, "Bun", () =>
            {
                dish.Bun = false;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var dish = new BriarheartBurger();

            Assert.PropertyChanged(dish, "Ketchup", () =>
            {
                dish.Ketchup = true;
            });

            Assert.PropertyChanged(dish, "Ketchup", () =>
            {
                dish.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var dish = new BriarheartBurger();

            Assert.PropertyChanged(dish, "Mustard", () =>
            {
                dish.Mustard = true;
            });

            Assert.PropertyChanged(dish, "Mustard", () =>
            {
                dish.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var dish = new BriarheartBurger();

            Assert.PropertyChanged(dish, "Pickle", () =>
            {
                dish.Pickle = true;
            });

            Assert.PropertyChanged(dish, "Pickle", () =>
            {
                dish.Pickle = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var dish = new BriarheartBurger();

            Assert.PropertyChanged(dish, "Cheese", () =>
            {
                dish.Cheese = true;
            });

            Assert.PropertyChanged(dish, "Cheese", () =>
            {
                dish.Cheese = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dish);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.True(dish.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.True(dish.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.True(dish.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.True(dish.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.True(dish.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger dish = new BriarheartBurger();
            dish.Bun = false;
            Assert.False(dish.Bun);
            dish.Bun = true;
            Assert.True(dish.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger dish = new BriarheartBurger();
            dish.Ketchup = false;
            Assert.False(dish.Ketchup);
            dish.Ketchup = true;
            Assert.True(dish.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger dish = new BriarheartBurger();
            dish.Mustard = false;
            Assert.False(dish.Mustard);
            dish.Mustard = true;
            Assert.True(dish.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger dish = new BriarheartBurger();
            dish.Pickle = false;
            Assert.False(dish.Pickle);
            dish.Pickle = true;
            Assert.True(dish.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger dish = new BriarheartBurger();
            dish.Cheese = false;
            Assert.False(dish.Cheese);
            dish.Cheese = true;
            Assert.True(dish.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.Equal(6.32, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger dish = new BriarheartBurger();
            bool result = dish.Calories.Equals(743);
            Assert.True(result);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                               bool includePickle, bool includeCheese)
        {
            BriarheartBurger dish = new BriarheartBurger();
            dish.Bun = includeBun;
            dish.Cheese = includeCheese;
            dish.Ketchup = includeKetchup;
            dish.Mustard = includeMustard;
            dish.Pickle = includePickle;

            if (!includeBun)
            {
                Assert.Contains("Hold bun", dish.SpecialInstructions);
            }
            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", dish.SpecialInstructions);
            }
            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", dish.SpecialInstructions);
            }
            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", dish.SpecialInstructions);
            }
            if (!includePickle)
            {
                Assert.Contains("Hold pickle", dish.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger dish = new BriarheartBurger();
            Assert.Equal("Briarheart Burger\n" + dish.Price, dish.ToString());
        }
    }
}