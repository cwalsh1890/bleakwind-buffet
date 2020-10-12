/*
 * Author: Coby Walsh
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent briar burger
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.Data.Entrees
{
	public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged, IEntreeItem {
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
		///	holds whether or not the burger should have cheese
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
		/// holds the price of the burger
		/// </summary>
		public override double Price { get; } = 6.32;

		/// <summary>
		/// holds the calories of the burger
		/// </summary>
		public override uint Calories { get; } = 743;

		/// <summary>
		/// event when an item element gets updated
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// holds any special instructions for the burger
		/// </summary>
		private List<string> specialInstructions = new List<string>();

		public override List<string> SpecialInstructions {
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
