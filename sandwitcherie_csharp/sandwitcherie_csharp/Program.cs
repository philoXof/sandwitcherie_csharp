// See https://aka.ms/new-console-template for more information

using sandwitcherie_csharp;

var availableSandwich = new AvailableSandwich();
var command = "";
Console.WriteLine("Hello Subway!");


// A Sandwich1, B Sandwich2, C Sandwich1
var parser = new Parser();
var commandValidation = new CommandValidation();




while (command != "q")
{
    Console.WriteLine("En attente de vote commande...");
    command = Console.ReadLine();

    while (command == "")
    {
        command = Console.ReadLine();
    }

    if(command != "q")
    {
        var commandParsed = parser.Parse(command);


        Console.WriteLine(commandValidation.IsValid(commandParsed));
        
        /*
        {
            Console.WriteLine(command + " est invalid");
        }
        else if (command != "q")
        {
            Console.WriteLine(availableSandwich.Sandwiches[command].ToString());
        }
        */
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


