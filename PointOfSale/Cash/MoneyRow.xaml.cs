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

namespace PointOfSale.Cash {
	/// <summary>
	/// Interaction logic for MoneyRow.xaml
	/// </summary>
	public partial class MoneyRow : UserControl {
		public MoneyRow() {
			InitializeComponent();
		}

		void IncrementClick(object sender, RoutedEventArgs e) {
			if (DataContext is MoneyCount money) {
				money.Payment++;
			}
		}

		void DecrementClick(object sender, RoutedEventArgs e) {
			if (DataContext is MoneyCount money) {
				if (money.Payment > 0)
					money.Payment--;
			}
		}
	}
}
