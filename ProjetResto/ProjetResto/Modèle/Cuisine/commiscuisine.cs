using ProjetResto.Modèle.Cuisine;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Commiscuisine
    {
        public Stock stock;
        public int position_x { get; set; }
        public int position_y { get; set; }

        public Commiscuisine()
        {
            this.stock = new Stock();
        }

        //Contact information for the kitchen clerk
        public Commiscuisine(int position_x, int position_y)
        {
            this.position_x = position_x;
            this.position_y = position_y;
        }
    }
}
