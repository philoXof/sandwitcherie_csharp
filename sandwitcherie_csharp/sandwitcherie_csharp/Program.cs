// See https://aka.ms/new-console-template for more information

using sandwitcherie_csharp;


// A Sandwich1, B Sandwich2, C Sandwich1

var consoleMenu = new ConsoleMenu();
consoleMenu.SayHello();

var command = "";
var parser = new Parser();


while (command != "q")
{
    consoleMenu.WaitingCommand();
    command = Console.ReadLine();

    while (string.IsNullOrEmpty(command))
    {
        consoleMenu.CommandIsEmpty();
        command = Console.ReadLine();
    }

    if(command != "q")
    {
        var commandParsed = parser.Parse(command);
        if (CommandValidation.IsValid(commandParsed))
        {
            Invoice.Generate(commandParsed);
        }
        else
        {
            ConsoleMenu.InvalidCommand();
        } 
    }
    
}
consoleMenu.SayGoodBye();
