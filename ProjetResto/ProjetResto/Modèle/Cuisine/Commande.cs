using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Cuisine
{
    class Commande
    {
        public List<string> Plats { get; set; }

        public Commande()
        {
            Plats = new List<string>();  
        }
    }
}
