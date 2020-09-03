/*
 * Author: Coby Walsh
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent t-bone steak
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
	class ThugsTBone {
		/// <summary>
		/// holds the price of the steak
		/// </summary>
		public double price { get; } = 6.44;

		/// <summary>
		/// holds the calories of the steak-
		/// </summary>
		public uint calories { get; } = 982;

		/// <summary>
		/// holds any special instructions for the steak
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns item name as string
		/// </summary>
		/// <returns>item name</returns>
		public override string ToString() {
			return "Thugs T-Bone";
		}
	}
}
