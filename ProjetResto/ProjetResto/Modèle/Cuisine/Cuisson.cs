using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Cuisine
{
    class Cuisson
    {
        public int position_x { get; set; }
        public int position_y { get; set; }
        public Sprite sprite;
        public List<Commande> Commands;
        public bool isAvailable;

        public Cuisson(int position_x, int position_y)
        {
            this.position_x = position_x;
            this.position_y = position_y;
            isAvailable = true;
        }
    }
}
