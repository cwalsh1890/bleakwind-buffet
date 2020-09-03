/*
 * Author: Coby Walsh
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent briar burger
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
	class BriarheartBurger {
		/// <summary>
		/// holds whether or not the burger should have a bun
		/// </summary>
		private bool bun = true;
		public bool Bun {
			get { return this.bun; }
			set {
				if (value) {
					bun = true;
					specialInstructions.Remove("Hold bun");
				}
				else {
					bun = false;
					specialInstructions.Add("Hold bun");
				}
			}
		}

		/// <summary>
		/// holds whether or not the burger should have ketchup
		/// </summary>
		private bool ketchup = true;
		public bool Ketchup {
			get { return this.ketchup; }
			set {
				if (value) {
					ketchup = true;
					specialInstructions.Remove("Hold ketchup");
				}
				else {
					ketchup = false;
					specialInstructions.Add("Hold ketchup");
				}
			}
		}

		/// <summary>
		/// holds whether or not the burger should have mustard
		/// </summary>
		private bool mustard = true;
		public bool Mustard {
			get { return this.mustard; }
			set {
				if (value) {
					mustard = true;
					specialInstructions.Remove("Hold mustard");
				}
				else {
					mustard = false;
					specialInstructions.Add("Hold mustard");
				}
			}
		}

		/// <summary>
		/// holds whether or not the burger should have pickle
		/// </summary>
		private bool pickle = true;
		public bool Pickle {
			get { return this.pickle; }
			set {
				if (value) {
					pickle = true;
					specialInstructions.Remove("Hold pickle");
				}
				else {
					pickle = false;
					specialInstructions.Add("Hold pickle");
				}
			}
		}
		
		/// <summary>
		///	holds whether or not the burger should have cheese
		/// </summary>
		private bool cheese = true;
		public bool Cheese {
			get { return this.cheese; }
			set {
				if (value) {
					cheese = true;
					specialInstructions.Remove("Hold cheese");
				}
				else {
					cheese = false;
					specialInstructions.Add("Hold cheese");
				}
			}
		}

		/// <summary>
		/// holds the price of the burger
		/// </summary>
		public double price { get; } = 6.32;

		/// <summary>
		/// holds the calories of the burger
		/// </summary>
		public uint calories { get; } = 743;

		/// <summary>
		/// holds any special instructions for the burger
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// name of burger
		/// </summary>
		/// <returns>name of burger</returns>
		public override string ToString() {
			return "Briarheart Burger";
		}
	}
}
