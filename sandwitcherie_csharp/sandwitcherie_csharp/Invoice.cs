using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class Invoice
    {

        List<Sandwich> sandwiches { get; set; }
        double amount { get; set; }

        public Invoice(List<Sandwich> sandwiches, double amount)
        {
            this.sandwiches = sandwiches;
            this.amount = amount;
        }





    }
}
