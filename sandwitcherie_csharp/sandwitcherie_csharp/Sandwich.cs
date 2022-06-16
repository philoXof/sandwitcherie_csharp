namespace sandwitcherie_csharp
{
    public class Sandwich
    {
        private string Name { get; set;}
        private List<Ingredient> Ingredients { get; set; }
        public double Price { get; set; }


        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }


        public override string ToString()
        {
            return
            "name : " + Name + ", \n" + "   Ingredient : \n " + ListToString(Ingredients) + " \n";
        }

        private string ListToString(List<Ingredient> ingredients)
        {
            var res = "";
            ingredients.ForEach(ingredient =>
            {
                res += "        " + ingredient;
            } );
            return res;
        }

        
        public Sandwich setName(string name)
        {
            Name = name;
            return this;
        }
        
        public Sandwich setIngredients(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
            return this;
        }
        
        public Sandwich setPrice(double price)
        {
            Price = price;
            return this;
        }
 
    }
}
