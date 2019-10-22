using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Contains<string>("Water", jurrasic.Ingredients);
            Assert.Contains<string>("Coffee", jurrasic.Ingredients);
            Assert.Equal<int>(2, jurrasic.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Equal<uint>(2, jurrasic.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, jurrasic.Size);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.roomForCream);
        }

        /// <summary>
        /// The correct price and calories after changing to small
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            jurrasic.Size = Size.Small;//change to small from meduim
            jurrasic.Size = Size.Small;
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        /// <summary>
        /// The correct price and calories after changing to medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            jurrasic.Size = Size.Medium;
            Assert.Equal<double>(0.99, jurrasic.Price);
        }

        /// <summary>
        /// The correct price and calories after changing to Large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            jurrasic.Size = Size.Large;
            Assert.Equal<double>(1.49, jurrasic.Price);
        }

        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveInvokingLeaveSpaceForCream()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.roomForCream);
        }

        ////////////////////////////////////////
        //[Fact]
        //public void DescriptionShouldBeCorrect()
        //{
        //    Brontowurst bw = new Brontowurst();
        //    Assert.Equal("Jurassic Java", bw.Description);
        //}

        //[Fact]
        //public void SpecialShouldBeEmptyByDefault()
        //{
        //    Brontowurst bw = new Brontowurst();
        //    Assert.Empty(bw.Special);
        //}

        //[Fact]
        //public void HoldBunShouldAddToSpecial()
        //{
        //    Brontowurst bw = new Brontowurst();
        //    bw.HoldBun();
        //    Assert.Collection<string>(bw.Special,
        //        item =>
        //        {
        //            Assert.Equal("Hold Whole Wheat Bread", item);
        //        });
        //}
        //[Fact]
        //public void HoldingBunShouldNotNotifySpecialChange()
        //{
        //    Brontowurst bw = new Brontowurst();

        //    Assert.PropertyChanged(bw, "Special", () =>
        //    {
        //        bw.HoldBun();
        //    });
        //}

    }

}

