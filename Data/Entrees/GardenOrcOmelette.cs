/*
 * Author: Coby Walsh
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent omelette
 */

using System.Collections.Generic;


namespace BleakwindBuffet.Data.Entrees
{
	class GardenOrcOmelette
	{
		/// <summary>
		/// holds whether or not the omelette should have broccoli
		/// </summary>
		private bool broccoli = true;
		public bool Broccoli {
			get { return this.broccoli; }
			set {
				if (value) {
					broccoli = true;
					specialInstructions.Remove("Hold broccoli");
				}
				else {
					broccoli = false;
					specialInstructions.Add("Hold broccoli");
				}
			}
		}

		/// <summary>
		/// holds whether or not the omelette should have mushrooms
		/// </summary>
		private bool mushrooms = true;
		public bool Mushrooms {
			get { return this.mushrooms; }
			set {
				if (value) {
					mushrooms = true;
					specialInstructions.Remove("Hold mushrooms");
				}
				else {
					mushrooms = false;
					specialInstructions.Add("Hold mushrooms");
				}
			}
		}

		/// <summary>
		/// holds whether or not the omelette should have tomato
		/// </summary>
		private bool tomato = true;
		public bool Tomato {
			get { return this.tomato; }
			set {
				if (value) {
					tomato = true;
					specialInstructions.Remove("Hold tomato");
				}
				else {
					tomato = false;
					specialInstructions.Add("Hold tomato");
				}
			}
		}

		/// <summary>
		/// hoodsl the price of the omelette
		/// </summary>
		public double price { get; } = 4.57;

		/// <summary>
		/// holds the calories of the omelette
		/// </summary>
		public uint calories { get; } = 404;

		/// <summary>
		/// holds any special instructions for the omelette
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns string of item name
		/// </summary>
		/// <returns>item name</returns>
		public override string ToString() {
			return "Garden Orc Omelette";
		}
	}
}
