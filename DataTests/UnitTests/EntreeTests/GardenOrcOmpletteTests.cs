/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Broccoli = false;
            Assert.False(oo.Broccoli);
            oo.Broccoli = true;
            Assert.True(oo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Mushrooms = false;
            Assert.False(oo.Mushrooms);
            oo.Mushrooms = true;
            Assert.True(oo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Tomato = false;
            Assert.False(oo.Tomato);
            oo.Tomato = true;
            Assert.True(oo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Cheddar = false;
            Assert.False(oo.Cheddar);
            oo.Cheddar = true;
            Assert.True(oo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal(4.57, oo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal((uint) 404, oo.Calories);
        }

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

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", oo.ToString());
        }
    }
}