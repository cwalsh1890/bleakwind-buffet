/*
 * Author: Coby Walsh
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent a fruit salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace Data.Sides {
	class VokunSalad {
		/// <summary>
		/// holds the size of the side
		/// </summary>
		private Size size = Size.Small;
		public Size Size {
			get { return this.size; }
			set {
				size = value;
			}
		}

		/// <summary>
		/// holds the price of the side
		/// </summary>
		public double Price {
			get {
				switch (size) {
					case Size.Small:
						return .93;
					case Size.Medium:
						return 1.28;
					case Size.Large:
						return 1.82;
				}
				return 0;
			}
		}

		/// <summary>
		/// holds the amount of calories in the side
		/// </summary>
		public uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 41;
					case Size.Medium:
						return 52;
					case Size.Large:
						return 73;
				}
				return 0;
			}
		}

		/// <summary>
		/// list of special instructions to be returned 
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// string of info on side
		/// </summary>
		/// <returns>size then side name</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Vokun Salad";
		}
	}
}
