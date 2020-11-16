using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
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

        public IEnumerable<IOrderItem> DrinksGeneral
        {
            get
            {
                List<IOrderItem> result = new List<IOrderItem>();
                foreach (IOrderItem item in Drinks)
                {
                    if (item is Drink d)
                    {
                        bool add = true;
                        foreach (IOrderItem drink in result)
                        {
                            if (add)
                            {
                                if (d.TypeEquals(drink))
                                {
                                    add = false;
                                }
                            }
                        }
                        if (add)
                        {
                            result.Add(item);
                        }
                    }
                }
                return result;
            }
        }

        public bool GetIfInDrinks(IOrderItem item, Size size)
        {
            if (item is Drink d)
            {
                foreach (IOrderItem drink in Drinks)
                {
                    if (d.TypeEquals(drink))
                    {
                        if (drink is IDrinkItem di)
                        {
                            if (di.Size == size)
                            {
                                d.Size = size;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public IEnumerable<IOrderItem> Sides { get; set; }
        public IEnumerable<IOrderItem> SidesGeneral
        {
            get
            {
                List<IOrderItem> result = new List<IOrderItem>();
                foreach  (IOrderItem item in Sides) {
                    if (item is Side s)
                    {
                        bool add = true;
                        foreach (IOrderItem side in result)
                        {
                            if (add)
                            {
                                if (s.TypeEquals(side))
                                {
                                    add = false;
                                }
                            }
                        }
                        if (add)
                        {
                            result.Add(item);
                        }
                    }
                }
                return result;
            }
        }

        public bool GetIfInSides(IOrderItem item, Size size)
        {
            if (item is Side s) {
                foreach (IOrderItem side in Sides)
                {
                    if (s.TypeEquals(side))
                    {
                        if (side is ISideItem si)
                        {
                            if (si.Size == size)
                            {
                                s.Size = size;
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

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

            if (SearchTerms != null)
            {
                string[] terms = SearchTerms.Split(' ');
                Entrees = Entrees.Where(entree => Array.Exists(terms, element => entree.ToString().Contains(element, StringComparison.InvariantCultureIgnoreCase) || entree.Description.Contains(element, StringComparison.InvariantCultureIgnoreCase)) );
            }
            if (ItemType != null && ItemType.Length != 0)
                Entrees = Entrees.Where(entree => ItemType.Contains("Entree"));
            if (CalorieMin != null || CalorieMax != null)
                Entrees = Entrees.Where(entree => (CalorieMin == null || entree.Calories >= CalorieMin) && (CalorieMax == null || entree.Calories <= CalorieMax));
            if (PriceMin != null || PriceMax != null)
                Entrees = Entrees.Where(entree => (PriceMin == null || entree.Price >= PriceMin) && (PriceMax == null || entree.Price <= PriceMax));

            if (SearchTerms != null)
            {
                string[] terms = SearchTerms.Split(' ');
                Sides = Sides.Where(side => Array.Exists(terms, element => side.ToString().Contains(element, StringComparison.InvariantCultureIgnoreCase) || side.Description.Contains(element, StringComparison.InvariantCultureIgnoreCase)));
            }
            if (ItemType != null && ItemType.Length != 0)
                Sides = Sides.Where(side => ItemType.Contains("Side"));
            if (CalorieMin != null || CalorieMax != null)
                Sides = Sides.Where(side => (CalorieMin == null || side.Calories >= CalorieMin) && (CalorieMax == null || side.Calories <= CalorieMax));
            if (PriceMin != null || PriceMax != null)
                Sides = Sides.Where(side => (PriceMin == null || side.Price >= PriceMin) && (PriceMax == null || side.Price <= PriceMax));

            if (SearchTerms != null)
            {
                string[] terms = SearchTerms.Split(' ');
                Drinks = Drinks.Where(drink => Array.Exists(terms, element => drink.ToString().Contains(element, StringComparison.InvariantCultureIgnoreCase) || drink.Description.Contains(element, StringComparison.InvariantCultureIgnoreCase)) );
            }
            if (ItemType != null && ItemType.Length != 0)
                Drinks = Drinks.Where(drink => ItemType.Contains("Drink"));
            if (CalorieMin != null || CalorieMax != null)
                Drinks = Drinks.Where(drink => (CalorieMin == null || drink.Calories >= CalorieMin) && (CalorieMax == null || drink.Calories <= CalorieMax));
            if (PriceMin != null || PriceMax != null)
                Drinks = Drinks.Where(drink => (PriceMin == null || drink.Price >= PriceMin) && (PriceMax == null || drink.Price <= PriceMax));            
        }
    }
}
