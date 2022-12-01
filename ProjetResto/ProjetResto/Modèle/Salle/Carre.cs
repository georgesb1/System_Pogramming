using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Salle
{
    class Carre
    {
        private int nombrecarre { get; set; }
        public List<Rang> rang;
        public Chefrang chefrang;
        public List<Serveur> serveur;

        public Carre(int numberSquare)
        {
            serveur = new List<Serveur>();
            rang = new List<Rang>();
            switch (nombrecarre) { 

                case 1:
                    rang.Add(new Rang(1));
                    rang.Add(new Rang(2));

                    chefrang = new Chefrang(283, 184);

                    serveur.Add(new Serveur(139,281));
                    serveur.Add(new Serveur(262, 47));
                    break;

                case 2:
                    rang.Add(new Rang(3));
                    rang.Add(new Rang(4));

                    chefrang = new Chefrang(799, 149);

                    serveur.Add(new Serveur(663, 328));
                    serveur.Add(new Serveur(678, 37));
                    break;
                default:
                    this.rang = null;
                    break;
            
            }
            this.nombrecarre = nombrecarre;
        }

    }
}
