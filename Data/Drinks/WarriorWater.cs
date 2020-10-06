/*
 * Author: Coby Walsh
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Water in order
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
	public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged {
		/// <summary>
		/// holds the size of the drink
		/// </summary>
		private Size size = Size.Small;
		public override Size Size {
			get { return this.size; }
			set {
				if (size != value) {
					size = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("size"));
				}
			}
		}

		/// <summary>
		/// holds if the drink should have ice
		/// </summary>
		private bool ice = true;
		public bool Ice {
			get { return this.ice; }
			set {
				if (value != ice) {
					if (value) {
						ice = true;
						specialInstructions.Remove("Hold ice");
					}
					else {
						ice = false;
						specialInstructions.Add("Hold ice");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ice"));
				}
			}
		}

		/// <summary>
		/// holds if the drink should have a lemon
		/// </summary>
		private bool lemon = false;
		public bool Lemon {
			get { return this.lemon; }
			set {
				if (value != lemon) {
					if (value) {
						lemon = true;
						specialInstructions.Add("Add lemon");
					}
					else {
						lemon = false;
						specialInstructions.Remove("Add lemon");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("lemon"));
				}
			}
		}

		/// <summary>
		/// holds the price of the drink
		/// </summary>
		public override double Price {
			get {
				return 0;
			}
		}

		/// <summary>
		/// holds the calories of the drink
		/// </summary>
		public override uint Calories {
			get {
				return 0;
			}
		}

		/// <summary>
		/// list of special instructions to be returned 
		/// </summary>
		private List<string> specialInstructions = new List<string>();

		/// <summary>
		/// event to signal that a property has been changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		public override List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// two string method that prints size and drink
		/// </summary>
		/// <returns></returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Warrior Water";
		}
	}
}
