/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }

        /// <summary>
        /// Tests to ensure that bun is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Tests to ensure that letchup is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// Tests to ensure that mustard is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Tests to ensure that pickle is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// Tests to ensure that cheese is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// Test to ensure that the bun property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        /// <summary>
        /// Test to ensure that the ketchup property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        /// <summary>
        /// Test to ensure that the mustard property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        /// <summary>
        /// Test to ensure that the pickle property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        /// <summary>
        /// Test to ensure that the cheese property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        /// <summary>
        /// Tests to ensure that the burger returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        /// <summary>
        /// tests to ensure that the burger returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal((uint) 743, bb.Calories);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are correct
        /// </summary>
        /// <param name="includeBun">whether or not the burger should have a bun</param>
        /// <param name="includeKetchup">whether or not the burger should have ketchup</param>
        /// <param name="includeMustard">whether or not the burger should have mustard</param>
        /// <param name="includePickle">whether or not the burger should have pickles</param>
        /// <param name="includeCheese">whether or not the burger should have cheese</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (includeBun)
                Assert.DoesNotContain("Hold bun", bb.SpecialInstructions);
            else
                Assert.Contains("Hold bun", bb.SpecialInstructions);
            
            if (includeKetchup)
                Assert.DoesNotContain("Hold ketchup", bb.SpecialInstructions);
            else
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            
            if (includeMustard)
                Assert.DoesNotContain("Hold mustard", bb.SpecialInstructions);
            else
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
            
            if (includePickle)
                Assert.DoesNotContain("Hold pickle", bb.SpecialInstructions);
            else
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
            
            if (includeCheese)
                Assert.DoesNotContain("Hold cheese", bb.SpecialInstructions);
            else
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, "bun", () => {
                bb.Bun = false;
            });

            Assert.PropertyChanged(bb, "ketchup", () => {
                bb.Ketchup = false;
            });

            Assert.PropertyChanged(bb, "mustard", () => {
                bb.Mustard = false;
            });

            Assert.PropertyChanged(bb, "pickle", () => {
                bb.Pickle = false;
            });

            Assert.PropertyChanged(bb, "cheese", () => {
                bb.Cheese = false;
            });
        }
    }
}