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


        [BindProperty]
        public bool showEntrees { get; set; }
        [BindProperty]
        public bool showDrinks { get; set; }
        [BindProperty]
        public bool showSides { get; set; }

        [BindProperty]
        public int? CaloriesMax { get; set; }
        [BindProperty]
        public int? CaloriesMin { get; set; }
        
        [BindProperty]
        public double? PriceMax { get; set; }
        [BindProperty]
        public double? PriceMin { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet(string SearchTerms)
        {
            Items = Menu.Search(SearchTerms);
            //Items = ItemDatabase.FilterByType(Items, showEntrees, showDrinks, showSides);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
        
        
        

    }
}
