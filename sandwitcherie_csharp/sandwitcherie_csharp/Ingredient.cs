using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class Ingredient
    {
        int quantity;

        String name;

        public Ingredient(int quantity, string name)
        {
            this.quantity = quantity;
            this.name = name;
        }

    }
}
