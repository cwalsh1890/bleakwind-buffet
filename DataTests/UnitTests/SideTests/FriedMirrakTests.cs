/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Menu;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        /// <summary>
        /// tests to ensure that the side is inheriting the Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide() {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }

        /// <summary>
		/// ensure that the Side is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }

        /// <summary>
        /// Tests to ensure that the size of the side is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// tests to ensure that the size of the side is able to be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are returned correctly
        /// </summary>
        /// <remarks>There is no intended way for anything to be added to special instructions</remarks>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        /// <summary>
        /// Tests to ensure that the price is correct based on the size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="price">The correct price for the side based on size</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on the size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="calories">The correct calories for the side based on the size</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        /// <summary>
        /// Tests to ensure that the ToString method is correct based on size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="name">The correct string that should be output based on size</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }

        /// <summary>
        /// Tests to ensure that an exception is thrown if an invalid size is used to try an access price or calories
        /// </summary>
        [Fact]
        public void ThrowsExceptionIfInvalidSizeIsUsed()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = (Size)4;
            Assert.Throws<NotImplementedException>(() => fm.Price);
            Assert.Throws<NotImplementedException>(() => fm.Calories);
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "size", () => {
                fm.Size = Size.Large;
            });
        }
    }
}