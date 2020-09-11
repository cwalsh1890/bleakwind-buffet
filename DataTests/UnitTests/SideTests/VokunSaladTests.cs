/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        /// <summary>
        /// tests to ensure that the side is inheriting the Side class
        /// </summary>
        [Fact]
        public void ShouldBeASide() {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        /// <summary>
		/// ensure that the Side is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        /// <summary>
        /// Tests to ensure that the default size is small for the side
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Tests to ensure that the size of the side is able to be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are returned correctly
        /// </summary>
        /// <remarks>There is no intended way for anything to be added to special instructions</remarks>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }
        
        /// <summary>
        /// Tests to ensure that the price is correct based on the size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="price">The correct price for the side based on size</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on the size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="calories">The correct calories for the side based on the size</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        /// <summary>
        /// Tests to ensure that the ToString method is correct based on size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="name">The correct string that should be output based on size</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }
    }
}