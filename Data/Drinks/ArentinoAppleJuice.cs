/*
 * Author: Coby Walsh
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Apple juice in order
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
	public class ArentinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged, IDrinkItem {
		/// <summary>
		/// holds size of the drink
		/// </summary>
		private Size size = Size.Small;
		public override Size Size {
			get { return this.size; }
			set {
				if (size != value) {
					size = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
				}
			}
		}

		/// <summary>
		/// holds whether or not the drink should have ice
		/// </summary>
		private bool ice = false;
		public bool Ice {
			get { return this.ice; }
			set {
				if (value != ice) {
					if (value) {
						ice = true;
						specialInstructions.Add("Add ice");
					}
					else {
						ice = false;
						specialInstructions.Remove("Add ice");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds the price of the drink based on size
		/// </summary>
		public override double Price {
			get {
				switch (size) {
					case Size.Small:
						return .62;
					case Size.Medium:
						return .87;
					case Size.Large:
						return 1.01;
					default:
						throw new NotImplementedException("Size has not been implemented");
				}
			}
		}

		/// <summary>
		/// holds the amount of calories based on size of drink
		/// </summary>
		public override uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 44;
					case Size.Medium:
						return 88;
					case Size.Large:
						return 132;
					default:
						throw new NotImplementedException("Size has not been implemented");
				}
			}
		}

		/// <summary>
		/// holds any special instructions for making the drink
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
		/// can print info on drink
		/// </summary>
		/// <returns>drink size then drink name</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Arentino Apple Juice";
		}
	}
}
