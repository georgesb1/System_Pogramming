using System;
using System.Collections.Generic;
using System.Text;
using SpriteLibrary;

namespace ProjetResto.Modèle
{
    class Chefrang
    {
        public int PosX { get; set; }

        public int PosY { get; set; }

        public Sprite Sprite { get; set; }

        public Chefrang(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }
    }
}
