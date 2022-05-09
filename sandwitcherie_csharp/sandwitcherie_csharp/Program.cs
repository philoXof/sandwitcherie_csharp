// See https://aka.ms/new-console-template for more information

using sandwitcherie_csharp;

var availableSandwich = new AvailableSandwich();
var command = "";
Console.WriteLine("Hello Subway!");

while (command != null && command != "q")
{
    command = Console.ReadLine();
    //todo : verifier que le sandwich est present dans la map
    if (command != "q")
    {
        Console.WriteLine( availableSandwich.Sandwiches[command].ToString());
            Console.WriteLine(command);
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

