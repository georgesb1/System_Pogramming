using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Plongeur
    {
        public int position_x { get; set; }
        public int position_y { get; set; }
        public Sprite sprite{ get; set; }

        //diver's contact information
        public Plongeur(int position_x, int position_y)
        {
            this.position_x = position_x;
            this.position_y = position_y;
        }
    }
}
