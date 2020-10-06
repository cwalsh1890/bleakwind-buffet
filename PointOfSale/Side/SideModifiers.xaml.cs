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

namespace PointOfSale.Side {
	/// <summary>
	/// Interaction logic for SideModifiers.xaml
	/// </summary>
	public partial class SideModifiers : UserControl {
		public SideModifiers() {
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
	}
}
