/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        /// <summary>
        /// Tests to ensure that bun is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests to ensure that ketchup is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests to ensure that mustard is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests to ensure that pickle is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests to ensure that cheese is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests to ensure that tomato is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests to ensure that lettuce is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests to ensure that mayo is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Test to ensure that the bun property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Test to ensure that the ketchup property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Test to ensure that the mustard property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Test to ensure that the pickle property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Test to ensure that the cheese property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Test to ensure that the tomato property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Test to ensure that the lettuce property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Test to ensure that the mayo property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests to ensure that the burger returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        /// <summary>
        /// tests to ensure that the burger returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal((uint) 843, dd.Calories);
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
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (includeBun)
                Assert.DoesNotContain("Hold bun", dd.SpecialInstructions);
            else
                Assert.Contains("Hold bun", dd.SpecialInstructions);

            if (includeKetchup)
                Assert.DoesNotContain("Hold ketchup", dd.SpecialInstructions);
            else
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);

            if (includeMustard)
                Assert.DoesNotContain("Hold mustard", dd.SpecialInstructions);
            else
                Assert.Contains("Hold mustard", dd.SpecialInstructions);

            if (includePickle)
                Assert.DoesNotContain("Hold pickle", dd.SpecialInstructions);
            else
                Assert.Contains("Hold pickle", dd.SpecialInstructions);

            if (includeCheese)
                Assert.DoesNotContain("Hold cheese", dd.SpecialInstructions);
            else
                Assert.Contains("Hold cheese", dd.SpecialInstructions);

            if (includeTomato)
                Assert.DoesNotContain("Hold tomato", dd.SpecialInstructions);
            else
                Assert.Contains("Hold tomato", dd.SpecialInstructions);

            if (includeLettuce)
                Assert.DoesNotContain("Hold lettuce", dd.SpecialInstructions);
            else
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);

            if (includeMayo)
                Assert.DoesNotContain("Hold mayo", dd.SpecialInstructions);
            else
                Assert.Contains("Hold mayo", dd.SpecialInstructions);


        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "bun", () => {
                dd.Bun = false;
            });

            Assert.PropertyChanged(dd, "ketchup", () => {
                dd.Ketchup = false;
            });

            Assert.PropertyChanged(dd, "mustard", () => {
                dd.Mustard = false;
            });

            Assert.PropertyChanged(dd, "pickle", () => {
                dd.Pickle = false;
            });

            Assert.PropertyChanged(dd, "cheese", () => {
                dd.Cheese = false;
            });

            Assert.PropertyChanged(dd, "tomato", () => {
                dd.Tomato = false;
            });

            Assert.PropertyChanged(dd, "lettuce", () => {
                dd.Lettuce = false;
            });

            Assert.PropertyChanged(dd, "mayo", () => {
                dd.Mayo = false;
            });
        }
    }
}