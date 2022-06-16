namespace sandwitcherie_csharp;

public class IngredientBuilder
{
    private double Quantity{ get; set; }
    private string Name { get; set; }

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