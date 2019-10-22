using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
namespace MenuTest
{
    public class MockEntree :Entree
    {
        public MockEntree(double entree)
        {
            Price = entree;
        }
    }
}
