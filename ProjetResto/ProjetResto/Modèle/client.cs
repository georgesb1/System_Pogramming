using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Client
    {

        public int Position_x { get; set; }

        public int Position_y { get; set; }

        public Sprite Sprite { get; set; }

        public Client(int position_x, int position_y)
        {
            this.Position_x = position_x;
            this.Position_y = position_y;
        }
    }
}
