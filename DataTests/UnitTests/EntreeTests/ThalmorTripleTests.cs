/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        /// <summary>
        /// Tests to ensure that bun is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests to ensure that ketchup is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests to ensure that mustard is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests to ensure that pickle is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Tests to ensure that cheese is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests to ensure that tomato is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests to ensure that lettuce is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests to ensure that mayo is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests to ensure that bacon is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests to ensure that egg is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Test to ensure that the bun property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Test to ensure that the ketchup property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Test to ensure that the mustard property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Test to ensure that the pickle property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Test to ensure that the cheese property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Test to ensure that the tomato property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Test to ensure that the lettuce property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Test to ensure that the mayo property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Test to ensure that the bacon property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Test to ensure that the egg property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests to ensure that the burger returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        /// <summary>
        /// tests to ensure that the burger returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal((uint) 943, tt.Calories);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are correct
        /// </summary>
        /// <param name="includeBun">whether or not the burger should have a bun</param>
        /// <param name="includeKetchup">whether or not the burger should have ketchup</param>
        /// <param name="includeMustard">whether or not the burger should have mustard</param>
        /// <param name="includePickle">whether or not the burger should have pickles</param>
        /// <param name="includeCheese">whether or not the burger should have cheese</param>
        /// <param name="includeTomato">whether or not the burger should have tomato</param>
        /// <param name="includeLettuce">whether or not the burger should have lettuce</param>
        /// <param name="includeMayo">whether or not the burger should have mayo</param>
        /// <param name="includeBacon">whether or not the burger should have bacon</param>
        /// <param name="includeEgg">whether or not the burger should have egg</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (includeBun)
                Assert.DoesNotContain("Hold bun", tt.SpecialInstructions);
            else
                Assert.Contains("Hold bun", tt.SpecialInstructions);

            if (includeKetchup)
                Assert.DoesNotContain("Hold ketchup", tt.SpecialInstructions);
            else
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);

            if (includeMustard)
                Assert.DoesNotContain("Hold mustard", tt.SpecialInstructions);
            else
                Assert.Contains("Hold mustard", tt.SpecialInstructions);

            if (includePickle)
                Assert.DoesNotContain("Hold pickle", tt.SpecialInstructions);
            else
                Assert.Contains("Hold pickle", tt.SpecialInstructions);

            if (includeCheese)
                Assert.DoesNotContain("Hold cheese", tt.SpecialInstructions);
            else
                Assert.Contains("Hold cheese", tt.SpecialInstructions);

            if (includeTomato)
                Assert.DoesNotContain("Hold tomato", tt.SpecialInstructions);
            else
                Assert.Contains("Hold tomato", tt.SpecialInstructions);

            if (includeLettuce)
                Assert.DoesNotContain("Hold lettuce", tt.SpecialInstructions);
            else
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);

            if (includeMayo)
                Assert.DoesNotContain("Hold mayo", tt.SpecialInstructions);
            else
                Assert.Contains("Hold mayo", tt.SpecialInstructions);

            if (includeBacon)
                Assert.DoesNotContain("Hold bacon", tt.SpecialInstructions);
            else
                Assert.Contains("Hold bacon", tt.SpecialInstructions);

            if (includeEgg)
                Assert.DoesNotContain("Hold egg", tt.SpecialInstructions);
            else
                Assert.Contains("Hold egg", tt.SpecialInstructions);
        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }
    }
}