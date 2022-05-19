using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class Parser
    {
        public string[] Parse(string value)
        {
            string[] sandwichTab = value.Split(',');
            
            for (int i = 0; i < sandwichTab.Length; i++)
            {
                sandwichTab[i] = sandwichTab[i].Trim();

                
                Console.WriteLine($"{sandwichTab[i]}");
            }

            return sandwichTab;
        }
        
    }
    
}


