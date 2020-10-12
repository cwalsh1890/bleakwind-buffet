using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Drink {
	/// <summary>
	/// Interaction logic for SailorSodaModifiers.xaml
	/// </summary>
	public partial class SailorSodaModifiers : UserControl {
		public SailorSodaModifiers() {
			InitializeComponent();
		}

		void SizeClick(object sender, RoutedEventArgs e) {
			if (sender is Button button) {
				if (this.DataContext is ISizeable data) {
					switch (button.Name) {
						case "smallButton":
						data.Size = BleakwindBuffet.Data.Enums.Size.Small;
						break;
						case "mediumButton":
						data.Size = BleakwindBuffet.Data.Enums.Size.Medium;
						break;
						case "largeButton":
						data.Size = BleakwindBuffet.Data.Enums.Size.Large;
						break;
					}
				}
			}
		}

		void FlavorClick(object sender, RoutedEventArgs e) {
			if (sender is Button button) {
				if (this.DataContext is SailorSoda data) {
					switch (button.Name) {
						case "Blackberry":
							data.Flavor = SodaFlavor.Blackberry;
							break;
						case "Cherry":
							data.Flavor = SodaFlavor.Cherry;
							break;
						case "Grapefruit":
							data.Flavor = SodaFlavor.Grapefruit;
							break;
						case "Lemon":
							data.Flavor = SodaFlavor.Lemon;
							break;
						case "Peach":
							data.Flavor = SodaFlavor.Peach;
							break;
						case "Watermelon":
							data.Flavor = SodaFlavor.Watermelon;
							break;
					}
				}
			}
		}
	}
}
