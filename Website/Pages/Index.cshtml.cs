using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> Entrees { get; set; } 
        public IEnumerable<IOrderItem> Drinks { get; set; }
        public IEnumerable<IOrderItem> Sides { get; set; }

        public string SearchTerms { get; set; }
        public string[] ItemType { get; set; }

        public uint? CalorieMin { get; set; }
        public uint? CalorieMax { get; set; }

        public double? PriceMin {get; set; }
        public double? PriceMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Entrees = Menu.Entrees();
            Sides = Menu.Sides();
            Drinks = Menu.SmallDrinks();

            SearchTerms = Request.Query["SearchTerms"];
            ItemType = Request.Query["ItemType"];

            string s = Request.Query["CalorieMin"].ToString();
            if (s.Length > 0) 
                CalorieMin = uint.Parse(s);
            else
                CalorieMin = null;

            s = Request.Query["CalorieMax"].ToString();
            if (s.Length > 0)
                CalorieMax = uint.Parse(s);
            else
                CalorieMax = null;

            s = Request.Query["PriceMin"].ToString();
            if (s.Length > 0)
                PriceMin = double.Parse(s);
            else
                PriceMin = null;

            s = Request.Query["PriceMax"].ToString();
            if (s.Length > 0)
                PriceMax = double.Parse(s);
            else
                PriceMax = null;

            
            Entrees = Menu.FilterByName(Entrees, SearchTerms);
            Entrees = Menu.FilterByItemType(Entrees, ItemType);
            Entrees = Menu.FilterByCalories(Entrees, CalorieMin, CalorieMax);
            Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
            
            Sides = Menu.FilterByName(Sides, SearchTerms);
            Sides = Menu.FilterByItemType(Sides, ItemType);
            Sides = Menu.FilterByCalories(Sides, CalorieMin, CalorieMax);
            Sides = Menu.FilterByPrice(Sides, PriceMin, PriceMax);

            Drinks = Menu.FilterByName(Drinks, SearchTerms);
            Drinks = Menu.FilterByItemType(Drinks, ItemType);
            Drinks = Menu.FilterByCalories(Drinks, CalorieMin, CalorieMax);
            Drinks = Menu.FilterByPrice(Drinks, PriceMin, PriceMax);

            
        }
    }
}
