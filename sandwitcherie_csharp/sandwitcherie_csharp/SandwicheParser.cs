using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class SandwichParser : Parser
    { 
        public string[] Parse(string value)
        {
            var sandwichTab = value.Split(',');
            
            for (var i = 0; i < sandwichTab.Length; i++)
            {
                sandwichTab[i] = sandwichTab[i].Trim();
            }

            return sandwichTab;
        }


        // TODO : Déplacer la fonction dans une autre classe ?
        public string GetSandwichId(string sandwich)
        {
            return new String(sandwich.Where(Char.IsDigit).ToArray());
        }
        
    }
    
}


