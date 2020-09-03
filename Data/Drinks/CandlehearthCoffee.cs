/*
 * Author: Coby Walsh
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Coffee in order
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks {
	class CandlehearthCoffee {
		/// <summary>
		/// holds the size of the coffee
		/// </summary>
		private Size size = Size.Small;
		public Size Size {
			get { return this.size; }
			set {
				size = value;
			}
		}

		/// <summary>
		/// holds whether or not the drink should have ice
		/// </summary>
		private bool ice = false;
		public bool Ice {
			get { return this.ice; }
			set {
				if (value != ice) {
					if (value) {
						ice = true;
						specialInstructions.Add("Add ice");
					}
					else {
						ice = false;
						specialInstructions.Remove("Add ice");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the coffee should be decaf
		/// </summary>
		private bool decaf = false;
		public bool Decaf {
			get { return this.decaf; }
			set {
				decaf = value;
			}
		}

		/// <summary>
		/// holds whether or not the drink should have cream
		/// </summary>
		private bool roomForCream = false;
		public bool RoomForCream {
			get { return this.roomForCream; }
			set {
				if (value != roomForCream) {
					if (value) {
						roomForCream = true;
						specialInstructions.Add("Add cream");
					}
					else {
						roomForCream = false;
						specialInstructions.Remove("Add cream");
					}
				}
			}
		}

		/// <summary>
		/// holds the price for the different sizes of drink
		/// </summary>
		public double Price {
			get {
				switch (size) {
					case Size.Small:
						return .75;
					case Size.Medium:
						return 1.25;
					case Size.Large:
						return 1.75;
				}
				return 0;
			}
		}

		/// <summary>
		/// holds the amount of calories for a specific drink
		/// </summary>
		public uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 7;
					case Size.Medium:
						return 10;
					case Size.Large:
						return 20;
				}
				return 0;
			}
		}

		/// <summary>
		/// holds any special instructions for making the drink
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns string of drink info
		/// </summary>
		/// <returns>drink size then if its decaf then drink name</returns>
		public override string ToString() {
			if (decaf) {
				return $"{Enum.GetName(typeof(Size), size)} Candlehearth Coffee";
			}
			else {
				return $"{Enum.GetName(typeof(Size), size)} Decaf Candlehearth Coffee";
			}
		}
	}
}
