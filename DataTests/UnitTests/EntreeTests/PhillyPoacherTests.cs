/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree() {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        /// <summary>
        /// Tests to ensure that sirloin is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// Tests to ensure that oinion is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// Tests to ensure that roll is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }
        
        /// <summary>
        /// Test to ensure that the sirloin property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// Test to ensure that the oinion property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// Test to ensure that the rool property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// Tests to ensure that the sandwich returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        /// <summary>
        /// tests to ensure that the sandwich returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal((uint) 784, pp.Calories);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are correct
        /// </summary>
        /// <param name="includeSirloin">whether or not the sandwich should have steak</param>
        /// <param name="includeOnion">whether or not the sandwich should have oinion</param>
        /// <param name="includeRoll">whether or not the sandwich should have a roll</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;

            if (includeSirloin)
                Assert.DoesNotContain("Hold sirloin", pp.SpecialInstructions);
            else
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);

            if (includeOnion)
                Assert.DoesNotContain("Hold onion", pp.SpecialInstructions);
            else
                Assert.Contains("Hold onion", pp.SpecialInstructions);

            if (includeRoll)
                Assert.DoesNotContain("Hold roll", pp.SpecialInstructions);
            else
                Assert.Contains("Hold roll", pp.SpecialInstructions);
        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}