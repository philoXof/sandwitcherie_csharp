using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    class Sandwich
    {
        String name;
        List<Ingredient> ingredients;
        int price;

        public Sandwich(String name, List<Ingredient> ingredients, int price)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
        }




    }
}
