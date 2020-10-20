using System;
using System.Collections.Generic;
using System.Reflection;
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

namespace PointOfSale.Cash {
	/// <summary>
	/// Interaction logic for CashPayment.xaml
	/// </summary>
	public partial class CashPayment : UserControl {
		Register register;
		MainWindow mainWindow;
		public CashPayment(double total, MainWindow mw) {
			InitializeComponent();

			mainWindow = mw;

			register = new Register(total);
			DataContext = register;

			hundreds.DataContext = register.Hundreds;
			fifties.DataContext = register.Fifties;
			twenties.DataContext = register.Twenties;
			tens.DataContext = register.Tens;
			fives.DataContext = register.Fives;
			twos.DataContext = register.Twos;
			ones.DataContext = register.Ones;
			dollars.DataContext = register.Dollars;
			halfDollars.DataContext = register.HalfDollars;
			quarters.DataContext = register.Quarters;
			dimes.DataContext = register.Dimes;
			nickels.DataContext = register.Nickels;
			pennies.DataContext = register.Pennies;
		}

		void ReturnToOrder(object sender, RoutedEventArgs e) {
			mainWindow.ReturnToOrder();
		}

		void FinalizeSale(object sender, RoutedEventArgs e) {
			if (register.CountCustomerPayment() > register.AmountDue)
				mainWindow.FinalizeCashSale(register);
		}
	}
}
