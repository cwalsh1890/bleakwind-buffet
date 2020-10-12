/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree() {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(oo);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(oo);
        }

        /// <summary>
        /// Tests to ensure that broccoli is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Broccoli);
        }

        /// <summary>
        /// Tests to ensure that mushrooms is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Mushrooms);
        }

        /// <summary>
        /// Tests to ensure that tomato is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Tomato);
        }

        /// <summary>
        /// Tests to ensure that cheddar is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Cheddar);
        }

        /// <summary>
        /// Test to ensure that the broccoli property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Broccoli = false;
            Assert.False(oo.Broccoli);
            oo.Broccoli = true;
            Assert.True(oo.Broccoli);
        }

        /// <summary>
        /// Test to ensure that the mushrooms property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Mushrooms = false;
            Assert.False(oo.Mushrooms);
            oo.Mushrooms = true;
            Assert.True(oo.Mushrooms);
        }

        /// <summary>
        /// Test to ensure that the tomato property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Tomato = false;
            Assert.False(oo.Tomato);
            oo.Tomato = true;
            Assert.True(oo.Tomato);
        }

        /// <summary>
        /// Test to ensure that the cheddar property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Cheddar = false;
            Assert.False(oo.Cheddar);
            oo.Cheddar = true;
            Assert.True(oo.Cheddar);
        }

        /// <summary>
        /// Tests to ensure that the entree returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal(4.57, oo.Price);
        }

        /// <summary>
        /// tests to ensure that the entree returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal((uint) 404, oo.Calories);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are correct
        /// </summary>
        /// <param name="includeBroccoli">Whether or not the omlette should have broccoli</param>
        /// <param name="includeMushrooms">Whether or not the omlette should have mushrooms</param>
        /// <param name="includeTomato">Whether or not the omlette should have tomato</param>
        /// <param name="includeCheddar">Whether or not the omlette should have cheddar</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Broccoli = includeBroccoli;
            oo.Mushrooms = includeMushrooms;
            oo.Tomato = includeTomato;
            oo.Cheddar = includeCheddar;

            if (includeBroccoli)
                Assert.DoesNotContain("Hold broccoli", oo.SpecialInstructions);
            else
                Assert.Contains("Hold broccoli", oo.SpecialInstructions);

            if (includeMushrooms)
                Assert.DoesNotContain("Hold mushrooms", oo.SpecialInstructions);
            else
                Assert.Contains("Hold mushrooms", oo.SpecialInstructions);

            if (includeTomato)
                Assert.DoesNotContain("Hold tomato", oo.SpecialInstructions);
            else
                Assert.Contains("Hold tomato", oo.SpecialInstructions);

            if (includeCheddar)
                Assert.DoesNotContain("Hold cheddar", oo.SpecialInstructions);
            else
                Assert.Contains("Hold cheddar", oo.SpecialInstructions);
        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", oo.ToString());
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.PropertyChanged(oo, "Broccoli", () => {
                oo.Broccoli = false;
            });

            Assert.PropertyChanged(oo, "SpecialInstructions", () => {
                oo.Broccoli = true;
            });

            Assert.PropertyChanged(oo, "Tomato", () => {
                oo.Tomato = false;
            });

            Assert.PropertyChanged(oo, "SpecialInstructions", () => {
                oo.Tomato = true;
            });

            Assert.PropertyChanged(oo, "Mushrooms", () => {
                oo.Mushrooms = false;
            });

            Assert.PropertyChanged(oo, "SpecialInstructions", () => {
                oo.Mushrooms = true;
            });

            Assert.PropertyChanged(oo, "Cheddar", () => {
                oo.Cheddar = false;
            });

            Assert.PropertyChanged(oo, "SpecialInstructions", () => {
                oo.Cheddar = true;
            });
        }
    }
}