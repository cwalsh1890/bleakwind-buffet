using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Sides;
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
			TypeSelector.Content = new TypeSelector(this);
			BotControl.Content = new BottomControls(this);
		}

		/// <summary>
		/// adds item to total
		/// </summary>
		public void AddItem() {
			if (modiferChoices != null) {
				Total.AddElement(foodItem);
			}
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
			DrinkModifiers drinkMod = new DrinkModifiers();
			drinkMod.creamToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.lemonToggleButton.Visibility = Visibility.Collapsed;
			drinkMod.decafToggleButton.Visibility = Visibility.Collapsed;
			Grid.SetColumnSpan(drinkMod.iceToggleButton, 2);
			Grid.SetRowSpan(drinkMod.iceToggleButton, 2);
			SailorSoda foodItem = new SailorSoda();
			drinkMod.DataContext = foodItem;
			SailorSodaModifiers sodaMods = new SailorSodaModifiers(drinkMod);
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
	}
}
