/*
 * Author: Coby Walsh
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent draugr burger
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
	public class DoubleDraugr
	{
		/// <summary>
		/// holds whether or not the burger should have a bun
		/// </summary>
		private bool bun = true;
		public bool Bun {
			get { return this.bun; }
			set {
				if (value != bun) {
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
		}

		/// <summary>
		/// holds whether or not the burger should have ketchup
		/// </summary>
		private bool ketchup = true;
		public bool Ketchup {
			get { return this.ketchup; }
			set {
				if (value != ketchup) {
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
		}
		
		/// <summary>
		/// holds whether or not the burger should have mustard
		/// </summary>
		private bool mustard = true;
		public bool Mustard {
			get { return this.mustard; }
			set {
				if (value != mustard) {
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
		}

		/// <summary>
		/// holds whether or not the burger should have pickles
		/// </summary>
		private bool pickle = true;
		public bool Pickle {
			get { return this.pickle; }
			set {
				if (value != pickle) {
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
		}

		/// <summary>
		/// holds whether or not the burger should have cheese
		/// </summary>
		private bool cheese = true;
		public bool Cheese {
			get { return this.cheese; }
			set {
				if (value != cheese) {
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
		}

		/// <summary>
		/// holds whether or not the burger should have tomato
		/// </summary>
		private bool tomato = true;
		public bool Tomato {
			get { return this.tomato; }
			set {
				if (value != tomato) {
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
		}

		/// <summary>
		/// holds whether or not the burger should have lettuce
		/// </summary>
		private bool lettuce = true;
		public bool Lettuce {
			get { return this.lettuce; }
			set {
				if (value != lettuce) {
					if (value) {
						lettuce = true;
						specialInstructions.Remove("Hold lettuce");
					}
					else {
						lettuce = false;
						specialInstructions.Add("Hold lettuce");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the burger should have mayo
		/// </summary>
		private bool mayo = true;
		public bool Mayo {
			get { return this.mayo; }
			set {
				if (value != mayo) {
					if (value) {
						mayo = true;
						specialInstructions.Remove("Hold mayo");
					}
					else {
						mayo = false;
						specialInstructions.Add("Hold mayo");
					}
				}
			}
		}

		/// <summary>
		/// holds the price of the burger
		/// </summary>
		public double Price { get; } = 7.32;

		/// <summary>
		/// holds the calories of the burger
		/// </summary>
		public uint Calories { get; } = 843;

		/// <summary>
		/// holds any special instructions for making the burger
		/// </summary>
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns sting of burger name
		/// </summary>
		/// <returns>burger name</returns>
		public override string ToString() {
			return "Double Draugr";
		}
	}
}
