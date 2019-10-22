using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest
{
    public class OrderTest :Order
    {
        [Theory]
        [InlineData(5)]
        public void PriceShouldBeASum(double price)
        {
            CretaceousCombo cc = new CretaceousCombo(new MockEntree(price));
            cc.Side = new MockSide(cc.Price);
            cc.Drink = new MockDrink(cc.Price);
            Assert.Equal(5, cc.Price);

        }
    }
}
