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

namespace PointOfSale {
	/// <summary>
	/// Interaction logic for PaymentOptions.xaml
	/// </summary>
	public partial class PaymentOptions : UserControl {
		MainWindow mainWindow;
		public PaymentOptions(MainWindow mw) {
			InitializeComponent();
			mainWindow = mw;
		}

		void OnCashClick(object sender, RoutedEventArgs e) {
			mainWindow.PayWithCash();
		}

		void OnCreditClick(object sender, RoutedEventArgs e) {
			mainWindow.PayWithCard();
		}
	}
}
