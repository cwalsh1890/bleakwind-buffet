/*
 * Author: Coby Walsh
 * Class: Drink.cs
 * Purpose: Class to represent the base Drink
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks {
	/// <summary>
	/// class for representing the properties of drinks
	/// </summary>
	public abstract class Drink : ISizeable {
		/// <summary>
		/// the size of the drink
		/// </summary>
		public abstract Size Size { get; set; }
		/// <summary>
		/// the price of the drink
		/// </summary>
		/// <value>in US dollars</value>
		public abstract double Price { get; }
		/// <summary>
		/// the amount of calories in the drink
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// any special instructions for making the drink
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }

		/// <summary>
		/// creates a way to check if two Drinks are the same
		/// </summary>
		/// <param name="obj">object to compare to drink object</param>
		/// <returns>bool true if equal false if not equal</returns>
		public override bool Equals(object obj) {
			if (obj is Drink d) {
				bool flag = false;
				foreach (string s in SpecialInstructions) {
					if (!d.SpecialInstructions.Contains(s))
						flag = true;
				}
				return this.ToString().Equals(obj.ToString()) && !flag;
			}
			return false;
		}
	}
}
