/*
 * Author: Coby Walsh
 * Class: Menu.cs
 * Purpose: Static class to obtain lists of menu items
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BleakwindBuffet.Data.Menu {
	public static class Menu {
		/// <summary>
		/// returns all possible entrees from the menu
		/// </summary>
		/// <returns>List of IOrderItem</returns>
		public static List<IOrderItem> Entrees() {
			List<IOrderItem> items = new List<IOrderItem>();
			items.Add(new BriarheartBurger());
			items.Add(new DoubleDraugr());
			items.Add(new GardenOrcOmelette());
			items.Add(new PhillyPoacher());
			items.Add(new SmokehouseSkeleton());
			items.Add(new ThalmorTriple());
			items.Add(new ThugsTBone());
			return items;
		}

		/// <summary>
		/// returns all possible sides from the menu
		/// </summary>
		/// <returns>List of IOrderItem</returns>
		public static List<IOrderItem> Sides() {
			List<IOrderItem> items = new List<IOrderItem>();
			DragonbornWaffleFries wf = new DragonbornWaffleFries();
			items.Add(wf);
			wf = new DragonbornWaffleFries();
			wf.Size = Size.Medium;
			items.Add(wf);
			wf = new DragonbornWaffleFries();
			wf.Size = Size.Large;
			items.Add(wf);

			FriedMiraak fm = new FriedMiraak();
			items.Add(fm);
			fm = new FriedMiraak();
			fm.Size = Size.Medium;
			items.Add(fm);
			fm = new FriedMiraak();
			fm.Size = Size.Large;
			items.Add(fm);

			MadOtarGrits og = new MadOtarGrits();
			items.Add(og);
			og = new MadOtarGrits();
			og.Size = Size.Medium;
			items.Add(og);
			og = new MadOtarGrits();
			og.Size = Size.Large;
			items.Add(og);

			VokunSalad vs = new VokunSalad();
			items.Add(vs);
			vs = new VokunSalad();
			vs.Size = Size.Medium;
			items.Add(vs);
			vs = new VokunSalad();
			vs.Size = Size.Large;
			items.Add(vs);

			return items;
		}

		public static List<IOrderItem> SmallSides()
		{
			List<IOrderItem> items = new List<IOrderItem>();
			DragonbornWaffleFries wf = new DragonbornWaffleFries();
			items.Add(wf);

			FriedMiraak fm = new FriedMiraak();
			items.Add(fm);

			MadOtarGrits og = new MadOtarGrits();
			items.Add(og);

			VokunSalad vs = new VokunSalad();
			items.Add(vs);

			return items;
		}

		/// <summary>
		/// returns all possible drinks from the menus
		/// </summary>
		/// <returns>List of IOrderItem</returns>
		public static List<IOrderItem> Drinks() {
			List<IOrderItem> items = new List<IOrderItem>();
			ArentinoAppleJuice aj = new ArentinoAppleJuice();
			items.Add(aj);
			aj = new ArentinoAppleJuice();
			aj.Size = Size.Medium;
			items.Add(aj);
			aj = new ArentinoAppleJuice();
			aj.Size = Size.Large;
			items.Add(aj);

			CandlehearthCoffee cc = new CandlehearthCoffee();
			items.Add(cc);
			cc = new CandlehearthCoffee();
			cc.Size = Size.Medium;
			items.Add(cc);
			cc = new CandlehearthCoffee();
			cc.Size = Size.Large;
			items.Add(cc);

			MarkarthMilk mm = new MarkarthMilk();
			items.Add(mm);
			mm = new MarkarthMilk();
			mm.Size = Size.Medium;
			items.Add(mm);
			mm = new MarkarthMilk();
			mm.Size = Size.Large;
			items.Add(mm);

			WarriorWater ww = new WarriorWater();
			items.Add(ww);
			ww = new WarriorWater();
			ww.Size = Size.Medium;
			items.Add(ww);
			ww = new WarriorWater();
			ww.Size = Size.Large;
			items.Add(ww);

			SailorSoda ss = new SailorSoda();
			items.Add(ss);
			ss = new SailorSoda();
			ss.Flavor = SodaFlavor.Blackberry;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Flavor = SodaFlavor.Watermelon;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Flavor = SodaFlavor.Grapefruit;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Flavor = SodaFlavor.Lemon;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Flavor = SodaFlavor.Peach;
			items.Add(ss);

			ss = new SailorSoda();
			ss.Size = Size.Medium;
			ss.Flavor = SodaFlavor.Cherry;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Medium;
			ss.Flavor = SodaFlavor.Blackberry;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Medium;
			ss.Flavor = SodaFlavor.Watermelon;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Medium;
			ss.Flavor = SodaFlavor.Grapefruit;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Medium;
			ss.Flavor = SodaFlavor.Lemon;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Medium;
			ss.Flavor = SodaFlavor.Peach;
			items.Add(ss);

			ss = new SailorSoda();
			ss.Size = Size.Large;
			ss.Flavor = SodaFlavor.Cherry;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Large;
			ss.Flavor = SodaFlavor.Blackberry;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Large;
			ss.Flavor = SodaFlavor.Watermelon;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Large;
			ss.Flavor = SodaFlavor.Grapefruit;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Large;
			ss.Flavor = SodaFlavor.Lemon;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Large;
			ss.Flavor = SodaFlavor.Peach;
			items.Add(ss);

			return items;
		}
		public static List<IOrderItem> SmallDrinks()
		{
			List<IOrderItem> items = new List<IOrderItem>();
			ArentinoAppleJuice aj = new ArentinoAppleJuice();
			items.Add(aj);
			aj = new ArentinoAppleJuice();
			aj.Size = Size.Medium;
			items.Add(aj);
			aj = new ArentinoAppleJuice();
			aj.Size = Size.Large;
			items.Add(aj);

			CandlehearthCoffee cc = new CandlehearthCoffee();
			items.Add(cc);
			cc = new CandlehearthCoffee();
			cc.Size = Size.Medium;
			items.Add(cc);
			cc = new CandlehearthCoffee();
			cc.Size = Size.Large;
			items.Add(cc);

			MarkarthMilk mm = new MarkarthMilk();
			items.Add(mm);
			mm = new MarkarthMilk();
			mm.Size = Size.Medium;
			items.Add(mm);
			mm = new MarkarthMilk();
			mm.Size = Size.Large;
			items.Add(mm);

			WarriorWater ww = new WarriorWater();
			items.Add(ww);
			ww = new WarriorWater();
			ww.Size = Size.Medium;
			items.Add(ww);
			ww = new WarriorWater();
			ww.Size = Size.Large;
			items.Add(ww);

			SailorSoda ss = new SailorSoda();
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Medium;
			items.Add(ss);
			ss = new SailorSoda();
			ss.Size = Size.Large;
			items.Add(ss);

			return items;
		}
		

		/// <summary>
		/// returns all possible menu items
		/// </summary>
		/// <returns>List of IOrderItem</returns>
		public static List<IOrderItem> FullMenu() {
			List<IOrderItem> entrees = Entrees();
			List<IOrderItem> sides = Sides();
			List<IOrderItem> drinks = Drinks();
			entrees.AddRange(sides);
			entrees.AddRange(drinks);
			return entrees;
		}

		public static IEnumerable<IOrderItem> FilterByName(IEnumerable<IOrderItem> items, string name)
        {
			if (name == null)
				return items;

			List<IOrderItem> results = new List<IOrderItem>();

			foreach (IOrderItem item in items)
            {
				string s = item.ToString();
				s.ToLower();
				name.ToLower();
				if (s.Contains(name))
					results.Add(item);
            }
			return results;
        }

		public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> items, string[] types)
        {
			if (types.Length == 0)
				return items;

			List<IOrderItem> results = new List<IOrderItem>();

			foreach (IOrderItem item in items)
            {
				foreach (string type in types)
                {
					switch (type)
                    {
						case "Entree":
							if (item is Entree)
								results.Add(item);
							break;
						case "Drink":
							if (item is Drink)
								results.Add(item);
							break;
						case "Side":
							if (item is Side)
								results.Add(item);
							break;
					}
                }
            }
			return results;
		}

		public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
		{
			if (min == null && max == null)
			{
				return items;
			}
			else if (min == null && max != null)
			{
				min = 0;
			}
			else if (min != null && max == null)
			{
				max = 9999;
			}

			List<IOrderItem> results = new List<IOrderItem>();

			foreach (IOrderItem item in items)
			{
				if (item.Calories >= min && item.Calories <= max)
					results.Add(item);
			}
			return results;
		}

		public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
		{
			if (min == null && max == null)
			{
				return items;
			}
			else if (min == null && max != null)
			{
				min = 0;
			}
			else if (min != null && max == null)
			{
				max = 9999;
			}

			List<IOrderItem> results = new List<IOrderItem>();

			foreach (IOrderItem item in items)
			{
				if (item.Price >= min && item.Price <= max)
					results.Add(item);
			}
			return results;
		}
	}
}
