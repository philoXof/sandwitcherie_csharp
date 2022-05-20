namespace sandwitcherie_csharp;

public class CommandValidation
{
    private static readonly Parser Parser = new Parser();
    private static readonly AvailableSandwich AvailableSandwich = new AvailableSandwich();
    private static bool InputVerification(string command)
    {
        return command.Contains("Sandwich");
    }
    
    
    // A Sandwich1, B Sandwich2, C Sandwich1
    
    // ASCII lettres majuscule 65 à 90
     private static bool OrderVerification(string[] command)
     {
         for (int i = 0, j = 65; i < command.Length; i++, j++)
         {
             if (j > 90) return false;
             if ((int)command[i][0] != j) return false;
         }
         return true;
     }

     private static bool NumberOnlyAtEnd(string sandwich)
     {
         var checking = sandwich[..9];
         return new string(checking.Where(char.IsDigit).ToArray()) == "";
     }
     
     
     private static bool SandwichExist(string sandwich)
     {
         var sandwichId = Parser.GetSandwichId(sandwich);
         return AvailableSandwich.Sandwiches.ContainsKey(sandwichId);
     }
    

    public static bool IsValid(string[] command)
    {
        if (!OrderVerification(command)) return false;
        
        foreach (var sandwich in command)
        {
            if (!NumberOnlyAtEnd(sandwich)) return false;
            if (!(InputVerification(sandwich) && SandwichExist(sandwich))) return false;
        }
        return true;
    }
}