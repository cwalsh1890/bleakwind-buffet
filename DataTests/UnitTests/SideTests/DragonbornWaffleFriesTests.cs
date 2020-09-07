/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Tests to ensure that the size is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, wf.Size);
        }

        /// <summary>
        /// Tests to ensure that the size is able to change
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = Size.Large;
            Assert.Equal(Size.Large, wf.Size);
            wf.Size = Size.Medium;
            Assert.Equal(Size.Medium, wf.Size);
            wf.Size = Size.Small;
            Assert.Equal(Size.Small, wf.Size);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are returned correctly
        /// </summary>
        /// <remarks>There is no intended way for anything to be added to special instructions</remarks>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Empty(wf.SpecialInstructions);
        }

        /// <summary>
        /// Tests to ensure that the price is correct based on size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="price">The correct price for the given size</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(price, wf.Price);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on size
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="calories">The correct number of calories for the given size</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(calories, wf.Calories);
        }

        /// <summary>
        /// Tests to ensure that the to string is correct based on the different sizes of side
        /// </summary>
        /// <param name="size">The size of the side</param>
        /// <param name="name">The correct string that should be outputed based on size</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(name, wf.ToString());
        }
    }
}