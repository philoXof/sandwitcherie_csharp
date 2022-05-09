using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    internal class Invoice
    {

        List<Sandwich> sandwiches;
        int amount;

        public Invoice(List<Sandwich> sandwiches, int amount)
        {
            this.sandwiches = sandwiches;
            this.amount = amount;
        }
    }
}
