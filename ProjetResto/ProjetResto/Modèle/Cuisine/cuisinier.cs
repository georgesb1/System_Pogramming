using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Cuisinier
    {
        public int position_x { get; set; }
        public int position_y { get; set; }

        //Contact information for the cook
        public Cuisinier(int position_x, int position_y)
        {
            this.position_x = position_x;
            this.position_y = position_y;
        }
    }
}
