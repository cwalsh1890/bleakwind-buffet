using BleakwindBuffet.Data;
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

namespace PointOfSale {
	/// <summary>
	/// Interaction logic for RuningTotal.xaml
	/// </summary>
	public partial class RuningTotal : UserControl {
		public RuningTotal() {
			InitializeComponent();
			this.DataContext = new Order();
		}

		/// <summary>
		/// adds itme to list of total items
		/// </summary>
		/// <param name="item">item to add</param>
		public void AddElement(IOrderItem item) {
			if (this.DataContext is Order order) { 
				order.Add(item);
			}
		}

		public void RemoveElement(IOrderItem item) {
			if (this.DataContext is Order order) {
				order.Remove(item);
			}
		}
	}
}
