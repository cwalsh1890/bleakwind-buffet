using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.OrderTests {
	public class OrderTests {
		[Fact]
		public void OrderImplementCorrectInterfaces() {
			Order order = new Order();
			Assert.IsAssignableFrom<ICollection>(order);
			Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
			Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
		}
		
		[Fact] 
		public void AddingItemToOrderNotifications() {
			Order order = new Order();
			order.CollectionChanged += OnCollectionChange;

			void OnCollectionChange(object sender, NotifyCollectionChangedEventArgs e) {
				Assert.Equal(NotifyCollectionChangedAction.Add, e.Action);
			}

			Assert.PropertyChanged(order, "Subtotal", () => {
				order.Add(new CustomItem(0, 0, new List<string>()));
			});

			Assert.PropertyChanged(order, "Tax", () => {
				order.Add(new CustomItem(0, 0, new List<string>()));
			});

			Assert.PropertyChanged(order, "Total", () => {
				order.Add(new CustomItem(0, 0, new List<string>()));
			});

			Assert.PropertyChanged(order, "Calories", () => {
				order.Add(new CustomItem(0, 0, new List<string>()));
			});
		}

		[Fact]
		public void RemovingItemToOrderNotifications() {
			Order order = new Order();
			CustomItem item1 = new CustomItem(0, 0, new List<string>());
			CustomItem item2 = new CustomItem(0, 0, new List<string>());
			CustomItem item3 = new CustomItem(0, 0, new List<string>());
			CustomItem item4 = new CustomItem(0, 0, new List<string>());
			
			order.CollectionChanged += OnCollectionChange;

			void OnCollectionChange(object sender, NotifyCollectionChangedEventArgs e) {
				Assert.Equal(NotifyCollectionChangedAction.Remove, e.Action);
			}

			Assert.PropertyChanged(order, "Subtotal", () => {
				order.Remove(item1);
			});

			Assert.PropertyChanged(order, "Tax", () => {
				order.Remove(item2);
			});

			Assert.PropertyChanged(order, "Total", () => {
				order.Remove(item3);
			});

			Assert.PropertyChanged(order, "Calories", () => {
				order.Remove(item4);
			});
		}

		[Fact]
		public void ShouldNotifyPropertyChangedWhenItemChanged() {
			Order order = new Order();
			CustomItem item = new CustomItem(0, 0, new List<string>());
			order.Add(item);

			Assert.PropertyChanged(order, "Subtotal", () => {
				item.Price = 1;
			});

			Assert.PropertyChanged(order, "Tax", () => {
				item.Price = 2;
			});

			Assert.PropertyChanged(order, "Total", () => {
				item.Price = 3;
			});

			Assert.PropertyChanged(order, "Calories", () => {
				item.Calories = 1;
			});
		}

		protected class CustomItem : INotifyPropertyChanged, IOrderItem {
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
