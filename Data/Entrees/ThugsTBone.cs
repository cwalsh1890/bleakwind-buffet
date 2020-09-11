/*
 * Author: Coby Walsh
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent t-bone steak
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
	public class ThugsTBone : Entree, IOrderItem {
		/// <summary>
		/// holds the price of the steak
		/// </summary>
		public override double Price { get; } = 6.44;

		/// <summary>
		/// holds the calories of the steak-
		/// </summary>
		public override uint Calories { get; } = 982;

		/// <summary>
		/// holds any special instructions for the steak
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions {
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
