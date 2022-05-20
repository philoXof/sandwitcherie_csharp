namespace sandwitcherie_csharp
{
    public class Sandwich
    {
        private string Name { get; }
        private List<Ingredient> Ingredients { get; }
        public double Price { get; }


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
    }
}
