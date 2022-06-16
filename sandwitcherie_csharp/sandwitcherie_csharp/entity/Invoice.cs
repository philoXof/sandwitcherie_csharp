using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal static class Invoice
    {
        
        private static readonly SandwichParser sandwichParser = new SandwichParser();
        
        
        private static double CalculAmount(List<Sandwich> sandwiches)
        {
            double amount = 0;
            sandwiches.ForEach(sandwich => amount += sandwich.Price);
            return amount;
        }



        public static void Generate(string[] command)
        {
            var sandwiches = new List<Sandwich>();
            foreach (var sandwich in command)
            {
                var sandwichId = sandwichParser.GetSandwichId(sandwich);
                sandwiches.Add(AvailableSandwich.IdToSandwich(sandwichId));
                Console.WriteLine(AvailableSandwich.Sandwiches[sandwichId]);
            }
            
            Console.WriteLine($"Prix de la facture : {CalculAmount(sandwiches)}");
            
        }

        
    }
}
