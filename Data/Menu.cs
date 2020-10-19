/*
*Author: Austen Clemons
* Class name: Combo.cs
* Purpose: To contain the properties of the Menu
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// contains the entrees
        /// </summary>
        /// <returns>an instance of all the entrees on the menu</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            yield return new BriarheartBurger();
            yield return new DoubleDraugr();
            yield return new GardenOrcOmelette();
            yield return new PhillyPoacher();
            yield return new SmokehouseSkeleton();
            yield return new ThalmorTriple();
            yield return new ThugsTBone();
        }
        /// <summary>
        /// contains the sides
        /// </summary>
        /// <returns>an instance of all the sides on the menu</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            //add DragonBornWaffleFries
            Side side = new DragonbornWaffleFries();
            side.Size = Size.Small;
            yield return side;
            side = new DragonbornWaffleFries();
            side.Size = Size.Medium;
            yield return side;
            side = new DragonbornWaffleFries();
            side.Size = Size.Large;
            yield return side;
            //add FriedMirrak
            side = new FriedMiraak();
            side.Size = Size.Small;
            yield return side;
            side = new FriedMiraak();
            side.Size = Size.Medium;
            yield return side;
            side = new FriedMiraak();
            side.Size = Size.Large;
            yield return side;
            //add MadOtarGrits
            side = new MadOtarGrits();
            side.Size = Size.Small;
            yield return side;
            side = new MadOtarGrits();
            side.Size = Size.Medium;
            yield return side;
            side = new MadOtarGrits();
            side.Size = Size.Large;
            yield return side;
            //add VokunSalad
            side = new VokunSalad();
            side.Size = Size.Small;
            yield return side;
            side = new VokunSalad();
            side.Size = Size.Medium;
            yield return side;
            side = new VokunSalad();
            side.Size = Size.Large;
            yield return side;

        }
        /// <summary>
        /// contains the drinks
        /// </summary>
        /// <returns>an instance of all the drinks on the menu</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {

            //add AretinoAppleJuice
            Drink drink = new AretinoAppleJuice();
            drink.Size = Size.Small;
            yield return drink;
            drink = new AretinoAppleJuice();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new AretinoAppleJuice();
            drink.Size = Size.Large;
            yield return drink;

            //add CandleHearthCoffee
            drink = new CandlehearthCoffee();
            drink.Size = Size.Small;
            yield return drink;
            drink = new CandlehearthCoffee();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new CandlehearthCoffee();
            drink.Size = Size.Large;
            yield return drink;

            //add MarkarthMilk
            drink = new MarkarthMilk();
            drink.Size = Size.Small;
            yield return drink;
            drink = new MarkarthMilk();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new MarkarthMilk();
            drink.Size = Size.Large;
            yield return drink;

            //add WarriorWater
            drink = new WarriorWater();
            drink.Size = Size.Small;
            yield return drink;
            drink = new WarriorWater();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new WarriorWater();
            drink.Size = Size.Large;
            yield return drink;

            //add all forms of SailorSoda
            SailorSoda soda = new SailorSoda();
                //all small forms
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Blackberry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Cherry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Grapefruit;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Lemon;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Peach;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Watermelon;
            yield return soda;
            //all medium forms
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Blackberry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Cherry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Grapefruit;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Lemon;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Peach;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Watermelon;
            yield return soda;
            //all large forms
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Blackberry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Cherry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Grapefruit;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Lemon;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Peach;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Watermelon;
            yield return soda;
        }
        /// <summary>
        /// contains all menu items
        /// </summary>
        /// <returns>an instance of all items on menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            //add all the entrees
            yield return new BriarheartBurger();
            yield return new DoubleDraugr();
            yield return new GardenOrcOmelette();
            yield return new PhillyPoacher();
            yield return new SmokehouseSkeleton();
            yield return new ThalmorTriple();
            yield return new ThugsTBone();


            //add all the sides

            //add DragonBornWaffleFries
            Side side = new DragonbornWaffleFries();
            side.Size = Size.Small;
            yield return side;
            side = new DragonbornWaffleFries();
            side.Size = Size.Medium;
            yield return side;
            side = new DragonbornWaffleFries();
            side.Size = Size.Large;
            yield return side;
            //add FriedMirrak
            side = new FriedMiraak();
            side.Size = Size.Small;
            yield return side;
            side = new FriedMiraak();
            side.Size = Size.Medium;
            yield return side;
            side = new FriedMiraak();
            side.Size = Size.Large;
            yield return side;
            //add MadOtarGrits
            side = new MadOtarGrits();
            side.Size = Size.Small;
            yield return side;
            side = new MadOtarGrits();
            side.Size = Size.Medium;
            yield return side;
            side = new MadOtarGrits();
            side.Size = Size.Large;
            yield return side;
            //add VokunSalad
            side = new VokunSalad();
            side.Size = Size.Small;
            yield return side;
            side = new VokunSalad();
            side.Size = Size.Medium;
            yield return side;
            side = new VokunSalad();
            side.Size = Size.Large;
            yield return side;


            //add all the drinks

            //add AretinoAppleJuice
            Drink drink = new AretinoAppleJuice();
            drink.Size = Size.Small;
            yield return drink;
            drink = new AretinoAppleJuice();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new AretinoAppleJuice();
            drink.Size = Size.Large;
            yield return drink;
            //add CandleHearthCoffee
            drink = new CandlehearthCoffee();
            drink.Size = Size.Small;
            yield return drink;
            drink = new CandlehearthCoffee();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new CandlehearthCoffee();
            drink.Size = Size.Large;
            yield return drink;
            //add MarkarthMilk
            drink = new MarkarthMilk();
            drink.Size = Size.Small;
            yield return drink;
            drink = new MarkarthMilk();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new MarkarthMilk();
            drink.Size = Size.Large;
            yield return drink;
            //add WarriorWater
            drink = new WarriorWater();
            drink.Size = Size.Small;
            yield return drink;
            drink = new WarriorWater();
            drink.Size = Size.Medium;
            yield return drink;
            drink = new WarriorWater();
            drink.Size = Size.Large;
            yield return drink;

            //add all forms of SailorSoda
            SailorSoda soda = new SailorSoda();
            //all small forms
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Blackberry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Cherry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Grapefruit;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Lemon;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Peach;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Small;
            soda.Flavor = SodaFlavor.Watermelon;
            yield return soda;
            //all medium forms
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Blackberry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Cherry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Grapefruit;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Lemon;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Peach;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Medium;
            soda.Flavor = SodaFlavor.Watermelon;
            yield return soda;
            //all large forms
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Blackberry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Cherry;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Grapefruit;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Lemon;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Peach;
            yield return soda;
            soda = new SailorSoda();
            soda.Size = Size.Large;
            soda.Flavor = SodaFlavor.Watermelon;
            yield return soda;
        }
    }
}
