using System;
using System.Collections.Generic;
using System.Text;
using SpriteLibrary;

namespace ProjetResto.Modèle
{
    class Maitredhotel
    {

        public int PosX { get; set; }

        public int PosY { get; set; }

        public Sprite Sprite { get; set; }

        public Maitredhotel(int posX, int posY )
        {
            this.PosX = posX;
            this.PosY = posY;
        }
    }
}
