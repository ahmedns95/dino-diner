using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        /// <summary>
        /// The correct price and calories after changing to small
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }
        /// <summary>
        /// The correct price and calories after changing to medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// The correct price and calories after changing to Large
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            Water water = new Water();
            Assert.False(water.ice);
        }

        [Fact]
        public void ShouldHaveInvokingAddLemon()
        {
            Water water = new Water();
            Assert.False(water.lemon);
        }

    }

}

