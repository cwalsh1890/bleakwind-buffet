﻿/*
 * Author: Zachery Brunner
 * Edited by: Coby Walsh
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        /// <summary>
        /// tests to ensure that the entree is inheriting the Entree class
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree() {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
        }

        /// <summary>
		/// ensure that the Entree is implementing the IOrderItem interface
		/// </summary>
		[Fact]
        public void ShouldBeAnIOrderItem() {
            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }

        /// <summary>
        /// Tests to ensure that the burger returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        /// <summary>
        /// tests to ensure that the burger returns the correct amount of calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal((uint) 982, tb.Calories);
        }

        /// <summary>
        /// ensures that the steak has the correct special instructions
        /// </summary>
        /// <remarks>There is no intended way for anything to be added to special instructions</remarks>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        /// <summary>
        /// ensures that the ToString method is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tb.ToString());
        }
    }
}