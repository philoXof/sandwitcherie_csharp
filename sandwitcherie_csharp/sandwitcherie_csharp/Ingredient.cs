namespace sandwitcherie_csharp
{
    public class Ingredient
    {
        private double Quantity{ get; }
        private string Name{ get; }


        public Ingredient(double quantity, string name)
        {
            Quantity = quantity;
            Name = name;
        }

        public override string ToString()
        {
            return "Quantity : " + Quantity + ", name" + Name;
        }
    }
}
