using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class Parser
    {
        public static string[] Parse(string value)
        {
            var sandwichTab = value.Split(',');
            
            for (var i = 0; i < sandwichTab.Length; i++)
            {
                sandwichTab[i] = sandwichTab[i].Trim();
                
                Console.WriteLine($"{sandwichTab[i]}");
            }

            return sandwichTab;
        }
        
    }
    
}


