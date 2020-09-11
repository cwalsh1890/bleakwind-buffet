﻿/*
 * Author: Coby Walsh
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent philly cheese steak
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
	public class PhillyPoacher : Entree, IOrderItem {
		/// <summary>
		/// holds whether or not the sandwich should have steak
		/// </summary>
		private bool sirloin = true;
		public bool Sirloin {
			get { return this.sirloin; }
			set {
				if (value != sirloin) {
					if (value) {
						sirloin = true;
						specialInstructions.Remove("Hold sirloin");
					}
					else {
						sirloin = false;
						specialInstructions.Add("Hold sirloin");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the sandwich should have onion
		/// </summary>
		private bool onion = true;
		public bool Onion {
			get { return this.onion; }
			set {
				if (value != onion) {
					if (value) {
						onion = true;
						specialInstructions.Remove("Hold onion");
					}
					else {
						onion = false;
						specialInstructions.Add("Hold onion");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the sandwich should have a roll
		/// </summary>
		private bool roll = true;
		public bool Roll {
			get { return this.roll; }
			set {
				if (value != roll) {
					if (value) {
						roll = true;
						specialInstructions.Remove("Hold roll");
					}
					else {
						roll = false;
						specialInstructions.Add("Hold roll");
					}
				}
			}
		}

		/// <summary>
		/// holds the price of the sandwich
		/// </summary>
		public override double Price { get; } = 7.23;

		/// <summary>
		/// holds the calories of the sandwich
		/// </summary>
		public override uint Calories { get; } = 784;

		/// <summary>
		/// holds any special instructions for the sandwich
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns the item name
		/// </summary>
		/// <returns>item name</returns>
		public override string ToString() {
			return "Philly Poacher";
		}
	}
}
