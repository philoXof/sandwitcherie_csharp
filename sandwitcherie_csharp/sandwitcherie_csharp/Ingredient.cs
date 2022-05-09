using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    class Ingredient
    {
        private double quantity;

        private string name;

        public Ingredient(double quantity, string name)
        {
            this.quantity = quantity;
            this.name = name;
        }

        public double Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }



    }
}
