/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAEntree() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        /// <summary>
        /// Tests to ensure that sausagelink is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        /// <summary>
        /// Tests to ensure that egg is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        /// <summary>
        /// Tests to ensure that hashBrowns is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        /// <summary>
        /// Tests to ensure that pancake is initialized to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        /// <summary>
        /// Test to ensure that the sausage property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        /// <summary>
        /// Test to ensure that the egg property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        /// <summary>
        /// Test to ensure that the hashBrowns property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        /// <summary>
        /// Test to ensure that the pancake property can be properly set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        /// <summary>
        /// Tests to ensure that the burger returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        /// <summary>
        /// tests to ensure that the burger returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint) 602, ss.Calories);
        }

        /// <summary>
        /// Tests to ensure that the special instructions are correct
        /// </summary>
        /// <param name="includeSausage">Whether or not the plate should have sausage</param>
        /// <param name="includeEgg">Whether or not the plate should have egg</param>
        /// <param name="includeHashbrowns">Whether or not the plate should have hash browns</param>
        /// <param name="includePancake">Whether or not the plate should have pancake</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;

            if (includeSausage)
                Assert.DoesNotContain("Hold sausage", ss.SpecialInstructions);
            else
                Assert.Contains("Hold sausage", ss.SpecialInstructions);

            if (includeEgg)
                Assert.DoesNotContain("Hold eggs", ss.SpecialInstructions);
            else
                Assert.Contains("Hold eggs", ss.SpecialInstructions);

            if (includeHashbrowns)
                Assert.DoesNotContain("Hold hash browns", ss.SpecialInstructions);
            else
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);

            if (includePancake)
                Assert.DoesNotContain("Hold pancakes", ss.SpecialInstructions);
            else
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }

        [Fact]
        public void ShouldNotifyPropertyChanged() {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, "sausage", () => {
                ss.SausageLink = false;
            });

            Assert.PropertyChanged(ss, "pancake", () => {
                ss.Pancake = false;
            });

            Assert.PropertyChanged(ss, "hash brown", () => {
                ss.HashBrowns = false;
            });

            Assert.PropertyChanged(ss, "egg", () => {
                ss.Egg = false;
            });
        }
    }
}