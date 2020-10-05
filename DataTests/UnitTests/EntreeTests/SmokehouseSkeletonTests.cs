/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ChangingSausageNotifiesSausageProperty()
        {
            var dish = new SmokehouseSkeleton();

            Assert.PropertyChanged(dish, "Sausage", () =>
            {
                dish.SausageLink = true;
            });

            Assert.PropertyChanged(dish, "Sausage", () =>
            {
                dish.SausageLink = false;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var dish = new SmokehouseSkeleton();

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
        public void ChangingHashbrownsNotifiesHashbrownsProperty()
        {
            var dish = new SmokehouseSkeleton();

            Assert.PropertyChanged(dish, "Hashbrowns", () =>
            {
                dish.HashBrowns = true;
            });

            Assert.PropertyChanged(dish, "Hashbrowns", () =>
            {
                dish.HashBrowns = false;
            });
        }
        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var dish = new SmokehouseSkeleton();

            Assert.PropertyChanged(dish, "Pancake", () =>
            {
                dish.Pancake = true;
            });

            Assert.PropertyChanged(dish, "Pancake", () =>
            {
                dish.Pancake = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dish);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.True(dish.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.True(dish.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.True(dish.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.True(dish.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            dish.SausageLink = false;
            Assert.False(dish.SausageLink);
            dish.SausageLink = true;
            Assert.True(dish.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            dish.Egg = false;
            Assert.False(dish.Egg);
            dish.Egg = true;
            Assert.True(dish.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            dish.HashBrowns = false;
            Assert.False(dish.HashBrowns);
            dish.HashBrowns = true;
            Assert.True(dish.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            dish.Pancake = false;
            Assert.False(dish.Pancake);
            dish.Pancake = true;
            Assert.True(dish.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.Equal(5.62, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            bool result = dish.Calories.Equals(602);
            Assert.True(result);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            dish.SausageLink = includeSausage;
            dish.Egg = includeEgg;
            dish.HashBrowns = includeHashbrowns;
            dish.Pancake = includePancake;

            if (!includeSausage)
            {
                Assert.Contains("Hold sausage", dish.SpecialInstructions);
            }
            if (!includeEgg)
            {
                Assert.Contains("Hold eggs", dish.SpecialInstructions);
            }
            if (!includeHashbrowns)
            {
                Assert.Contains("Hold hashbrowns", dish.SpecialInstructions);
            }
            if (!includePancake)
            {
                Assert.Contains("Hold pancake", dish.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton dish = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", dish.ToString());
        }
    }
}