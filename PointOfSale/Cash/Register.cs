using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;

namespace PointOfSale.Cash {
	public class Register : INotifyPropertyChanged {
		public Register(double due) {
			Total = due;

			Hundreds.PropertyChanged += MoneyListener;
			Fifties.PropertyChanged += MoneyListener;
			Twenties.PropertyChanged += MoneyListener;
			Tens.PropertyChanged += MoneyListener;
			Fives.PropertyChanged += MoneyListener;
			Twos.PropertyChanged += MoneyListener;
			Ones.PropertyChanged += MoneyListener;
			Dollars.PropertyChanged += MoneyListener;
			HalfDollars.PropertyChanged += MoneyListener;
			Quarters.PropertyChanged += MoneyListener;
			Dimes.PropertyChanged += MoneyListener;
			Nickels.PropertyChanged += MoneyListener;
			Pennies.PropertyChanged += MoneyListener;
		}

		public double Total { get; }
		public double AmountDue {
			get {
				double amount = Math.Round(Total - CountCustomerPayment(), 2);
				if (amount > 0)
					return amount;
				return 0;
			}
		}

		public double ChangeDue {
			get {
				double amount = Math.Round(CountCustomerPayment() - Total, 2);
				if (amount > 0)
					return amount;
				return 0;
			}
		}

		void MoneyListener(object sender, PropertyChangedEventArgs e) {
			if (e.PropertyName == "Payment") {
				CalculateChange();
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
			}
		}

		public MoneyCount Hundreds = new MoneyCount(RoundRegister.CashDrawer.Hundreds);
		public MoneyCount Fifties = new MoneyCount(RoundRegister.CashDrawer.Fifties);
		public MoneyCount Twenties = new MoneyCount(RoundRegister.CashDrawer.Twenties);
		public MoneyCount Tens = new MoneyCount(RoundRegister.CashDrawer.Tens);
		public MoneyCount Fives = new MoneyCount(RoundRegister.CashDrawer.Fives);
		public MoneyCount Twos = new MoneyCount(RoundRegister.CashDrawer.Twos);
		public MoneyCount Ones = new MoneyCount(RoundRegister.CashDrawer.Ones);
		public MoneyCount Dollars = new MoneyCount(RoundRegister.CashDrawer.Dollars);
		public MoneyCount HalfDollars = new MoneyCount(RoundRegister.CashDrawer.HalfDollars);
		public MoneyCount Quarters = new MoneyCount(RoundRegister.CashDrawer.Quarters);
		public MoneyCount Dimes = new MoneyCount(RoundRegister.CashDrawer.Dimes);
		public MoneyCount Nickels = new MoneyCount(RoundRegister.CashDrawer.Nickels);
		public MoneyCount Pennies = new MoneyCount(RoundRegister.CashDrawer.Pennies);

		public event PropertyChangedEventHandler PropertyChanged;

		public void CalculateChange() {
			ResetChange();
			double payment = CountCustomerPayment();
			double change = payment - Total;

			while (change >= 100 && Hundreds.Drawer != 0) {
				Hundreds.Change += 1;
				change -= 100;
			}

			while (change >= 50 && Fifties.Drawer != 0) {
				Fifties.Change += 1;
				change -= 50;
			}


			while (change >= 20 && Twenties.Drawer != 0) {
				Twenties.Change += 1;
				change -= 20;
			}

			while (change >= 10 && Tens.Drawer != 0) {
				Tens.Change += 1;
				change -= 10;
			}

			while (change >= 5 && Fives.Drawer != 0) {
				Fives.Change += 1;
				change -= 5;
			}

			while (change >= 2 && Twos.Drawer != 0) {
				Twos.Change += 1;
				change -= 2;
			}

			while (change >= 1 && Ones.Drawer != 0) {
				Ones.Change += 1;
				change -= 1;
			}

			while (change >= 1 && Dollars.Drawer != 0) {
				Dollars.Change += 1;
				change -= 1;
			}

			while (change >= .5 && HalfDollars.Drawer != 0) {
				HalfDollars.Change += 1;
				change -= .5;
			}

			while (change >= .25 && Quarters.Drawer != 0) {
				Quarters.Change += 1;
				change -= .25;
			}

			while (change >= .1 && Dimes.Drawer != 0) {
				Dimes.Change += 1;
				change -= .1;
			}

			while (change >= .05 && Nickels.Drawer != 0) {
				Nickels.Change += 1;
				change -= .05;
			}

			while (change >= .01 && Pennies.Drawer != 0) {
				Pennies.Change += 1;
				change -= .01;
			}
		}

