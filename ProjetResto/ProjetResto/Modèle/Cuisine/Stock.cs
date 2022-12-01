using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Cuisine
{
    class Stock
    {
        private List<string> Ingredients = new List<string>();
            public Stock()
        {
            Ingredients.Add("cube");
            Ingredients.Add("sel");
            Ingredients.Add("oignon");
            Ingredients.Add("persil");
            Ingredients.Add("rondelle");
            Ingredients.Add("piment");
            Ingredients.Add("pepper");
            Ingredients.Add("tomate");
            Ingredients.Add("concombre");
            Ingredients.Add("pain rassi");
            Ingredients.Add("champignon");

        }
    }
}
