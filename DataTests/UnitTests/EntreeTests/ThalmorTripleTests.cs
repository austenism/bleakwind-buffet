/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void DescriptionReturnsCorrectString()
        {
            ThalmorTriple item = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", item.Description);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
            var dish = new ThalmorTriple();

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
        public void ChangingBaconNotifiesBaconProperty()
        {
            var dish = new ThalmorTriple();

            Assert.PropertyChanged(dish, "Bacon", () =>
            {
                dish.Bacon = true;
            });

            Assert.PropertyChanged(dish, "Bacon", () =>
            {
                dish.Bacon = false;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var dish = new ThalmorTriple();

            Assert.PropertyChanged(dish, "Egg", () =>
            {
                dish.Egg = true;
            });

            Assert.PropertyChanged(dish, "Egg", () =>
            {
                dish.Egg = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dish);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.True(dish.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Bun = false;
            Assert.False(dish.Bun);
            dish.Bun = true;
            Assert.True(dish.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Ketchup = false;
            Assert.False(dish.Ketchup);
            dish.Ketchup = true;
            Assert.True(dish.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Mustard = false;
            Assert.False(dish.Mustard);
            dish.Mustard = true;
            Assert.True(dish.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Pickle = false;
            Assert.False(dish.Pickle);
            dish.Pickle = true;
            Assert.True(dish.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Cheese = false;
            Assert.False(dish.Cheese);
            dish.Cheese = true;
            Assert.True(dish.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Tomato = false;
            Assert.False(dish.Tomato);
            dish.Tomato = true;
            Assert.True(dish.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Lettuce = false;
            Assert.False(dish.Lettuce);
            dish.Lettuce = true;
            Assert.True(dish.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Mayo = false;
            Assert.False(dish.Mayo);
            dish.Mayo = true;
            Assert.True(dish.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Bacon = false;
            Assert.False(dish.Bacon);
            dish.Bacon = true;
            Assert.True(dish.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Egg = false;
            Assert.False(dish.Egg);
            dish.Egg = true;
            Assert.True(dish.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.Equal(8.32, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple dish = new ThalmorTriple();
            bool result = dish.Calories.Equals(943);
            Assert.True(result);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple dish = new ThalmorTriple();
            dish.Bun = includeBun;
            dish.Cheese = includeCheese;
            dish.Ketchup = includeKetchup;
            dish.Mustard = includeMustard;
            dish.Pickle = includePickle;
            dish.Lettuce = includeLettuce;
            dish.Mayo = includeMayo;
            dish.Tomato = includeTomato;
            dish.Egg = includeEgg;
            dish.Bacon = includeBacon;

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
            if (!includeBacon)
            {
                Assert.Contains("Hold bacon", dish.SpecialInstructions);
            }
            if (!includeEgg)
            {
                Assert.Contains("Hold egg", dish.SpecialInstructions);
            }


        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple dish = new ThalmorTriple();
            Assert.Equal("Thalmor Triple\n" + dish.Price, dish.ToString());
        }
    }
}