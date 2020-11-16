using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> Items { get; set; }

        public string SearchTerms { get; set; }


        public bool showEntrees { get; set; }
        public bool showDrinks { get; set; }
        public bool showSides { get; set; }

        public int? CaloriesMax { get; set; }
        public int? CaloriesMin { get; set; }
        public double? PriceMax { get; set; }
        public double? PriceMin { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms)
        {
            

            Items = Menu.All;
            // Search stuff for the SearchTerms
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item != null && (item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)));

                ////Items = ItemDatabase.FilterByType(Items, showEntrees, showDrinks, showSides);
            }

            //FILTER BY TYPE
            if (showEntrees)
                Items = Items.Where(item => item != null && item is Entree);
            if (showDrinks)
                Items = Items.Where(item => item != null && item is Drink);
            if (showSides)
                Items = Items.Where(item => item != null && item is Side);

            //CALORIES RANGE
            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(item => item != null && item.Calories <= CaloriesMax);
            }
            if (CaloriesMax == null && CaloriesMin != null)
            {
                Items = Items.Where(item => item != null && item.Calories >= CaloriesMin);
            }
            if (CaloriesMax != null && CaloriesMin != null)
            {
                Items = Items.Where(item => item != null && (item.Calories >= CaloriesMin && item.Calories <= CaloriesMax));
            }
            //PRICE RANGE
            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item => item != null && item.Price <= PriceMax);
            }
            if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(item => item != null && item.Price >= PriceMin);
            }
            if (PriceMax != null && PriceMin != null)
            {
                Items = Items.Where(item => item != null && (item.Price >= PriceMin && item.Price <= PriceMax));
            }

        }

    }
}
