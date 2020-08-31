/*
 * Author: Coby Walsh
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Apple juice in order
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace Data.Drinks {
	class ArentinoAppleJuice {
		/// <summary>
		/// holds size of the drink
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
		/// holds the price of the drink based on size
		/// </summary>
		public double Price {
			get {
				switch (size) {
					case Size.Small:
						return .62;
					case Size.Medium:
						return .87;
					case Size.Large:
						return 1.01;
				}
				return 0;
			}
		}

		/// <summary>
		/// holds the amount of calories based on size of drink
		/// </summary>
		public uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 44;
					case Size.Medium:
						return 88;
					case Size.Large:
						return 132;
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
		/// can print info on drink
		/// </summary>
		/// <returns>drink size then drink name</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Arentino Apple Juice";
		}
	}
}
