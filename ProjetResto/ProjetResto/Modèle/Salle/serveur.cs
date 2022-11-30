using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle
{
    class Serveur
    {
        public int PosX { get; set; }

        public int PosY { get; set; }

        public Sprite Sprite { get; set; }

        public Serveur(int posX, int posY)
        {
            this.PosX = posX;
            this.PosY = posY;
        }
    }
}
