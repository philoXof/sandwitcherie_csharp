using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class Invoice
    {
        private List<Sandwich> Sandwiches { get; set; }
        private double Amount { get; set; }

        public Invoice(List<Sandwich> sandwiches)
        {
            this.Sandwiches = sandwiches;
            CalculAmount();
        }
        
        private void CalculAmount()
        {
            Sandwiches.ForEach(sandwich => this.Amount += sandwich.Price);
        }



        public void Generate(string[] command)
        {
            foreach (var sandwich in command)
            {
                var sandwichId = new String(sandwich.Where(Char.IsDigit).ToArray());

                var availableSandwich = new AvailableSandwich();

                Console.WriteLine(availableSandwich.Sandwiches[sandwichId]);
                Console.WriteLine($"Prix de la facture : {Amount}");
            }
        }

        
    }
}
