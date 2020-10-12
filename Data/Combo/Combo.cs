using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data.Combo {
	public class Combo : IOrderItem, INotifyPropertyChanged {
		private IDrinkItem drink;
		/// <summary>
		/// drink item that makes up the combo
		/// </summary>
		public IDrinkItem Drink{
			get { return drink; }
			set {
				if (drink != null) {
					if (drink.ToString() != value.ToString()) {
						if (drink != null) {
							drink.PropertyChanged -= PropertyListener;
						}
						drink = value;
						drink.PropertyChanged += PropertyListener;
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
						UpdateSpecialInstructions();
					}
				}
				else {
					drink = value;
					drink.PropertyChanged += PropertyListener;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					UpdateSpecialInstructions();
				}
			}
		}

		private IEntreeItem entree;
		/// <summary>
		/// entree item that makes up the combo
		/// </summary>
		public IEntreeItem Entree {
			get { return entree; }
			set {
				if (entree != null) {
					if (entree.ToString() != value.ToString()) {
						if (entree != null) {
							entree.PropertyChanged -= PropertyListener;
						}
						entree = value;
						entree.PropertyChanged += PropertyListener;
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
						UpdateSpecialInstructions();
					}
				}
				else {
					entree = value;
					entree.PropertyChanged += PropertyListener;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					UpdateSpecialInstructions();
				}
			}
		}

		private ISideItem side;
		/// <summary>
		/// side item that makes up the combo
		/// </summary>
		public ISideItem Side {
			get { return side; }
			set {
				if (side != null) {
					if (side.ToString() != value.ToString()) {
						if (side != null) {
							side.PropertyChanged -= PropertyListener;
						}
						side = value;
						side.PropertyChanged += PropertyListener;
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
						UpdateSpecialInstructions();
					}
				}
				else {
					side = value;
					side.PropertyChanged += PropertyListener;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					UpdateSpecialInstructions();
				}
			}
		}

		/// <summary>
		/// price of the combo
		/// </summary>
		public double Price {
			get {
				double drinkPrice = drink != null ? drink.Price : 0;
				double entreePrice = entree != null ? entree.Price : 0;
				double sidePrice = side != null ? side.Price : 0;
				return Math.Round((drinkPrice + entreePrice + sidePrice - 1), 2);
			}
		}

		/// <summary>
		/// total calories of the combo
		/// </summary>
		public uint Calories {
			get {
				uint drinkCalories = drink != null ? drink.Calories : 0;
				uint entreeCalories = entree != null ? entree.Calories : 0;
				uint sideCalories = side != null ? side.Calories : 0;
				return drinkCalories + entreeCalories + sideCalories;
			}
		}

		/// <summary>
		/// any special instructions for making the combo
		/// </summary>
		public List<string> specialInstructions;
		public List<string> SpecialInstructions {
			get {
				return specialInstructions;
			}
		}

		/// <summary>
		/// signals when properties are changed for the combo
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		private void UpdateSpecialInstructions() {
			specialInstructions = new List<string>();

			if (entree != null) {
				specialInstructions.Add(entree.ToString());
				foreach (string s in entree.SpecialInstructions) {
					specialInstructions.Add("-" + s);
				}
			}

			if (side != null) {
				specialInstructions.Add(side.ToString());
				foreach (string s in side.SpecialInstructions) {
					specialInstructions.Add("-" + s);
				}
			}

			if (drink != null) {
				specialInstructions.Add(drink.ToString());
				foreach (string s in drink.SpecialInstructions) {
					specialInstructions.Add("-" + s);
				}
			}
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
		}

		void PropertyListener(object sender, PropertyChangedEventArgs e) {
			if (e.PropertyName == "SpecialInstructions") {
				UpdateSpecialInstructions();
			}
			if (e.PropertyName == "Price") {
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
			}
			if (e.PropertyName == "Calories") {
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
			}
		}

		public override string ToString() {
			return "Combo";
		}
	}
}
