using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Combo;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Cash;
using PointOfSale.Drink;
using PointOfSale.Entree;
using PointOfSale.Side;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		IOrderItem foodItem;
		public MainWindow() {
			InitializeComponent();
			typeSelector.Content = new TypeSelector(this);
			BotControl.Content = new BottomControls(this);
			Total.Content = new RuningTotal();
		}

		/// <summary>
		/// adds item to total
		/// </summary>
		public void AddItem() {
			if (modiferChoices.Content != null) {
				if (Total.Content is RuningTotal total) {
					total.AddElement(foodItem);
					itemChoice.Content = null;
					modiferChoices.Content = null;
				}
			}
		}

		/// <summary>
		/// logic for the add combo button
		/// </summary>
		public void AddCombo() {
			if (modiferChoices.Content != null) {
				if (Total.Content is RuningTotal total) {
					if (total.orderElements.SelectedValue is Combo combo) {
						if (foodItem is IEntreeItem entree)
							combo.Entree = entree;
						if (foodItem is IDrinkItem drink)
							combo.Drink = drink;
						if (foodItem is ISideItem side)
							combo.Side = side;
						itemChoice.Content = null;
						modiferChoices.Content = null;
					}
					else {
						Combo c = new Combo();
						if (foodItem is IEntreeItem entree)
							c.Entree = entree;
						if (foodItem is IDrinkItem drink)
							c.Drink = drink;
						if (foodItem is ISideItem side)
							c.Side = side;
						total.AddElement(c);
						itemChoice.Content = null;
						modiferChoices.Content = null;
					}
				}
			}
		}

		/// <summary>
		/// removes IOrderItem from total
		/// </summary>
		public void RemoveItem() {
			if (Total.Content is RuningTotal total) {
				if (total.orderElements.SelectedValue is IOrderItem item) {
					total.RemoveElement(item);
				}
			}
		}

		public void NewOrder() {
			Total.Content = new RuningTotal();
			itemChoice.Content = null;
			modiferChoices.Content = null;
		}

		public void CompleteOrder() {
			typeSelector.Content = null;
			itemChoice.Content = new PaymentOptions(this);
		}

		/// <summary>
		/// brings up entreee selections
		/// </summary>
		public void EntreeSelected() {
			itemChoice.Content = new EntreeOption();
			modiferChoices.Content = null;
		}

		/// <summary>
		/// brings up side selections
		/// </summary>
		public void SideSelected() {
			itemChoice.Content = new SideOption();
			modiferChoices.Content = null;
		}

		/// <summary>
		/// brings up drink selections
		/// </summary>
		public void DrinkSelected() {
			itemChoice.Content = new DrinkOption();
			modiferChoices.Content = null;
		}

		/// <summary>
		/// used to add coffee item to total
		/// </summary>
		public void CoffeeSelected() {
			DrinkModifiers drinkMod = new DrinkModifiers();
			drinkMod.lemonToggleButton.Visibility = Visibility.Collapsed;
			Grid.SetColumnSpan(drinkMod.iceToggleButton, 2);
			foodItem = new CandlehearthCoffee();
			drinkMod.DataContext = foodItem;
			modiferChoices.Content = drinkMod;
		}

		/// <summary>
		/// used to add aple juice item to total
		/// </summary>
		public void AppleJuiceSelected() {
			DrinkModifiers drinkMod = new DrinkModifiers();
			drinkMod.creamToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.lemonToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.decafToggleButton.Visibility = Visibility.Collapsed;
			Grid.SetColumnSpan(drinkMod.iceToggleButton, 2);
			Grid.SetRowSpan(drinkMod.iceToggleButton, 2);
			foodItem = new ArentinoAppleJuice();
			drinkMod.DataContext = foodItem;
			modiferChoices.Content = drinkMod;
		}

		/// <summary>
		/// used to add milk item to total
		/// </summary>
		public void MilkSelected() {
			DrinkModifiers drinkMod = new DrinkModifiers();
			drinkMod.creamToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.lemonToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.decafToggleButton.Visibility = Visibility.Collapsed;
			Grid.SetColumnSpan(drinkMod.iceToggleButton, 2);
			Grid.SetRowSpan(drinkMod.iceToggleButton, 2);
			foodItem = new MarkarthMilk();
			drinkMod.DataContext = foodItem;
			modiferChoices.Content = drinkMod;
		}

		/// <summary>
		/// used to add soda item to total
		/// </summary>
		public void SodaSelected() {
			SailorSodaModifiers sodaMods = new SailorSodaModifiers();
			sodaMods.creamToggleButton.Visibility = Visibility.Collapsed;
			sodaMods.lemonToggleButton.Visibility = Visibility.Collapsed;
			sodaMods.decafToggleButton.Visibility = Visibility.Collapsed;
			Grid.SetColumnSpan(sodaMods.iceToggleButton, 2);
			Grid.SetRowSpan(sodaMods.iceToggleButton, 2);
			foodItem = new SailorSoda();
			sodaMods.DataContext = foodItem;
			modiferChoices.Content = sodaMods;
		}

		/// <summary>
		/// used to add water item to total
		/// </summary>
		public void WaterSelected() {
			DrinkModifiers drinkMod = new DrinkModifiers();
			drinkMod.creamToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.decafToggleButton.Visibility = Visibility.Collapsed;
			Grid.SetRowSpan(drinkMod.lemonToggleButton, 2);
			Grid.SetRowSpan(drinkMod.iceToggleButton, 2);
			foodItem = new WarriorWater();
			drinkMod.DataContext = foodItem;
			modiferChoices.Content = drinkMod;
		}

		/// <summary>
		/// used to add fry item to total
		/// </summary>
		public void WaffleFriesSelected() {
			SideModifiers sideMod = new SideModifiers();
			foodItem = new DragonbornWaffleFries();
			sideMod.DataContext = foodItem;
			modiferChoices.Content = sideMod;
		}

		/// <summary>
		/// used to add fried miraak item to total
		/// </summary>
		public void FriedMiraakSelected() {
			SideModifiers sideMod = new SideModifiers();
			foodItem = new FriedMiraak();
			sideMod.DataContext = foodItem;
			modiferChoices.Content = sideMod;
		}

		/// <summary>
		/// used to add otar grits item to total
		/// </summary>
		public void OtarGritsSelected() {
			SideModifiers sideMod = new SideModifiers();
			foodItem = new MadOtarGrits();
			sideMod.DataContext = foodItem;
			modiferChoices.Content = sideMod;
		}

		/// <summary>
		/// used to add salad item to total
		/// </summary>
		public void SaladSelected() {
			SideModifiers sideMod = new SideModifiers();
			foodItem = new VokunSalad();
			sideMod.DataContext = foodItem;
			modiferChoices.Content = sideMod;
		}

		/// <summary>
		/// used to add bh burger item to total
		/// </summary>
		public void BriarHeartBurgerSelected() {
			BurgerModifiers foodMods = new BurgerModifiers();
			foodMods.eggToggleButton.Visibility = Visibility.Collapsed;
			foodMods.baconToggleButton.Visibility = Visibility.Collapsed;
			foodMods.mayToggleButton.Visibility = Visibility.Collapsed;
			foodMods.lettuceToggleButton.Visibility = Visibility.Collapsed;
			foodMods.tomatoToggleButton.Visibility = Visibility.Collapsed;
			foodItem = new BriarheartBurger();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		/// <summary>
		/// used to add double dragr item to total
		/// </summary>
		public void DoubleDraugrSelected() {
			BurgerModifiers foodMods = new BurgerModifiers();
			foodMods.eggToggleButton.Visibility = Visibility.Collapsed;
			foodMods.baconToggleButton.Visibility = Visibility.Collapsed;
			foodItem = new DoubleDraugr();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		/// <summary>
		/// used to add thriple thalmor item to total
		/// </summary>
		public void ThalmorTripleSelected() {
			BurgerModifiers foodMods = new BurgerModifiers();
			foodItem = new ThalmorTriple();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		/// <summary>
		/// used to add omelette item to total
		/// </summary>
		public void GardenOrcOmeletteSelected() {
			OmeletteModifiers foodMods = new OmeletteModifiers();
			foodItem = new GardenOrcOmelette();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		/// <summary>
		/// used to add cheese steak item to total
		/// </summary>
		public void PhillyPoacherSelected() {
			CheeseSteakModifiers foodMods = new CheeseSteakModifiers();
			foodItem = new PhillyPoacher();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		/// <summary>
		/// used to add platter item to total
		/// </summary>
		public void SmokehouseSkeletonSelected() {
			SHSkeletonModifiers foodMods = new SHSkeletonModifiers();
			foodItem = new SmokehouseSkeleton();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		/// <summary>
		/// used to add t-bone item to total
		/// </summary>
		public void ThugsTBoneSelected() {
			ContentControl foodMods = new ContentControl();
			foodItem = new ThugsTBone();
			foodMods.DataContext = foodItem;
			modiferChoices.Content = foodMods;
		}

		public void PayWithCash() {
			if (Total.Content is RuningTotal rt) {
				if (rt.DataContext is Order or) {
					modiferChoices.Content = new CashPayment(or.Total, this);
				}
			}
		}

		public void ReturnToOrder() {
			typeSelector.Content = new TypeSelector(this);
			itemChoice.Content = null;
			modiferChoices.Content = null;
		}

		public void FinalizeCashSale(Register register) {
			register.UpdateRegister();
			PrintOrder();
			RoundRegister.RecieptPrinter.PrintLine("Paid with: Cash");
			RoundRegister.RecieptPrinter.PrintLine("Amount Given:  $" + register.CountCustomerPayment());
			RoundRegister.RecieptPrinter.PrintLine("Change due:    $" + register.ChangeDue);
			RoundRegister.RecieptPrinter.CutTape();
			typeSelector.Content = new TypeSelector(this);
			NewOrder();
		}

		public void PayWithCard() {
			if (Total.Content is RuningTotal rt) {
				if (rt.DataContext is Order order) {
					if (RoundRegister.CardReader.RunCard(order.Total) == RoundRegister.CardTransactionResult.Approved) {
						PrintOrder();
						RoundRegister.RecieptPrinter.PrintLine("Paid with: Card");
						RoundRegister.RecieptPrinter.PrintLine("Card Approved");
						RoundRegister.RecieptPrinter.CutTape();
						typeSelector.Content = new TypeSelector(this);
						NewOrder();
					}
				}
			}
		}

		private void PrintOrder() {
			RoundRegister.RecieptPrinter.PrintLine("Bleakwind Buffet");
			if (Total.Content is RuningTotal rt) {
				if (rt.DataContext is Order order) {
					foreach (IOrderItem item in order) {
						RoundRegister.RecieptPrinter.PrintLine(item.ToString() + " " + item.Price.ToString());
						foreach (string s in item.SpecialInstructions) {
							RoundRegister.RecieptPrinter.PrintLine("   " + s);
						}
					}
					RoundRegister.RecieptPrinter.PrintLine("Subtotal   $" + order.Subtotal.ToString());
					RoundRegister.RecieptPrinter.PrintLine("Tax        $" + order.Tax.ToString());
					RoundRegister.RecieptPrinter.PrintLine("Total      $" + order.Total.ToString());
				}
			}
		}
	}
}
