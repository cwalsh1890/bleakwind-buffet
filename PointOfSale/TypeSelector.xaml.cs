using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PointOfSale {
	/// <summary>
	/// Interaction logic for TypeSelector.xaml
	/// </summary>
	public partial class TypeSelector : UserControl {
		MainWindow mainWindow;
		public TypeSelector(MainWindow mw) {
			InitializeComponent();
			mainWindow = mw;
		}

		void SelectEntree(object sender, RoutedEventArgs e) {
			mainWindow.EntreeSelected();
		}

		void SelectSide(object sender, RoutedEventArgs e) {
			mainWindow.SideSelected();
		}

		void SelectDrink(object sender, RoutedEventArgs e) {
			mainWindow.DrinkSelected();
		}
	}
}
