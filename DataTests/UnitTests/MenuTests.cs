using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Linq;
using NuGet.Frameworks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void SearchReturnsCorrectItems()
        {
            List<IOrderItem> list = (List<IOrderItem>)Menu.Search("burg");
            foreach (IOrderItem item in list)
            {//briarheart burger is the only one that passes this
                Assert.True(item is BriarheartBurger);
            }

        }
        [Fact]
        public void FilterByTypeReturnsCorrectItems() 
        {
            IEnumerable<IOrderItem> list = Menu.FullMenu();
            list = Menu.FilterByType(list, true, false, false); //should return only entrees
            foreach (IOrderItem item in list)
            {//entrees are the only one that passes this
                Assert.True(item is Entree);
            }
        }
        [Fact]
        public void FilterByCaloriesShouldReturnCorrectItems()
        {
            IEnumerable<IOrderItem> list = Menu.FullMenu();
            list = Menu.FilterByCalories(list, 0, 0);
            foreach (IOrderItem item in list)
            {//warriorwater is the only one that passes this
                Assert.True(item is WarriorWater);
            }
        }
        [Fact]
        public void FilterByPriceShouldReturnCorrectItems()
        {
            IEnumerable<IOrderItem> list = Menu.FullMenu();
            list = Menu.FilterByPrice(list, 0.0, 0.0);
            foreach (IOrderItem item in list)
            {//warriorwater is the only one that passes this
                Assert.True(item is WarriorWater);
            }
        }


        [Fact]
        public void EntreesShouldReturnCorrectList()
        {
            Assert.Collection(Menu.Entrees(), 
                item => Assert.Equal("Briarheart Burger\n" + item.Price, item.ToString()), 
                item => Assert.Equal("Double Draugr\n" + item.Price, item.ToString()),
                item => Assert.Equal("Garden Orc Omelette\n" + item.Price, item.ToString()),
                item => Assert.Equal("Philly Poacher\n" + item.Price, item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton\n" + item.Price, item.ToString()),
                item => Assert.Equal("Thalmor Triple\n" + item.Price, item.ToString()),
                item => Assert.Equal("Thugs T-Bone\n" + item.Price, item.ToString())
                );
        }

        [Fact]
        public void SidesShouldReturnCorrectList()
        {
            Assert.Collection(Menu.Sides(),
                item => Assert.Equal("Small Dragonborn Waffle Fries\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries\n" + item.Price, item.ToString()),
                
                item => Assert.Equal("Small Fried Miraak\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Fried Miraak\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Fried Miraak\n" + item.Price, item.ToString()),
                
                item => Assert.Equal("Small Mad Otar Grits\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits\n" + item.Price, item.ToString()),
                
                item => Assert.Equal("Small Vokun Salad\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Vokun Salad\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Vokun Salad\n" + item.Price, item.ToString())

                );
        }

        [Fact]
        public void DrinksShouldReturnCorrectList()
        {
            Assert.Collection(Menu.Drinks(),
                item => Assert.Equal("Small Aretino Apple Juice\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Candlehearth Coffee\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Markarth Milk\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Markarth Milk\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Markarth Milk\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Warrior Water\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Warrior Water\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Warrior Water\n" + item.Price, item.ToString()),


                item => Assert.Equal("Small Blackberry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda\n" + item.Price, item.ToString()),

                item => Assert.Equal("Medium Blackberry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda\n" + item.Price, item.ToString()),

                item => Assert.Equal("Large Blackberry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda\n" + item.Price, item.ToString())



                );
        }
        [Fact]
        public void FullMenuShouldReturnCorrectList()
        {
            Assert.Collection(Menu.FullMenu(),
                item => Assert.Equal("Briarheart Burger\n" + item.Price, item.ToString()),
                item => Assert.Equal("Double Draugr\n" + item.Price, item.ToString()),
                item => Assert.Equal("Garden Orc Omelette\n" + item.Price, item.ToString()),
                item => Assert.Equal("Philly Poacher\n" + item.Price, item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton\n" + item.Price, item.ToString()),
                item => Assert.Equal("Thalmor Triple\n" + item.Price, item.ToString()),
                item => Assert.Equal("Thugs T-Bone\n" + item.Price, item.ToString()),


                item => Assert.Equal("Small Dragonborn Waffle Fries\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Fried Miraak\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Fried Miraak\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Fried Miraak\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Mad Otar Grits\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Vokun Salad\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Vokun Salad\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Vokun Salad\n" + item.Price, item.ToString()),




                item => Assert.Equal("Small Aretino Apple Juice\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Candlehearth Coffee\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Markarth Milk\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Markarth Milk\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Markarth Milk\n" + item.Price, item.ToString()),

                item => Assert.Equal("Small Warrior Water\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Warrior Water\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Warrior Water\n" + item.Price, item.ToString()),


                item => Assert.Equal("Small Blackberry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda\n" + item.Price, item.ToString()),

                item => Assert.Equal("Medium Blackberry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda\n" + item.Price, item.ToString()),

                item => Assert.Equal("Large Blackberry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda\n" + item.Price, item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda\n" + item.Price, item.ToString())

                );

        }
    }
}
