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
		List<IOrderItem> OrderItems = new List<IOrderItem>();
		public RuningTotal() {
			InitializeComponent();
			//orderElements.ItemsSource = OrderItems;
		}

		/// <summary>
		/// adds itme to list of total items
		/// </summary>
		/// <param name="item">item to add</param>
		public void AddElement(IOrderItem item) {
			OrderItems.Add(item);
			orderElements.Items.Add(item);
		}
	}
}
