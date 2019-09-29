using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
       

        /// <summary>
        /// The correct price and calories after changing to small, medium, and large sizes.
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tryanno = new Tyrannotea();
            //tryanno.Size = Size.Medium;
            tryanno.Size = Size.Small;
            Assert.Equal<double>(0.99, tryanno.Price);
        }
        /// <summary>
        /// The correct price and calories after changing to medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tryanno = new Tyrannotea();
            tryanno.Size = Size.Medium;
            Assert.Equal<double>(1.49, tryanno.Price);
        }

        /// <summary>
        /// The correct price and calories after changing to medium
        /// </summary>
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tryanno = new Tyrannotea();
            tryanno.Size = Size.Large;
            Assert.Equal<double>(1.99, tryanno.Price);
        }
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tryanno = new Tyrannotea();
            Assert.False(tryanno.lemon);
        }
        [Fact]
        public void ShouldChangeCaloriesAfterSetSweetToSmall()
        {
            Tyrannotea tryanno = new Tyrannotea();
            Assert.True(tryanno.sweet);
            tryanno.Size = Size.Small;
            Assert.Equal<uint>(16, tryanno.Calories);
        }

        [Fact]
        public void ShouldChangeCaloriesAfterSetSweetToSMedium()
        {
            Tyrannotea tryanno = new Tyrannotea();
            Assert.True(tryanno.sweet);
            tryanno.Size = Size.Medium;
            Assert.Equal<uint>(32, tryanno.Calories);

        }
        [Fact]
        public void ShouldChangeCaloriesAfterSetSweetToLarge()
        {
            Tyrannotea tryanno = new Tyrannotea();
            tryanno.Size = Size.Large;
            Assert.True(tryanno.sweet);
            Assert.Equal<uint>(64, tryanno.Calories);
        }
    }

}

