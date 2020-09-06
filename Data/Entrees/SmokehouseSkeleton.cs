/*
 * Author: Coby Walsh
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent breakfast combo
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
	public class SmokehouseSkeleton
	{
		/// <summary>
		/// holds whether or not the plate should have sausage links
		/// </summary>
		private bool sausageLink = true;
		public bool SausageLink {
			get { return this.sausageLink; }
			set {
				if (value != sausageLink) {
					if (value) {
						sausageLink = true;
						specialInstructions.Remove("Hold sausage");
					}
					else {
						sausageLink = false;
						specialInstructions.Add("Hold sausage");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the plate should have eggs
		/// </summary>
		private bool egg = true;
		public bool Egg {
			get { return this.egg; }
			set {
				if (value != egg) {
					if (value) {
						egg = true;
						specialInstructions.Remove("Hold eggs");
					}
					else {
						egg = false;
						specialInstructions.Add("Hold eggs");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the plate should have hash browns
		/// </summary>
		private bool hashBrowns = true;
		public bool HashBrowns {
			get { return this.hashBrowns; }
			set {
				if (value != hashBrowns) {
					if (value) {
						hashBrowns = true;
						specialInstructions.Remove("Hold hash browns");
					}
					else {
						hashBrowns = false;
						specialInstructions.Add("Hold hash browns");
					}
				}
			}
		}

		/// <summary>
		/// holds whether or not the plate should have pancake
		/// </summary>
		private bool pancake = true;
		public bool Pancake {
			get { return this.pancake; }
			set {
				if (value != pancake) {
					if (value) {
						pancake = true;
						specialInstructions.Remove("Hold pancakes");
					}
					else {
						pancake = false;
						specialInstructions.Add("Hold pancakes");
					}
				}
			}
		}

		/// <summary>
		/// holds price for the plate
		/// </summary>
		public double Price { get; } = 5.62;

		/// <summary>
		/// holds calories for the plate
		/// </summary>
		public uint Calories { get; } = 602;

		/// <summary>
		/// holds any special instructions for the plate
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
			return "Smokehouse Skeleton";
		}
	}
}
