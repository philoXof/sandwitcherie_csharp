namespace sandwitcherie_csharp
{
    public class Sandwich
    {
        private string Name { get; }
        private List<Ingredient> Ingredients { get; }
        private double Price { get; }


        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }


        public override string ToString()
        {
            return
            "{ \n"+
            "name : " + Name + ", \n" +
                "{ \n" +
                    "Ingredient : " + listToString(Ingredients) + " \n" +
                "}, \n" +
            "}\n" + Price;
        }

        private string listToString(List<Ingredient> ingredients)
        {
            var res = "";
            ingredients.ForEach(ingredient =>
            {
                res += ingredient.ToString();
            } );
            return res;
        }
    }
}
