using System;
using System.Collections.Generic;
using System.Text;
using SpriteLibrary;

namespace ProjetResto.Modèle
{
    class Chefrang
    {
        public int Position_x { get; set; }

        public int Position_y { get; set; }

        public Sprite Sprite { get; set; }

        public Chefrang(int position_x, int position_y)

        {
            this.Position_x = position_x;
            this.Position_y = position_y;
        }
    }
}
