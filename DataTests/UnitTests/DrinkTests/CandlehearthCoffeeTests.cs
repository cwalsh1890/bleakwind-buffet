/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.False(cf.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.False(cf.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.False(cf.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Ice = true;
            Assert.True(cf.Ice);
            cf.Ice = false;
            Assert.False(cf.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Decaf = true;
            Assert.True(cf.Decaf);
            cf.Decaf = false;
            Assert.False(cf.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.RoomForCream = true;
            Assert.True(cf.RoomForCream);
            cf.RoomForCream = false;
            Assert.False(cf.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = Size.Large;
            Assert.Equal(Size.Large, cf.Size);
            cf.Size = Size.Medium;
            Assert.Equal(Size.Medium, cf.Size);
            cf.Size = Size.Small;
            Assert.Equal(Size.Small, cf.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = size;
            Assert.Equal(price, cf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = size;
            Assert.Equal(cal, cf.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Ice = includeIce;
            cf.RoomForCream = includeCream;
            if (includeCream)
                Assert.Contains("Add cream", cf.SpecialInstructions);
            if (includeIce)
                Assert.Contains("Add ice", cf.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cf = new CandlehearthCoffee();
            cf.Size = size;
            cf.Decaf = decaf;
            Assert.Equal(name, cf.ToString());
        }
    }
}
