/*
 * Author: Coby Walsh
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Coffee in order
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
	public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged, IDrinkItem {
		/// <summary>
		/// holds the size of the coffee
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
		/// holds whether or not the coffee should be decaf
		/// </summary>
		private bool decaf = false;
		public bool Decaf {
			get { return this.decaf; }
			set {
				if (value != decaf) {
					decaf = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
				}
			}
		}

		/// <summary>
		/// holds whether or not the drink should have cream
		/// </summary>
		private bool roomForCream = false;
		public bool RoomForCream {
			get { return this.roomForCream; }
			set {
				if (value != roomForCream) {
					if (value) {
						roomForCream = true;
						specialInstructions.Add("Add cream");
					}
					else {
						roomForCream = false;
						specialInstructions.Remove("Add cream");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cream"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds the price for the different sizes of drink
		/// </summary>
		public override double Price {
			get {
				switch (size) {
					case Size.Small:
						return .75;
					case Size.Medium:
						return 1.25;
					case Size.Large:
						return 1.75;
				}
				throw new NotImplementedException("Size has not been implemented");
			}
		}

		/// <summary>
		/// holds the amount of calories for a specific drink
		/// </summary>
		public override uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 7;
					case Size.Medium:
						return 10;
					case Size.Large:
						return 20;
				}
				throw new NotImplementedException("Size has not been implemented");
			}
		}

		/// <summary>
		/// holds a description for the food item
		/// </summary>
		public string Description
		{
			get
			{
				return "Fair trade, fresh ground dark roast coffee.";
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
		/// returns string of drink info
		/// </summary>
		/// <returns>drink size then if its decaf then drink name</returns>
		public override string ToString() {
			if (decaf) {
				return $"{Enum.GetName(typeof(Size), size)} Decaf Candlehearth Coffee";
			}
			else {
				return $"{Enum.GetName(typeof(Size), size)} Candlehearth Coffee";
			}
		}
	}
}
