﻿/*
 * Author: Coby Walsh
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent omelette
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Menu;


namespace BleakwindBuffet.Data.Entrees
{
	public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged, IEntreeItem {
		/// <summary>
		/// holds whether or not the omelette should have broccoli
		/// </summary>
		private bool broccoli = true;
		public bool Broccoli {
			get { return this.broccoli; }
			set {
				if (value != broccoli) {
					if (value) {
						broccoli = true;
						specialInstructions.Remove("Hold broccoli");
					}
					else {
						broccoli = false;
						specialInstructions.Add("Hold broccoli");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds whether or not the omelette should have mushrooms
		/// </summary>
		private bool mushrooms = true;
		public bool Mushrooms {
			get { return this.mushrooms; }
			set {
				if (value != mushrooms) {
					if (value) {
						mushrooms = true;
						specialInstructions.Remove("Hold mushrooms");
					}
					else {
						mushrooms = false;
						specialInstructions.Add("Hold mushrooms");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// holds whether or not the omelette should have tomato
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
		/// holds whether or not the omelette should have tomato
		/// </summary>
		private bool cheddar = true;
		public bool Cheddar {
			get { return this.cheddar; }
			set {
				if (value != cheddar) {
					if (value) {
						cheddar = true;
						specialInstructions.Remove("Hold cheddar");
					}
					else {
						cheddar = false;
						specialInstructions.Add("Hold cheddar");
					}
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// hoodsl the price of the omelette
		/// </summary>
		public override double Price { get; } = 4.57;

		/// <summary>
		/// holds the calories of the omelette
		/// </summary>
		public override uint Calories { get; } = 404;

		/// <summary>
		/// holds a description for the food item
		/// </summary>
		public string Description
		{
			get
			{
				return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
			}
		}

		/// <summary>
		/// holds any special instructions for the omelette
		/// </summary>
		private List<string> specialInstructions = new List<string>();

		/// <summary>
		/// flags when property has been changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		public override List<string> SpecialInstructions {
			get { return new List<string>(specialInstructions); }
		}

		/// <summary>
		/// returns string of item name
		/// </summary>
		/// <returns>item name</returns>
		public override string ToString() {
			return "Garden Orc Omelette";
		}
	}
}
