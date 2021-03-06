﻿using System;
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

namespace PointOfSale.Drink {
	/// <summary>
	/// Interaction logic for DrinkOption.xaml
	/// </summary>
	public partial class DrinkOption : UserControl {
		public DrinkOption() {
			InitializeComponent();
		}

		void SelectCoffeeClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.CoffeeSelected();
		}

		void MilkClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.MilkSelected();
		}

		void AppleJuiceClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.AppleJuiceSelected();
		}

		void WaterClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.WaterSelected();
		}

		void SodaClick(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
			mainWindow.SodaSelected();
		}
	}
}
