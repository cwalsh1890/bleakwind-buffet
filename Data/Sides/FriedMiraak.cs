﻿/*
 * Author: Coby Walsh
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent a hash brown pancake
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides {
	public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged, ISideItem {
		/// <summary>
		/// holds the size of the side
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
		/// holds the price of the side
		/// </summary>
		public override double Price {
			get {
				switch (size) {
					case Size.Small:
						return 1.78;
					case Size.Medium:
						return 2.01;
					case Size.Large:
						return 2.88;
				}
				throw new NotImplementedException("Size has not been implemented");
			}
		}

		/// <summary>
		/// holds the amount of calories in the side
		/// </summary>
		public override uint Calories {
			get {
				switch (size) {
					case Size.Small:
						return 151;
					case Size.Medium:
						return 236;
					case Size.Large:
						return 306;
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
				return "Perfectly prepared hash brown pancakes.";
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
		/// string of info on side
		/// </summary>
		/// <returns>size then side name</returns>
		public override string ToString() {
			return $"{Enum.GetName(typeof(Size), size)} Fried Miraak";
		}
	}
}
