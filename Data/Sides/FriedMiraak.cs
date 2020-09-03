/*
 * Author: Coby Walsh
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a hash brown pancake
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Sides {
	class FriedMiraak {
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
						return 1.78;
					case Size.Medium:
						return 2.01;
					case Size.Large:
						return 2.88;
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
						return 151;
					case Size.Medium:
						return 236;
					case Size.Large:
						return 306;
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
			return $"{Enum.GetName(typeof(Size), size)} Fried Miraak";
		}
	}
}
