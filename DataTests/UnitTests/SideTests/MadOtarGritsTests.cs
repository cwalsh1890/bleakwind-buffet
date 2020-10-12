/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Runtime.InteropServices.ComTypes;
using BleakwindBuffet.Data.Menu;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        /// <summary>
        /// tests to ensure that the side is inheriting the Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide() {
            MadOtarGrits og = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(og);
        }

        /// <summary>
		/// ensure that the Side is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            MadOtarGrits og = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(og);
        }

        /// <summary>
        /// Tests to ensure that the size of the side is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits og = new MadOtarGrits();
            Assert.Equal(Size.Small, og.Size);
        }
            
        /// <summary>
        /// Tests to ensure that the size is able to be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits og = new MadOtarGrits();
            og.Size = Size.Large;
            Assert.Equal(Size.Large, og.Size);
            og.Size = Size.Medium;
            Assert.Equal(Size.Medium, og.Size);
            og.Size = Size.Small;
            Assert.Equal(Size.Small, og.Size);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are returned correctly
        /// </summary>
        /// <remarks>There is no intended way for anything to be added to special instructions</remarks>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits og = new MadOtarGrits();
            Assert.Empty(og.SpecialInstructions);
        }

        /// <summary>
        /// Tests to ensure that the price is correct based on the size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="price">The correct price for the side based on size</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits og = new MadOtarGrits();
            og.Size = size;
            Assert.Equal(price, og.Price);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on the size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="calories">The correct calories for the side based on the size</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits og = new MadOtarGrits();
            og.Size = size;
            Assert.Equal(calories, og.Calories);
        }

        /// <summary>
        /// Tests to ensure that the ToString method is correct based on size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="name">The correct string that should be output based on size</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits og = new MadOtarGrits();
            og.Size = size;
            Assert.Equal(name, og.ToString());
        }

        /// <summary>
        /// Tests to ensure that an exception is thrown if an invalid size is used to try an access price or calories
        /// </summary>
        [Fact]
        public void ThrowsExceptionIfInvalidSizeIsUsed()
        {
            MadOtarGrits og = new MadOtarGrits();
            og.Size = (Size)4;
            Assert.Throws<NotImplementedException>(() => og.Price);
            Assert.Throws<NotImplementedException>(() => og.Calories);
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            MadOtarGrits og = new MadOtarGrits();
            Assert.PropertyChanged(og, "Size", () => {
                og.Size = Size.Large;
            });

            Assert.PropertyChanged(og, "Price", () => {
                og.Size = Size.Medium;
            });

            Assert.PropertyChanged(og, "Calories", () => {
                og.Size = Size.Large;
            });
        }
    }
}