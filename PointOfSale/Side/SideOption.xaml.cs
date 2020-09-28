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

namespace PointOfSale.Side {
	/// <summary>
	/// Interaction logic for SideOption.xaml
	/// </summary>
	public partial class SideOption : UserControl {
		public SideOption() {
			InitializeComponent();
		}

		void SelectWaffleFries(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.WaffleFriesSelected();
		}

		void SelectFriedMiraak(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.FriedMiraakSelected();
		}

		void SelectMadOtarGrits(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.OtarGritsSelected();
		}

		void SelectVokunSalad(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.SaladSelected();
		}
	}
}
