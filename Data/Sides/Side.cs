/*
 * Author: Coby Walsh
 * Class: Side.cs
 * Purpose: Class to represent the base Side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Sides {
	/// <summary>
	/// class for representing the properties of sides
	/// </summary>
	public abstract class Side : ISizeable {
		/// <summary>
		/// the size of the side
		/// </summary>
		public abstract Size Size { get; set; }
		/// <summary>
		/// the price of the side
		/// </summary>
		/// <value>in US dollars</value>
		public abstract double Price { get; }
		/// <summary>
		/// the amount of calories in the side
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// any special instructions for making the side
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }

		/// <summary>
		/// creates a way to check if two Sides are the same
		/// </summary>
		/// <param name="obj">object to compare to side object</param>
		/// <returns>bool true if equal false if not equal</returns>
		public override bool Equals(object obj) {
			return this.ToString().Equals(obj.ToString());
		}
	}
}
