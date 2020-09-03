/*
 * Author: Coby Walsh
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent philly cheese steak
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
	class PhillyPoacher
	{
		/// <summary>
		/// holds whether or not the sandwich should have steak
		/// </summary>
		private bool sirloin = true;
		public bool Sirloin {
			get { return this.sirloin; }
			set {
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

		/// <summary>
		/// holds whether or not the sandwich should have onion
		/// </summary>
		private bool onion = true;
		public bool Onion {
			get { return this.onion; }
			set {
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

		/// <summary>
		/// holds whether or not the sandwich should have a roll
		/// </summary>
		private bool roll = true;
		public bool Roll {
			get { return this.roll; }
			set {
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

		/// <summary>
		/// holds the price of the sandwich
		/// </summary>
		public double price { get; } = 7.23;

		/// <summary>
		/// holds the calories of the sandwich
		/// </summary>
		public uint calories { get; } = 784;

		/// <summary>
		/// holds any special instructions for the sandwich
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
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
