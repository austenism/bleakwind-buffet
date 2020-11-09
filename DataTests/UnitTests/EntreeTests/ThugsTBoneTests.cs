/*
 * Author: Zachery Brunner
 * Edited By: Austen Clemons
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone dish = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(dish);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone dish = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(dish);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone dish = new ThugsTBone();
            Assert.Equal(6.44, dish.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone dish = new ThugsTBone();
            bool result = dish.Calories.Equals(982);
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone dish = new ThugsTBone();
            Assert.Empty(dish.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone dish = new ThugsTBone();
            Assert.Equal("Thugs T-Bone\n" + dish.Price, dish.ToString());
        }
    }
}