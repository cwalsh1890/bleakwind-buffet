/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests {
        /// <summary>
        /// tests to ensure that the drink is inheriting the Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink() {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        /// <summary>
        /// ensure that the drink is implementing the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem() {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        

        /// <summary>
        /// Tests to ensure that the ice property of the drink is originally initialized to false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault() {
			ArentinoAppleJuice aj = new ArentinoAppleJuice();
			Assert.False(aj.Ice);
		}

        /// <summary>
        /// Tests to ensure that the size of the drink is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
		}

        /// <summary>
        /// Tests to ensure that the ice property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = true;
			Assert.True(aj.Ice);
			aj.Ice = false;
			Assert.False(aj.Ice);
		}

        /// <summary>
        /// tests to ensure that the size property is able to be set for the drink
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = Size.Large;
			Assert.Equal(Size.Large, aj.Size);
			aj.Size = Size.Medium;
			Assert.Equal(Size.Medium, aj.Size);
			aj.Size = Size.Small;
			Assert.Equal(Size.Small, aj.Size);
		}

        /// <summary>
        /// tests to ensure that the price is correct based on the size of the drink
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="price">The correct price that should be output based on the size of drink</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
			Assert.Equal(price, aj.Price);
		}

        /// <summary>
        /// Tests to ensure that an exception is thrown if an invalid size is used to try an access price or calories
        /// </summary>
        [Fact]
        public void ThrowsExceptionIfInvalidSizeIsUsed()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = (Size)4;
            Assert.Throws<NotImplementedException>(() => aj.Price);
            Assert.Throws<NotImplementedException>(() => aj.Calories);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on the size of the drink
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="cal">The correct calories for the drink based on the size of the drink</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
			Assert.Equal(cal, aj.Calories);
		}

        /// <summary>
        /// tests to ensure that the special instructions have been properly set
        /// </summary>
        /// <param name="includeIce">If the drink should or should not have ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = includeIce;
			if (includeIce)
				Assert.Contains("Add ice", aj.SpecialInstructions);
			else
				Assert.Empty(aj.SpecialInstructions);
		}

        /// <summary>
        /// Tests to ensure that the ToString method is correct based on size
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">The proper output as a string based on the size of the drink</param>
        [Theory]
        [InlineData(Size.Small, "Small Arentino Apple Juice")]
        [InlineData(Size.Medium, "Medium Arentino Apple Juice")]
        [InlineData(Size.Large, "Large Arentino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () => {
                aj.Ice = true;
            });

            Assert.PropertyChanged(aj, "SpecialInstructions", () => {
                aj.Ice = false;
            });

            Assert.PropertyChanged(aj, "Size", () => {
                aj.Size = Size.Large;
            });

            Assert.PropertyChanged(aj, "Price", () => {
                aj.Size = Size.Medium;
            });

            Assert.PropertyChanged(aj, "Calories", () => {
                aj.Size = Size.Large;
            });
        }
    }
}