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
		public MainWindow() {
			InitializeComponent();
		}

		public void EntreeSelected() {
			itemChoice.Content = new EntreeOption();
			modiferChoices.Content = null;
		}

		public void SideSelected() {
			itemChoice.Content = new SideOption();
			modiferChoices.Content = null;
		}

		public void DrinkSelected() {
			itemChoice.Content = new DrinkOption();
			modiferChoices.Content = null;
		}

		public void CoffeeSelected() {
			modiferChoices.Content = new DrinkModifiers();
		}

		public void AppleJuiceOrMilkSelected() {
			modiferChoices.Content = new DrinkModifiers();
		}

		public void SodaSelected() {
			modiferChoices.Content = new SailorSodaModifiers();
		}

		public void WaterSelected() {
			modiferChoices.Content = new DrinkModifiers();
		}

		public void WaffleFriesSelected() {
			modiferChoices.Content = new SideModifiers();
		}

		public void FriedMiraakSelected() {
			modiferChoices.Content = new SideModifiers();
		}

		public void OtarGritsSelected() {
			modiferChoices.Content = new SideModifiers();
		}

		public void SaladSelected() {
			modiferChoices.Content = new SideModifiers();
		}

		public void BriarHeartBurgerSelected() {
			modiferChoices.Content = new BurgerModifiers();
		}

		public void DoubleDraugrSelected() {
			modiferChoices.Content = new BurgerModifiers();
		}

		public void ThalmorTripleSelected() {
			modiferChoices.Content = new BurgerModifiers();
		}

		public void GardenOrcOmeletteSelected() {
			modiferChoices.Content = new OmeletteModifiers();
		}

		public void PhillyPoacherSelected() {
			modiferChoices.Content = new CheeseSteakModifiers();
		}

		public void SmokehouseSkeletonSelected() {
			modiferChoices.Content = new SHSkeletonModifiers();
		}

		public void ThugsTBoneSelected() {
			modiferChoices.Content = null;
		}
	}
}
