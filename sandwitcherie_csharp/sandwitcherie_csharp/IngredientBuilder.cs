namespace sandwitcherie_csharp;

public class IngredientBuilder
{
    private double Quantity{ get; set; }
    private string Name { get; set; }

    public IngredientBuilder(double quantity, string name)
    {
        Quantity = quantity;
        Name = name;
    }

    public IngredientBuilder WithQuantity(double quantity)
    {
        Quantity = quantity;
        return this;
    }
    
    public IngredientBuilder WithName(string name)
    {
        Name = name;
        return this;
    }

    public Ingredient Build()
    {
        return new Ingredient(Quantity, Name);
    }
}