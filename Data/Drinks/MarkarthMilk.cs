﻿/*
 * Author: Coby Walsh
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Milk in order
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace Data.Drinks {
	class MarkarthMilk {
		
		/// <summary>
		/// holds the size of the drink
		/// </summary>
		private Size size = Size.Small;
		public Size Size {
			get { return this.size; }
			set {
				size = value;
			}
		}

		/// <summary>
		/// holds whether the drink should have ice
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
		/// holds the price for the different sizes of drinks
		/// </summary>
		public double Price {
			get {
				switch (size) {
					case Size.Small:
						return 1.05;
					case Size.Medium:
						return 1.11;
					case Size.Large:
						return 1.22;
				}
				return 0;
			}
		}

		/// <summary>
		/// holds the amount of calories for the different sizes of drinks
		/// </summary>
		public uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 56;
					case Size.Medium:
						return 72;
					case Size.Large:
						return 93;
				}
				return 0;
			}
		}

		/// <summary>
		/// holds any specific instructions for the different drinks
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// string of info
		/// </summary>
		/// <returns>drink size then drink name</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Markarth Milk";
		}
	}
}