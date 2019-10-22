using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace MenuTest
{
    public class MockSide : Side
    {
        public MockSide(double side)
        {
            Price = side;
        }
    }
}
