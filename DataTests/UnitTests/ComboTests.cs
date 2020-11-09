using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;
using System.Data;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        //[Fact]
        //public void ChangingDrinkNotifiesProperties()
        //{
        //    Combo combo = new Combo();
        //    Assert.PropertyChanged(combo, "Drink", () =>
        //    {
        //        combo.Drink = new AretinoAppleJuice();
        //    });
        //    Assert.PropertyChanged(combo, "Price", () =>
        //    {
        //        combo.Drink = new AretinoAppleJuice();
        //    });
        //    Assert.PropertyChanged(combo, "Calories", () =>
        //    {
        //        combo.Drink = new Data.Drinks.AretinoAppleJuice();
        //    });
        //    Assert.PropertyChanged(combo, "SpecialInstructions", () =>
        //    {
        //        combo.Drink = new AretinoAppleJuice();
        //    });
        //}
        //[Fact]
        //public void ChangingEntreeNotifiesProperties()
        //{
        //    Combo combo = new Combo();
        //    Assert.PropertyChanged(combo, "Entree", () =>
        //    {
        //        combo.Entree = new BriarheartBurger();
        //    });
        //    Assert.PropertyChanged(combo, "Price", () =>
        //    {
        //        combo.Entree = new BriarheartBurger();
        //    });
        //    Assert.PropertyChanged(combo, "Calories", () =>
        //    {
        //        combo.Entree = new BriarheartBurger();
        //    });
        //    Assert.PropertyChanged(combo, "SpecialInstructions", () =>
        //    {
        //        combo.Entree = new BriarheartBurger();
        //    });
        //}
        //[Fact]
        //public void ChangingSideNotifiesProperties()
        //{
        //    Combo combo = new Combo();
        //    Assert.PropertyChanged(combo, "Side", () =>
        //    {
        //        combo.Side = new DragonbornWaffleFries();
        //    });
        //    Assert.PropertyChanged(combo, "Price", () =>
        //    {
        //        combo.Side = new DragonbornWaffleFries();
        //    });
        //    Assert.PropertyChanged(combo, "Calories", () =>
        //    {
        //        combo.Side = new DragonbornWaffleFries();
        //    });
        //    Assert.PropertyChanged(combo, "SpecialInstructions", () =>
        //    {
        //        combo.Side = new DragonbornWaffleFries();
        //    });
        //}
        /*[Fact]
        public void ChangingPriceOfItemNotifiesMainPrice()
        {
            Combo combo = new Combo();
            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side.Size = Size.Large;
            });
        }*/

        [Fact]
        public void SendsCorrectPriceAndCaloriesTotalForItems()
        {
            Combo combo = new Combo();
            combo.Entree = new BriarheartBurger();
            combo.Drink = new AretinoAppleJuice();
            combo.Side = new DragonbornWaffleFries();

            Assert.Equal(6.36, combo.Price);
            Assert.Equal(864, (double)combo.Calories);
        }
    }
}