		private void ResetChange() {
			Hundreds.Change = 0;
			Fifties.Change = 0;
			Twenties.Change = 0;
			Tens.Change = 0;
			Fives.Change = 0;
			Twos.Change = 0;
			Ones.Change = 0;
			Dollars.Change = 0;
			HalfDollars.Change = 0;
			Quarters.Change = 0;
			Dimes.Change = 0;
			Nickels.Change = 0;
			Pennies.Change = 0;
		}

		public double CountCustomerPayment() {
			return Math.Round((Hundreds.Payment * 100) + (Fifties.Payment * 50) + (Twenties.Payment * 20) + (Tens.Payment * 10) + (Fives.Payment * 5) + (Twos.Payment * 2) + (Ones.Payment * 1) + (Dollars.Payment * 1) + (HalfDollars.Payment * .50) + (Quarters.Payment * .25) + (Dimes.Payment * .1) + (Nickels.Payment * .05) + (Pennies.Payment * .01), 2);
		}

		public void UpdateRegister() {
			RoundRegister.CashDrawer.Hundreds = RoundRegister.CashDrawer.Hundreds + Hundreds.Payment - Hundreds.Change;
			RoundRegister.CashDrawer.Fifties = RoundRegister.CashDrawer.Fifties + Fifties.Payment - Fifties.Change;
			RoundRegister.CashDrawer.Twenties = RoundRegister.CashDrawer.Twenties + Twenties.Payment - Twenties.Change;
			RoundRegister.CashDrawer.Tens = RoundRegister.CashDrawer.Tens + Tens.Payment - Tens.Change;
			RoundRegister.CashDrawer.Fives = RoundRegister.CashDrawer.Fives + Fives.Payment - Fives.Change;
			RoundRegister.CashDrawer.Twos = RoundRegister.CashDrawer.Twos + Twos.Payment - Twos.Change;
			RoundRegister.CashDrawer.Ones = RoundRegister.CashDrawer.Ones + Ones.Payment - Ones.Change;
			RoundRegister.CashDrawer.Dollars = RoundRegister.CashDrawer.Dollars + Dollars.Payment - Dollars.Change;
			RoundRegister.CashDrawer.HalfDollars = RoundRegister.CashDrawer.HalfDollars + HalfDollars.Payment - HalfDollars.Change;
			RoundRegister.CashDrawer.Quarters = RoundRegister.CashDrawer.Quarters + Quarters.Payment - Quarters.Change;
			RoundRegister.CashDrawer.Dimes = RoundRegister.CashDrawer.Dimes + Dimes.Payment - Dimes.Change;
			RoundRegister.CashDrawer.Nickels = RoundRegister.CashDrawer.Nickels + Nickels.Payment - Nickels.Change;
			RoundRegister.CashDrawer.Pennies = RoundRegister.CashDrawer.Pennies + Pennies.Payment - Pennies.Change;

			Hundreds.PropertyChanged -= MoneyListener;
			Fifties.PropertyChanged -= MoneyListener;
			Twenties.PropertyChanged -= MoneyListener;
			Tens.PropertyChanged -= MoneyListener;
			Fives.PropertyChanged -= MoneyListener;
			Twos.PropertyChanged -= MoneyListener;
			Ones.PropertyChanged -= MoneyListener;
			Dollars.PropertyChanged -= MoneyListener;
			HalfDollars.PropertyChanged -= MoneyListener;
			Quarters.PropertyChanged -= MoneyListener;
			Dimes.PropertyChanged -= MoneyListener;
			Nickels.PropertyChanged -= MoneyListener;
			Pennies.PropertyChanged -= MoneyListener;
		}
	}
}
