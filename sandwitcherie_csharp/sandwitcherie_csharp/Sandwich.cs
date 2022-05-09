using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    public class Sandwich
    {
        private string name { get; set; }
        private List<Ingredient> ingredients{ get; set; }
        private double price{ get; set; }

        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
        }

        public override string ToString()
        {
            return
            "{ \n"+
            "name : " + name + ", \n" +
                "{ \n" +
                    "ingredients : " + ingredients.ToString() + " \n" +
                "}, \n" +
            "}\n";
        }
        
    }
}
