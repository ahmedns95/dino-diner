using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pw.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();
            Assert.Empty(pw.Special);
        }

        [Fact]
        public void HoldPeanutButterShouldAddToSpecial()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();
            pw.HoldPeanutButter();
            Assert.Collection<string>(pw.Special,
                item =>
                {
                    Assert.Equal("Hold Peanut Butter", item);
                });
        }
        [Fact]
        public void HoldJellyShouldAddToSpecial()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();
            pw.HoldJelly();
            Assert.Collection<string>(pw.Special,
                item =>
                {
                    Assert.Equal("Hold Jelly", item);
                });
        }
        [Fact]
        public void HoldPeanutButterAndJellyShouldAddToSpecial()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();
            pw.HoldPeanutButter();
            pw.HoldJelly();
            Assert.Collection<string>(pw.Special,
                item =>
                {
                    Assert.Equal("Hold Peanut Butter", item);
                    
                },
                item =>
                {
                    Assert.Equal("Hold Jelly", item);
                });
        }

        [Fact]
        public void HoldingPeanutButterShouldNotNotifySpecialChange()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();

            Assert.PropertyChanged(pw, "Special", () =>
              {
                  pw.HoldPeanutButter();
              });
        }

        [Fact]
        public void HoldingJellyShouldNotNotifySpecialChange()
        {
            PrehistoricPBJ pw = new PrehistoricPBJ();
            Assert.PropertyChanged(pw, "Special", () =>
            {
                pw.HoldJelly();
            });
        }
        //anything changes the price and claories
    }

}
