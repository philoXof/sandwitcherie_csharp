namespace sandwitcherie_csharp
{
    public class Ingredient
    {
        private double Quantity{ get; set; }
        private string Name { get; set; }


        public Ingredient(double quantity, string name)
        {
            Quantity = quantity;
            Name = name;
        }

        public override string ToString()
        {
            return "Quantity : " + Quantity + ", name : " + Name + "\n";
        }

        public Ingredient SetName(string name)
        {
            Name = name;
            return this;
        }
        
        public Ingredient SetQuantity(double quantity)
        {
            Quantity = quantity;
            return this;
        }
        
    }
}
