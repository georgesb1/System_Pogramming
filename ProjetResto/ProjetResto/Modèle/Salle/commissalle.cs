using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Commissalle
    {
        public int Position_X { get; set; }

        public int Position_Y { get; set; }

        public Sprite Sprite { get; set; }

        public Commissalle(int position_X, int position_Y)
        {
            this.Position_X = position_X;
            this.Position_Y = position_Y;
        }
    }
}
