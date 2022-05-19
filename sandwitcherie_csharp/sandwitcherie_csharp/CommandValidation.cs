namespace sandwitcherie_csharp;

public class CommandValidation
{

    
    
    private Boolean InputVerification(string command)
    {
        return command.Contains("Sandwich");
    }
    
    // ASCII lettres majuscule 65 à 90
     private Boolean OrderVerification(string[] command)
     {
         for (int i = 0, j = 65; i < command.Length; i++, j++)
         {
             if (j > 90) return false;
             if ((int)command[i][0] != j) return false;
         }
         return true;
     }

     private Boolean SandwichExist(string sandwich)
     {
         // TODO : prendre en compte de chiffre
         
         var availableSandwich = new AvailableSandwich();
         
         
         
         return availableSandwich.Sandwiches.ContainsKey(sandwich[^1].ToString());
     }
    

    public Boolean IsValid(string[] command)
    {
        if (!OrderVerification(command)) return false;
        
        foreach (var sandwich in command)
        {
            if (!(InputVerification(sandwich) && SandwichExist(sandwich))) return false;
        }
        return true;
    }
}