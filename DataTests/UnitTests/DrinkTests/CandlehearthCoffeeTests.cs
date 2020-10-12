/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests {
        /// <summary>
        /// tests to ensure that the drink is inheriting the Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink() {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        /// <summary>
        /// ensure that the drink is implementing the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem() {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }

        /// <summary>
        /// Tests to ensure that the ice property of the drink is originally initialized to false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.False(cf.Ice);
        }

        /// <summary>
        /// Tests to ensure that the decaf property of the drink is originally initialized to false
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.False(cf.Decaf);
        }

        /// <summary>
        /// Tests to ensure that the roomForCream property of the drink is originally initialized to false
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.False(cf.RoomForCream);
        }

        /// <summary>
        /// Tests to ensure that the size of the drink is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cf.Size);
        }

        /// <summary>
        /// Tests to ensure that the ice property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Ice = true;
            Assert.True(cf.Ice);
            cf.Ice = false;
            Assert.False(cf.Ice);
        }

        /// <summary>
        /// Tests to ensure that the decaf property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Decaf = true;
            Assert.True(cf.Decaf);
            cf.Decaf = false;
            Assert.False(cf.Decaf);
        }

        /// <summary>
        /// Tests to ensure that the roomForCream property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.RoomForCream = true;
            Assert.True(cf.RoomForCream);
            cf.RoomForCream = false;
            Assert.False(cf.RoomForCream);
        }

        /// <summary>
        /// tests to ensure that the size property is able to be set for the drink
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize() {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = Size.Large;
            Assert.Equal(Size.Large, cf.Size);
            cf.Size = Size.Medium;
            Assert.Equal(Size.Medium, cf.Size);
            cf.Size = Size.Small;
            Assert.Equal(Size.Small, cf.Size);
        }

        /// <summary>
        /// tests to ensure that the price is correct based on the size of the drink
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="price">The correct price that should be output based on the size of drink</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price) {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = size;
            Assert.Equal(price, cf.Price);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on the size of the drink
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="cal">The correct calories for the drink based on the size of the drink</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal) {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = size;
            Assert.Equal(cal, cf.Calories);
        }

        /// <summary>
        /// tests to ensure that the special instructions have been properly set
        /// </summary>
        /// <param name="includeIce">If the drink should or should not have ice</param>
        /// <param name="includeCream">If the drink should or should not have cream</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream) {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Ice = includeIce;
            cf.RoomForCream = includeCream;
            if (includeCream)
                Assert.Contains("Add cream", cf.SpecialInstructions);
            if (includeIce)
                Assert.Contains("Add ice", cf.SpecialInstructions);
        }

        /// <summary>
        /// Tests to ensure that the ToString method is correct based on size and if it is decaf
        /// </summary>
        /// <param name="decaf">bool of if the drink should be decaf</param>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">The correct output as a string based on size and if it is decaf</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name) {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = size;
            cf.Decaf = decaf;
            Assert.Equal(name, cf.ToString());
        }

        /// <summary>
        /// Tests to ensure that an exception is thrown if an invalid size is used to try an access price or calories
        /// </summary>
        [Fact]
        public void ThrowsExceptionIfInvalidSizeIsUsed() {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = (Size) 4;
            Assert.Throws<NotImplementedException>(() => cc.Price);
            Assert.Throws<NotImplementedException>(() => cc.Calories);
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Size", () => {
                cc.Size = Size.Large;
            });

            Assert.PropertyChanged(cc, "Price", () => {
                cc.Size = Size.Medium;
            });

            Assert.PropertyChanged(cc, "Calories", () => {
                cc.Size = Size.Large;
            });

            Assert.PropertyChanged(cc, "Cream", () => {
                cc.RoomForCream = true;
            });

            Assert.PropertyChanged(cc, "SpecialInstructions", () => {
                cc.RoomForCream = false;
            });

            Assert.PropertyChanged(cc, "Ice", () => {
                cc.Ice = true;
            });

            Assert.PropertyChanged(cc, "SpecialInstructions", () => {
                cc.Ice = false;
            });

            Assert.PropertyChanged(cc, "Decaf", () => {
                cc.Decaf = true;
            });
        }
    }
}
