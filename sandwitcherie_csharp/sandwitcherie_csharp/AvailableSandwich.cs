using System.Data;

namespace sandwitcherie_csharp;

public class AvailableSandwich
{
    public AvailableSandwich()
    {
    }

    public static Dictionary<string, Sandwich> Sandwiches { get; } = new(){
        { 
            "1", 
            new SandwichBuilder()
                .WithIngredients(
                    new List<Ingredient>
                    {
                        new IngredientBuilder()
                            .WithQuantity(1)
                            .WithName("pain")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(1)
                            .WithName("tranche de jambon")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(10)
                            .WithName("beurre")
                            .Build()
                    })
                .WithName("Jambon beurre")
                .WithPrice(3.5)
                .Build()
        },
        { 
            "2", 
            new SandwichBuilder()
                .WithName("Poulet crudités")
                .WithIngredients(
                    new List<Ingredient>
                    {
                        new IngredientBuilder()
                            .WithQuantity(1)
                            .WithName("pain")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(1)
                            .WithName("oeuf")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(0.5)
                            .WithName("tomate")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(1)
                            .WithName("tranche de poulet")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(10)
                            .WithName("mayo")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(10)
                            .WithName("salade")
                            .Build()
                    })
                .WithPrice(5)
                .Build()
        },
        {
            "3", 
            new SandwichBuilder()
                .WithName("Dieppois")
                .WithIngredients(
                    new List<Ingredient>
                    {
                        new IngredientBuilder()
                            .WithQuantity(1)
                            .WithName("pain")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(50)
                            .WithName("thom")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(0.5)
                            .WithName("tomate")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(10)
                            .WithName("mayo")
                            .Build(),
                        new IngredientBuilder()
                            .WithQuantity(10)
                            .WithName("salade")
                            .Build()
                    })
                .WithPrice(4.5)
                .Build()
        }
    };

    public static Sandwich IdToSandwich(string id)
    {
        return Sandwiches[id];
    }

}