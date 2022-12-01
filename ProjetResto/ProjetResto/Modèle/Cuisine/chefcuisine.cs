using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Chefcuisine
    {
        public int position_x { get; set; }
        public int position_y { get; set;}

        public Chefcuisine(int position_x, int position_y)
        {
            this.position_x = position_x;
            this.position_y = position_y;
        }
        
    }
}
