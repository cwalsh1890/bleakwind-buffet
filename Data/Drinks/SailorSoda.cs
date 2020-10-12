/*
 * Author: Coby Walsh
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent soda in order
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Menu;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
	public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged, IDrinkItem {
		/// <summary>
		/// holds the size of the drink
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
		/// holds the flavor of the soda
		/// </summary>
		private SodaFlavor flavor = SodaFlavor.Cherry;
		public SodaFlavor Flavor {
			get { return this.flavor; }
			set {
				if (flavor != value) {
					flavor = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
				}
			}
		}

		/// <summary>
		/// holds if the drink should have ice
		/// </summary
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds the prices for the different sizes of drinks
		/// </summary>
		public override double Price {
			get {
				switch (size) {
					case Size.Small:
						return 1.42;
					case Size.Medium:
						return 1.74;
					case Size.Large:
						return 2.07;
				}
				throw new NotImplementedException("Size has not been implemented");
			}
		}

		/// <summary>
		/// holds the amount of calories for the different sizes
		/// </summary>
		public override uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 117;
					case Size.Medium:
						return 153;
					case Size.Large:
						return 205;
				}
				throw new NotImplementedException("Size has not been implemented");
			}
		}

		/// <summary>
		/// holds any special instructions for the drink
		/// </summary>
		private List<string> specialInstructions = new List<string>();

		/// <summary>
		/// event to signal when a property has been changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		public override List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// string of information of drink
		/// </summary>
		/// <returns>size then drink</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} {Enum.GetName(typeof(SodaFlavor), flavor)} Sailor Soda";
		}
	}
}
