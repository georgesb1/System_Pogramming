using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Cuisine
{
    class Gestion_cuisine
    {
        public Cuisinier cuisinier;
        public List<Cuisson> cuissons;
        public Plongeur plongeur;
        public List<Commande> commande;

        public Gestion_cuisine()
        {
            cuissons = new List<Cuisson>();
            plongeur = new Plongeur(134,596);
            cuisinier = new Cuisinier(89,515);
            cuissons.Add(new Cuisson(208,371));
            cuissons.Add(new Cuisson(296,371));

            commande = new List<Commande>();
        }
    }
}
