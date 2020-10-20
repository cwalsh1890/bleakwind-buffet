using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PointOfSale.Cash {
	public class MoneyCount : INotifyPropertyChanged {
		public MoneyCount(int inDrawer) {
			Drawer = inDrawer;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public int Drawer { get; }

		private int payment = 0;
		public int Payment {
			get {
				return payment;
			}
			set {
				payment = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Payment"));
			}
		}

		private int change = 0;
		public int Change {
			get {
				return change;
			}
			set {
				change = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Change"));
			}
		}
	}
}
