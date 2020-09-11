/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using NuGet.Frameworks;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        /// <summary>
        /// tests to ensure that the drink is inheriting the Drink class
        /// </summary>
        [Fact]
        public void ShouldBeADrink() {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        /// <summary>
        /// ensure that the drink is implementing the IOrderItem interface
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem() {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        /// <summary>
        /// Tests to ensure that the ice property should be set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// Tests to ensure that the size is set to small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// Tests to ensure that the flavor is set to cherry
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        /// <summary>
        /// Tests to ensure that the ice property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = false;
            Assert.False(ss.Ice);
            ss.Ice = true;
            Assert.True(ss.Ice);
        }

        /// <summary>
        /// Tests to ensure that the size property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        /// <summary>
        /// Tests to ensure that the flavor property is able to be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
        }

        /// <summary>
        /// tests to ensure that the price is correct based on the size of the drink
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="price">The correct price that should be output based on the size of drink</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        /// <summary>
        /// Tests to ensure that the calories are correct based on the size of the drink
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="cal">The correct calories for the drink based on the size of the drink</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        /// <summary>
        /// tests to ensure that the special instructions list is correct 
        /// </summary>
        /// <param name="includeIce">whether or not the drink should include ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = includeIce;
            if (includeIce)
                Assert.Empty(ss.SpecialInstructions);
            else
                Assert.Contains("Hold ice", ss.SpecialInstructions);
        }

        /// <summary>
        /// Tests to ensure that the ToString method is correct based on size and flavor
        /// </summary>
        /// <param name="flavor">The flavor of the drink</param>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">The correct output as a string based on the size and flavor</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = flavor;
            ss.Size = size;
            Assert.Equal(name, ss.ToString());
        }
    }
}
