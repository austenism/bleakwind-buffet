/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var dish = new GardenOrcOmelette();

            Assert.PropertyChanged(dish, "Broccoli", () =>
            {
                dish.Broccoli = true;
            });

            Assert.PropertyChanged(dish, "Broccoli", () =>
            {
                dish.Broccoli = false;
            });
        }
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var dish = new GardenOrcOmelette();

            Assert.PropertyChanged(dish, "Mushrooms", () =>
            {
                dish.Mushrooms = true;
            });

            Assert.PropertyChanged(dish, "Mushrooms", () =>
            {
                dish.Mushrooms = false;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var dish = new GardenOrcOmelette();

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
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var dish = new GardenOrcOmelette();

            Assert.PropertyChanged(dish, "Cheddar", () =>
            {
                dish.Cheddar = true;
            });

            Assert.PropertyChanged(dish, "Cheddar", () =>
            {
                dish.Cheddar = false;
            });
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dish);
        }
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.True(dish.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.True(dish.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.True(dish.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.True(dish.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            dish.Broccoli = false;
            Assert.False(dish.Broccoli);
            dish.Broccoli = true;
            Assert.True(dish.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            dish.Mushrooms = false;
            Assert.False(dish.Mushrooms);
            dish.Mushrooms = true;
            Assert.True(dish.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            dish.Tomato = false;
            Assert.False(dish.Tomato);
            dish.Tomato = true;
            Assert.True(dish.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            dish.Cheddar = false;
            Assert.False(dish.Cheddar);
            dish.Cheddar = true;
            Assert.True(dish.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.Equal(4.57, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            bool result = dish.Calories.Equals(404);
            Assert.True(result);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            dish.Broccoli = includeBroccoli;
            dish.Cheddar = includeCheddar;
            dish.Mushrooms = includeMushrooms;
            dish.Tomato = includeTomato;

            if (!includeBroccoli)
            {
                Assert.Contains("Hold broccoli", dish.SpecialInstructions);
            }
            if (!includeCheddar)
            {
                Assert.Contains("Hold cheddar", dish.SpecialInstructions);
            }
            if (!includeMushrooms)
            {
                Assert.Contains("Hold mushrooms", dish.SpecialInstructions);
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", dish.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette dish = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", dish.ToString());
        }
    }
}