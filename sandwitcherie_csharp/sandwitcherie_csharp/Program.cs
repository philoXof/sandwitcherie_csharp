// See https://aka.ms/new-console-template for more information

using sandwitcherie_csharp;

var availableSandwich = new AvailableSandwich();
var command = "";
Console.WriteLine("Hello Subway!");

while (command != "q")
{
    Console.WriteLine("En attente de vote commande...");
    command = Console.ReadLine();
    if (!availableSandwich.Sandwiches.ContainsKey(command) && command != "q")
    {
        Console.WriteLine(command + " est invalid");  
    }else if (command != "q")
    {
        Console.WriteLine( availableSandwich.Sandwiches[command].ToString());
    }
    
}
Console.WriteLine("Goodbye Subway!");


/*
 * Après avoir interprété la commande en entrée, vous produirez une sortie console suivant la forme
suivante :
    A Sandwich1
        Ingredient1
        Ingredient2
        [...]
        IngredientN
    B Sandwich2
        Ingredient1
        [...]
        [...]
    Prix total : XXX€
*/


