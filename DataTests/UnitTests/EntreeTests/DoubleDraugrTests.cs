/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dish = new DoubleDraugr();

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
            var dish = new DoubleDraugr();

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
            var dish = new DoubleDraugr();

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
            var dish = new DoubleDraugr();

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
            var dish = new DoubleDraugr();

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
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dish = new DoubleDraugr();

            Assert.PropertyChanged(dish, "Tomato", () =>
            {
                dish.Tomato = true;
            });

            Assert.PropertyChanged(dish, "Tomato", () =>
            {
                dish.Tomato = false;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var dish = new DoubleDraugr();

            Assert.PropertyChanged(dish, "Lettuce", () =>
            {
                dish.Lettuce = true;
            });

            Assert.PropertyChanged(dish, "Lettuce", () =>
            {
                dish.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var dish = new DoubleDraugr();

            Assert.PropertyChanged(dish, "Mayo", () =>
            {
                dish.Mayo = true;
            });

            Assert.PropertyChanged(dish, "Mayo", () =>
            {
                dish.Mayo = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dish);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.True(dish.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Bun = false;
            Assert.False(dish.Bun);
            dish.Bun = true;
            Assert.True(dish.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Ketchup = false;
            Assert.False(dish.Ketchup);
            dish.Ketchup = true;
            Assert.True(dish.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Mustard = false;
            Assert.False(dish.Mustard);
            dish.Mustard = true;
            Assert.True(dish.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Pickle = false;
            Assert.False(dish.Pickle);
            dish.Pickle = true;
            Assert.True(dish.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Cheese = false;
            Assert.False(dish.Cheese);
            dish.Cheese = true;
            Assert.True(dish.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Tomato = false;
            Assert.False(dish.Tomato);
            dish.Tomato = true;
            Assert.True(dish.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Lettuce = false;
            Assert.False(dish.Lettuce);
            dish.Lettuce = true;
            Assert.True(dish.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Mayo = false;
            Assert.False(dish.Mayo);
            dish.Mayo = true;
            Assert.True(dish.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.Equal(7.32, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dish = new DoubleDraugr();
            bool result = dish.Calories.Equals(843);
            Assert.True(result);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dish = new DoubleDraugr();
            dish.Bun = includeBun;
            dish.Cheese = includeCheese;
            dish.Ketchup = includeKetchup;
            dish.Mustard = includeMustard;
            dish.Pickle = includePickle;
            dish.Lettuce = includeLettuce;
            dish.Mayo = includeMayo;
            dish.Tomato = includeTomato;

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
            if (!includeLettuce)
            {
                Assert.Contains("Hold lettuce", dish.SpecialInstructions);
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", dish.SpecialInstructions);
            }
            if (!includeMayo)
            {
                Assert.Contains("Hold mayo", dish.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dish = new DoubleDraugr();
            Assert.Equal("Double Draugr\n" + dish.Price, dish.ToString());
        }
    }
}