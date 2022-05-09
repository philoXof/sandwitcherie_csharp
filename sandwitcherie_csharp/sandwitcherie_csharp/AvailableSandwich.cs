using System.Data;

namespace sandwitcherie_csharp;

public class AvailableSandwich
{
    public AvailableSandwich()
    {
    }

    public Dictionary<string, Sandwich> Sandwiches { get; } = new(){
        { 
            "1", 
            new Sandwich(
                "Jambon beurre", 
                new List<Ingredient>
                {
                    new Ingredient(1,"pain"),
                    new Ingredient(1,"tranche de jambon"),
                    new Ingredient(10,"beurre")
                    
                },
                3.5) 
        },
        { 
            "2", 
            new Sandwich(
                " Poulet crudités", 
                new List<Ingredient>
                {
                    new Ingredient(1,"pain"),
                    new Ingredient(1,"oeuf"),
                    new Ingredient(0.5,"tomate"),
                    new Ingredient(1,"tranche de poulet"),
                    new Ingredient(10,"mayo"),
                    new Ingredient(10,"salade")
                },
                5) 
        },
        {
            "3", 
            new Sandwich(
                "Dieppois",
                new List<Ingredient>
                {
                    new Ingredient(1,"pain"),
                    new Ingredient(50,"thon"),
                    new Ingredient(0.5,"tomate"),
                    new Ingredient(10,"mayonnaise"),
                    new Ingredient(10,"salade")
                },
                4.50)
        }
    };

}