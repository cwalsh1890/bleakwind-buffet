using BleakwindBuffet.Data.Combo;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.OrderTests {
	public class ComboTests {
		[Fact]
		public void ComboImplementsIOrderItem() {
			Combo combo = new Combo();
			Assert.IsAssignableFrom<IOrderItem>(combo);
		}

		[Theory]
		[InlineData(1, 2, 3, 5)]
		[InlineData(.5, 1.5, 3.75, 4.75)]
		[InlineData(4.5, 2.3, 3.2, 9)]
		public void HasRightPrice(double entreePrice, double drinkPrice, double sidePrice, double correctPrice) {
			CustomItem entree = new CustomItem(entreePrice, 0, new List<string>());
			CustomItem drink = new CustomItem(drinkPrice, 0, new List<string>());
			CustomItem side = new CustomItem(sidePrice, 0, new List<string>());

			Combo combo = new Combo();
			combo.Entree = (IEntreeItem) entree;
			combo.Drink = (IDrinkItem) drink;
			combo.Side = (ISideItem) side;
			Assert.Equal(correctPrice, combo.Price);
		}

		[Fact]
		public void NotifiesWhenPricePropertyChanged() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			combo.Entree = (IEntreeItem) entree;
			combo.Drink = (IDrinkItem) drink;
			combo.Side = (ISideItem) side;

			Assert.PropertyChanged(combo, "Price", () => {
				entree.Price = 1;
			});

			Assert.PropertyChanged(combo, "Price", () => {
				side.Price = 1;
			});

			Assert.PropertyChanged(combo, "Price", () => {
				drink.Price = 1;
			});
		}

		[Fact]
		public void NotifiesWhenCaloriesPropertyChanged() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			combo.Entree = (IEntreeItem) entree;
			combo.Drink = (IDrinkItem) drink;
			combo.Side = (ISideItem) side;

			Assert.PropertyChanged(combo, "Calories", () => {
				entree.Calories = 1;
			});

			Assert.PropertyChanged(combo, "Calories", () => {
				side.Calories = 1;
			});

			Assert.PropertyChanged(combo, "Calories", () => {
				drink.Calories = 1;
			});
		}

		[Fact]
		public void NotifiesWhenSpecialInstructionsPropertyChanged() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			combo.Entree = (IEntreeItem) entree;
			combo.Drink = (IDrinkItem) drink;
			combo.Side = (ISideItem) side;

			Assert.PropertyChanged(combo, "SpecialInstructions", () => {
				entree.SpecialInstructions = new List<string>();
			});

			Assert.PropertyChanged(combo, "SpecialInstructions", () => {
				side.SpecialInstructions = new List<string>();
			});

			Assert.PropertyChanged(combo, "SpecialInstructions", () => {
				drink.SpecialInstructions = new List<string>();
			});
		}

		[Fact]
		public void NotifiesPricePropertyChangedWhenItemsAreAdded() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			Assert.PropertyChanged(combo, "Price", () => {
				combo.Entree = (IEntreeItem) entree;
			});

			Assert.PropertyChanged(combo, "Price", () => {
				combo.Drink = (IDrinkItem) drink;
			});

			Assert.PropertyChanged(combo, "Price", () => {
				combo.Side = (ISideItem) side;
			});
		}

		[Fact]
		public void NotifiesCaloriesPropertyChangedWhenItemsAreAdded() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			Assert.PropertyChanged(combo, "Calories", () => {
				combo.Entree = (IEntreeItem) entree;
			});

			Assert.PropertyChanged(combo, "Calories", () => {
				combo.Drink = (IDrinkItem) drink;
			});

			Assert.PropertyChanged(combo, "Calories", () => {
				combo.Side = (ISideItem) side;
			});
		}

		[Fact]
		public void NotifiesSpecialInstructionsPropertyChangedWhenItemsAreAdded() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			Assert.PropertyChanged(combo, "SpecialInstructions", () => {
				combo.Entree = (IEntreeItem) entree;
			});

			Assert.PropertyChanged(combo, "SpecialInstructions", () => {
				combo.Drink = (IDrinkItem) drink;
			});

			Assert.PropertyChanged(combo, "SpecialInstructions", () => {
				combo.Side = (ISideItem) side;
			});
		}

		[Fact]
		public void NotifiesItemPropertyChangedWhenItemsAreAdded() {
			CustomItem entree = new CustomItem(0, 0, new List<string>());
			CustomItem drink = new CustomItem(0, 0, new List<string>());
			CustomItem side = new CustomItem(0, 0, new List<string>());

			Combo combo = new Combo();
			Assert.PropertyChanged(combo, "Entree", () => {
				combo.Entree = (IEntreeItem) entree;
			});

			Assert.PropertyChanged(combo, "Drink", () => {
				combo.Drink = (IDrinkItem) drink;
			});

			Assert.PropertyChanged(combo, "Side", () => {
				combo.Side = (ISideItem) side;
			});
		}

		protected class CustomItem : INotifyPropertyChanged, IOrderItem, IEntreeItem, IDrinkItem, ISideItem {
			public CustomItem(double price, uint calories, List<string> instructions) {
				this.Price = price;
				this.Calories = calories;
				this.SpecialInstructions = instructions;
			}

			double price;
			public double Price {
				get { return price; } 
				set {
					price = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
				} 
			}

			uint calories;
			public uint Calories {
				get { return calories; }
				set {
					calories = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
				}
			}

			List<string> specialInstructions;
			public List<string> SpecialInstructions { 
				get { return specialInstructions; } 
				set {
					specialInstructions = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				} 
			}

			public event PropertyChangedEventHandler PropertyChanged;
		}
	}
}
