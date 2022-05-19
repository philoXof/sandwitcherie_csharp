// See https://aka.ms/new-console-template for more information

using sandwitcherie_csharp;


// A Sandwich1, B Sandwich2, C Sandwich1

Console.WriteLine("Hello Subway!");

var command = "";
var parser = new Parser();
var commandValidation = new CommandValidation();


while (command != "q")
{
    Console.WriteLine("En attente de vote commande...");
    command = Console.ReadLine();

    while (command == "")
    {
        Console.WriteLine("Entrez une commande...    (Tapez q pour quitter)");
        command = Console.ReadLine();
    }

    if(command != "q")
    {
        var commandParsed = Parser.Parse(command);


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


