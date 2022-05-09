

namespace sandwitcherie_csharp
{
    public class Ingredient
    {
        private double quantity{ get; set; }

        private string name{ get; set; }

        public Ingredient(double quantity, string name)
        {
            this.quantity = quantity;
            this.name = name;
        }

       
    }
}
