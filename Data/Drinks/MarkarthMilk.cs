/*
 * Author: Coby Walsh
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Milk in order
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks {
	public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged, IDrinkItem {
		
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
		/// holds whether the drink should have ice
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
		/// holds the price for the different sizes of drinks
		/// </summary>
		public override double Price {
			get {
				switch (size) {
					case Size.Small:
						return 1.05;
					case Size.Medium:
						return 1.11;
					case Size.Large:
						return 1.22;
				}
				throw new NotImplementedException("Size has not been implemented");
			}
		}

		/// <summary>
		/// holds the amount of calories for the different sizes of drinks
		/// </summary>
		public override uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 56;
					case Size.Medium:
						return 72;
					case Size.Large:
						return 93;
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
				return "Hormone-free organic 2% milk.";
			}
		}

		/// <summary>
		/// holds any specific instructions for the different drinks
		/// </summary>
		private List<string> specialInstructions = new List<string>();

		/// <summary>
		/// event to signal a property has been changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		public override List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// string of info
		/// </summary>
		/// <returns>drink size then drink name</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Markarth Milk";
		}
	}
}
