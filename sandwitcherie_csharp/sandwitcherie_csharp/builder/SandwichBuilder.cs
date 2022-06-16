namespace sandwitcherie_csharp;

public class SandwichBuilder
{
    private string Name { get; set;}
    private List<Ingredient> Ingredients { get; set; }
    private double Price { get; set; }


    public SandwichBuilder()
    {
    }


    public SandwichBuilder WithName(string name)
    {
        Name = name;
        return this;
    }
        
    public SandwichBuilder WithIngredients(List<Ingredient> ingredients)
    {
        Ingredients = ingredients;
        return this;
    }
        
    public SandwichBuilder WithPrice(double price)
    {
        Price = price;
        return this;
    }


    public Sandwich Build()
    {
        return new Sandwich(Name, Ingredients, Price);
    }
    
}