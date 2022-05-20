namespace sandwitcherie_csharp;

public class ConsoleMenu
{

    public void SayHello()
    {
        Console.WriteLine("Hello Subway!");
    }
    
    public void SayGoodBye()
        {
            Console.WriteLine("Goodbye Subway!");
        }
    public void WaitingCommand()
    {
        Console.WriteLine("En attente de vote commande...");
        
        
    }
    public void CommandIsEmpty()
    {
        Console.WriteLine("Entrez une commande...    (Tapez q pour quitter)");
    }


    public static void InvalidCommand()
    {
        Console.WriteLine("Command invalide");
    }
}