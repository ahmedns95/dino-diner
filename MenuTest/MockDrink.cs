using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace MenuTest
{
    public class MockDrink : Drink
    {
        public MockDrink(double drink)
        {
            Price = drink;
        }
    }
}
