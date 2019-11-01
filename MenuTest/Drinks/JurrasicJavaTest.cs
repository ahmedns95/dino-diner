using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Contains<string>("Water", jurrasic.Ingredients);
            Assert.Contains<string>("Coffee", jurrasic.Ingredients);
            Assert.Equal<int>(2, jurrasic.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Equal<uint>(2, jurrasic.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jurrasic.Size);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.roomForCream);
        }

        /// <summary>
        /// The correct price and calories after changing to small
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            JurassicJava jurrasic = new JurassicJava();
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
            JurassicJava jurrasic = new JurassicJava();
            jurrasic.Size = Size.Medium;
            Assert.Equal<double>(0.99, jurrasic.Price);
        }

        /// <summary>
        /// The correct price and calories after changing to Large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            JurassicJava jurrasic = new JurassicJava();
            jurrasic.Size = Size.Large;
            Assert.Equal<double>(1.49, jurrasic.Price);
        }

        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveInvokingLeaveSpaceForCream()
        {
            JurassicJava jurrasic = new JurassicJava();
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

