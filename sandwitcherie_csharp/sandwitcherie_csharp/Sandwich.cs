﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwitcherie_csharp
{
    class Sandwich
    {
        private string name;
        private List<Ingredient> ingredients;
        private double price;

        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
        }






    }
}
