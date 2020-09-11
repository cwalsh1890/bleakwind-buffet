/*
 * Author: Coby Walsh
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.Menu_Tests {
    public class MenuTests {
        [Fact]
        public void TestEntreesMethod() {
            List<IOrderItem> list = Menu.Entrees();
            Assert.Contains(new BriarheartBurger(), list);
            Assert.Contains(new DoubleDraugr(), list);
            Assert.Contains(new GardenOrcOmelette(), list);
            Assert.Contains(new PhillyPoacher(), list);
            Assert.Contains(new SmokehouseSkeleton(), list);
            Assert.Contains(new ThalmorTriple(), list);
            Assert.Contains(new ThugsTBone(), list);
        }

        [Fact]
        public void TestDrinksMethod() {
            List<IOrderItem> list = Menu.Drinks();

            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.Contains(aj, list);
            aj.Size = Size.Medium;
            Assert.Contains(aj, list);
            aj.Size = Size.Large;
            Assert.Contains(aj, list);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Contains(cc, list);
            cc.Size = Size.Medium;
            Assert.Contains(cc, list);
            cc.Size = Size.Large;
            Assert.Contains(cc, list);

            MarkarthMilk mm = new MarkarthMilk();
            Assert.Contains(mm, list);
            mm.Size = Size.Medium;
            Assert.Contains(mm, list);
            mm.Size = Size.Large;
            Assert.Contains(mm, list);

            WarriorWater ww = new WarriorWater();
            Assert.Contains(ww, list);
            ww.Size = Size.Medium;
            Assert.Contains(ww, list);
            ww.Size = Size.Large;
            Assert.Contains(ww, list);

            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Contains(ss, list);

            ss.Size = Size.Medium;
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Contains(ss, list);

            ss.Size = Size.Large;
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Contains(ss, list);
        }

        [Fact]
        public void TestSidesMethod() {
            List<IOrderItem> list = Menu.Sides();
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Contains(wf, list);
            wf.Size = Size.Medium;
            Assert.Contains(wf, list);
            wf.Size = Size.Large;
            Assert.Contains(wf, list);

            FriedMiraak fm = new FriedMiraak();
            Assert.Contains(fm, list);
            fm.Size = Size.Medium;
            Assert.Contains(fm, list);
            fm.Size = Size.Large;
            Assert.Contains(fm, list);

            MadOtarGrits og = new MadOtarGrits();
            Assert.Contains(og, list);
            og.Size = Size.Medium;
            Assert.Contains(og, list);
            og.Size = Size.Large;
            Assert.Contains(og, list);

            VokunSalad vs = new VokunSalad();
            Assert.Contains(vs, list);
            vs.Size = Size.Medium;
            Assert.Contains(vs, list);
            vs.Size = Size.Large;
            Assert.Contains(vs, list);
        }

        [Fact]
        public void TestFullMenuMethod() {
            List<IOrderItem> list = Menu.FullMenu();
            //food
            Assert.Contains(new BriarheartBurger(), list);
            Assert.Contains(new DoubleDraugr(), list);
            Assert.Contains(new GardenOrcOmelette(), list);
            Assert.Contains(new PhillyPoacher(), list);
            Assert.Contains(new SmokehouseSkeleton(), list);
            Assert.Contains(new ThalmorTriple(), list);
            Assert.Contains(new ThugsTBone(), list);

            //drinks
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.Contains(aj, list);
            aj.Size = Size.Medium;
            Assert.Contains(aj, list);
            aj.Size = Size.Large;
            Assert.Contains(aj, list);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Contains(cc, list);
            cc.Size = Size.Medium;
            Assert.Contains(cc, list);
            cc.Size = Size.Large;
            Assert.Contains(cc, list);

            MarkarthMilk mm = new MarkarthMilk();
            Assert.Contains(mm, list);
            mm.Size = Size.Medium;
            Assert.Contains(mm, list);
            mm.Size = Size.Large;
            Assert.Contains(mm, list);

            WarriorWater ww = new WarriorWater();
            Assert.Contains(ww, list);
            ww.Size = Size.Medium;
            Assert.Contains(ww, list);
            ww.Size = Size.Large;
            Assert.Contains(ww, list);

            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Contains(ss, list);

            ss.Size = Size.Medium;
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Contains(ss, list);

            ss.Size = Size.Large;
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Contains(ss, list);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Contains(ss, list);

            //sides
            DragonbornWaffleFries wf = new DragonbornWaffleFries();
            Assert.Contains(wf, list);
            wf.Size = Size.Medium;
            Assert.Contains(wf, list);
            wf.Size = Size.Large;
            Assert.Contains(wf, list);

            FriedMiraak fm = new FriedMiraak();
            Assert.Contains(fm, list);
            fm.Size = Size.Medium;
            Assert.Contains(fm, list);
            fm.Size = Size.Large;
            Assert.Contains(fm, list);

            MadOtarGrits og = new MadOtarGrits();
            Assert.Contains(og, list);
            og.Size = Size.Medium;
            Assert.Contains(og, list);
            og.Size = Size.Large;
            Assert.Contains(og, list);

            VokunSalad vs = new VokunSalad();
            Assert.Contains(vs, list);
            vs.Size = Size.Medium;
            Assert.Contains(vs, list);
            vs.Size = Size.Large;
            Assert.Contains(vs, list);
        }
	}
}