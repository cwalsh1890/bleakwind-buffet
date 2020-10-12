/*
 * Author: Coby Walsh
 * Class: Entree.cs
 * Purpose: Class to represent the base Entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees {
	/// <summary>
	/// a base class representing the properties of entrees
	/// </summary>
	public abstract class Entree {
		/// <summary>
		/// Price of entree
		/// </summary>
		/// <value>in US dollars</value>
		public abstract double Price { get; }
		/// <summary>
		/// Calories in Entree
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// special instructions for making the entree
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }

		/// <summary>
		/// creates a way to check if two Entrees are the same
		/// </summary>
		/// <param name="obj">object to compare to entree object</param>
		/// <returns>bool true if equal false if not equal</returns>
		public override bool Equals(object obj) {
			if (obj is Entree e) {
				bool flag = false;
				foreach (string s in SpecialInstructions) {
					if (!e.SpecialInstructions.Contains(s))
						flag = true;
				}
				return this.ToString().Equals(obj.ToString()) && !flag;
			}
			return false;
		}
	}
}
