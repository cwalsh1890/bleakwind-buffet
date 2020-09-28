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

namespace PointOfSale.Entree {
	/// <summary>
	/// Interaction logic for EntreeOption.xaml
	/// </summary>
	public partial class EntreeOption : UserControl {
		public EntreeOption() {
			InitializeComponent();
		}

		void BriarHeartBurgerClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.BriarHeartBurgerSelected();
		}

		void DoubleDraugrClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.DoubleDraugrSelected();
		}

		void ThalmorTripleClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.ThalmorTripleSelected();
		}

		void GardenOrcOmeletteClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.GardenOrcOmeletteSelected();
		}

		void PhillyPoacherClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.PhillyPoacherSelected();
		}

		void SmokehouseSkeletonClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.SmokehouseSkeletonSelected();
		}

		void ThugsTBoneClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.ThugsTBoneSelected();
		}
	}
}
