/*
 * Author: Coby Walsh
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent thalmor burger
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
	public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged, IEntreeItem {
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if (value != pickle) {
					if (value) {
						pickle = true;
						specialInstructions.Remove("Hold pickle");
					}
					else {
						pickle = false;
						specialInstructions.Add("Hold pickle");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds whether or not the burger should have bacon
		/// </summary>
		private bool bacon = true;
		public bool Bacon {
			get { return this.bacon; }
			set {
				if (value != bacon) {
					if (value) {
						bacon = true;
						specialInstructions.Remove("Hold bacon");
					}
					else {
						bacon = false;
						specialInstructions.Add("Hold bacon");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds whether or not the burger should have egg
		/// </summary>
		private bool egg = true;
		public bool Egg {
			get { return this.egg; }
			set {
				if (value != egg) {
					if (value) {
						egg = true;
						specialInstructions.Remove("Hold egg");
					}
					else {
						egg = false;
						specialInstructions.Add("Hold egg");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds the price of the burger
		/// </summary>
		public override double Price { get; } = 8.32;

		/// <summary>
		/// holds the calories of the burger
		/// </summary>
		public override uint Calories { get; } = 943;

		/// <summary>
		/// holds any special instructions for the burger
		/// </summary>
		private List<string> specialInstructions = new List<string>();

		/// <summary>
		/// event to signal when property has been changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// holds any special instructions for the burger
		/// </summary>
		public override List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns item name as string
		/// </summary>
		/// <returns>item name</returns>
		public override string ToString() {
			return "Thalmor Triple";
		}
	}
}
