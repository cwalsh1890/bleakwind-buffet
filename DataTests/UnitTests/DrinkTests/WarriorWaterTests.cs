/*
 * Author: Coby Walsh
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests {
	public class WarriorWaterTests {
		/// <summary>
		/// tests to ensure that the drink is inheriting the Drink class
		/// </summary>
		[Fact]
		public void ShouldBeADrink() {
			WarriorWater ww = new WarriorWater();
			Assert.IsAssignableFrom<Drink>(ww);
		}

		/// <summary>
		/// ensure that the drink is implementing the IOrderItem interface
		/// </summary>
		[Fact]
		public void ShouldBeAnIOrderItem() {
			WarriorWater ww = new WarriorWater();
			Assert.IsAssignableFrom<IOrderItem>(ww);
		}

		/// <summary>
		/// Tests to ensure that the ice property should be set to true by default
		/// </summary>
		[Fact]
		public void ShouldIncludeIceByDefault() {
			WarriorWater ww = new WarriorWater();
			Assert.True(ww.Ice);
		}

		/// <summary>
		/// Tests to ensure that the lemon property is set to false by default
		/// </summary>
		[Fact]
		public void ShouldNotIncludeLemonByDefault() {
			WarriorWater ww = new WarriorWater();
			Assert.False(ww.Lemon);
		}

		/// <summary>
		/// Tests to ensure that the size is set to small by default
		/// </summary>
		[Fact]
		public void DefaultSizeShouldBeSmall() {
			WarriorWater ww = new WarriorWater();
			Assert.Equal(Size.Small, ww.Size);
		}

		/// <summary>
		/// Tests to ensure that the ice property is able to be set
		/// </summary>
		[Fact]
		public void ShouldBeAbleToSetIce() {
			WarriorWater ww = new WarriorWater();
			ww.Ice = false;
			Assert.False(ww.Ice);
			ww.Ice = true;
			Assert.True(ww.Ice);
		}

		/// <summary>
		/// Tests to ensure that the lemon property is able to be set
		/// </summary>
		[Fact]
		public void ShouldBeAbleToSetLemon() {
			WarriorWater ww = new WarriorWater();
			ww.Lemon = true;
			Assert.True(ww.Lemon);
			ww.Lemon = false;
			Assert.False(ww.Lemon);
		}

		/// <summary>
		/// Tests to ensure that the size property is able to be set
		/// </summary>
		[Fact]
		public void ShouldBeAbleToSetSize() {
			WarriorWater ww = new WarriorWater();
			ww.Size = Size.Large;
			Assert.Equal(Size.Large, ww.Size);
			ww.Size = Size.Medium;
			Assert.Equal(Size.Medium, ww.Size);
			ww.Size = Size.Small;
			Assert.Equal(Size.Small, ww.Size);
		}

		/// <summary>
		/// tests to ensure that the price is correct based on the size of the drink
		/// </summary>
		/// <param name="size">The size of the drink</param>
		/// <param name="price">The correct price that should be output based on the size of drink</param>
		[Theory]
		[InlineData(Size.Small, 0)]
		[InlineData(Size.Medium, 0)]
		[InlineData(Size.Large, 0)]
		public void ShouldHaveCorrectPriceForSize(Size size, double price) {
			WarriorWater ww = new WarriorWater();
			ww.Size = size;
			Assert.Equal(price, ww.Price);
		}

		/// <summary>
		/// Tests to ensure that the calories are correct based on the size of the drink
		/// </summary>
		/// <param name="size">The size of the drink</param>
		/// <param name="cal">The correct calories for the drink based on the size of the drink</param>
		[Theory]
		[InlineData(Size.Small, 0)]
		[InlineData(Size.Medium, 0)]
		[InlineData(Size.Large, 0)]
		public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal) {
			WarriorWater ww = new WarriorWater();
			ww.Size = size;
			Assert.Equal(cal, ww.Calories);
		}

		/// <summary>
		/// Tests to ensure that the special insturctions list is correct
		/// </summary>
		/// <param name="includeIce">Whether or not the drink should have ice</param>
		/// <param name="includeLemon">Whether or not the drink should have lemon</param>
		[Theory]
		[InlineData(true, true)]
		[InlineData(true, false)]
		[InlineData(false, true)]
		[InlineData(false, false)]
		public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon) {
			WarriorWater ww = new WarriorWater();
			ww.Ice = includeIce;
			ww.Lemon = includeLemon;
			if (includeIce)
				Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
			else
				Assert.Contains("Hold ice", ww.SpecialInstructions);
			if (includeLemon)
				Assert.Contains("Add lemon", ww.SpecialInstructions);
			else
				Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
		}

		/// <summary>
		/// ensures that the drink has the correct ToString
		/// </summary>
		/// <param name="size">The size of the drink</param>
		/// <param name="name">The correct output as a string based on the size of the drink</param>
		[Theory]
		[InlineData(Size.Small, "Small Warrior Water")]
		[InlineData(Size.Medium, "Medium Warrior Water")]
		[InlineData(Size.Large, "Large Warrior Water")]
		public void ShouldHaveCorrectToStringBasedOnSize(Size size, string name) {
			WarriorWater ww = new WarriorWater();
			ww.Size = size;
			Assert.Equal(name, ww.ToString());
		}

		[Fact]
		public void ShouldNotifyPropertyChanged() {
			WarriorWater ww = new WarriorWater();
			Assert.PropertyChanged(ww, "Size", () => {
				ww.Size = Size.Large;
			});

			Assert.PropertyChanged(ww, "Ice", () => {
				ww.Ice = false;
			});

			Assert.PropertyChanged(ww, "SpecialInstructions", () => {
				ww.Ice = true;
			});

			Assert.PropertyChanged(ww, "Lemon", () => {
				ww.Lemon = true;
			});

			Assert.PropertyChanged(ww, "SpecialInstructions", () => {
				ww.Lemon = false;
			});
		}
	}
}
