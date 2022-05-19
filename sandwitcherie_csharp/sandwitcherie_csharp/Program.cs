// See https://aka.ms/new-console-template for more information

using sandwitcherie_csharp;


// A Sandwich1, B Sandwich2, C Sandwich1
var consoleMenu = new ConsoleMenu();
consoleMenu.SayHello();

var command = "";
var parser = new Parser();
var commandValidation = new CommandValidation();


while (command != "q")
{
    consoleMenu.WaitingCommand();
    command = Console.ReadLine();

    while (command == "")
    {
        consoleMenu.CommandIsEmpty();
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
consoleMenu.SayGoodBye();



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


