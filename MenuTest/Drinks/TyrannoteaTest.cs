using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.Contains<string>("Water", tyra.Ingredients);
            Assert.Contains<string>("Tea", tyra.Ingredients);
            Assert.Equal<int>(2,tyra.Ingredients.Count);
        }
        [Fact]
        public void ShouldAddLemonToTyrannotea()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.AddLemon();
            Assert.True(tyra.lemon);
        }
        [Fact]
        public void ShouldAddSweetToTyrannotea()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.False(tyra.Sweet);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.Equal<double>(0.99, tyra.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.Equal<uint>(8, tyra.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.True(tyra.Ice);
        }
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tyra.Size);

        }
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.False(tyra.lemon);
        }
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.False(tyra.Sweet);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Medium;
            tyra.Size = Size.Small;
            Assert.Equal<double>(0.99, tyra.Price);
        }

        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Medium;
            Assert.Equal<double>(1.49, tyra.Price);
        }

        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Large;
            Assert.Equal<double>(1.99, tyra.Price);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Small;
            Assert.Equal<uint>(8, tyra.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Medium;
            Assert.Equal<uint>(16, tyra.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Large;
            Assert.Equal<uint>(32, tyra.Calories);
        }
        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            Tyrannotea tyra = new Tyrannotea();
            Assert.True(tyra.Ice);
        }
        [Fact]
        public void ShouldHaveInvokingAddLemon()
        {
            Tyrannotea tyra = new Tyrannotea();
            if (tyra.lemon)
            {
                Assert.True(tyra.lemon);
            }
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetSettingSmall()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Small;
            if (tyra.Sweet)
            {
                Assert.Equal<uint>(16, tyra.Calories);
            }
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetSettingMeduim()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Medium;
            if (tyra.Sweet)
            {
                Assert.Equal<uint>(32, tyra.Calories);
            }
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterAddingSweetSettingLarge()
        {
            Tyrannotea tyra = new Tyrannotea();
            tyra.Size = Size.Large;
            if (tyra.Sweet)
            {
                Assert.Equal<uint>(64, tyra.Calories);
            }
        }
    }

}

