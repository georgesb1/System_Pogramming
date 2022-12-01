using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Salle
{
    class Table
    {
        public int nombre_place { get; set; }
        public int nombre_table { get; set; }
        public Boolean disponible { get; set; }
        public Boolean Pain { get; set; }
        public Boolean Eau { get; set; }
        public Boolean Servir { get; set; }
      
        public int Position_x { get; set; }
        public int Position_y { get; set; }

        public Client client { get; set; }

        public Table(int position_x, int position_y, int nombre_place, int nombre_table)
        {
            this.disponible = true;
            this.Pain = false;
            this.Eau = false;
            this.Position_x = position_x;
            this.Position_y = position_y;
            this.nombre_place = nombre_place;
            this.nombre_table = nombre_table;
        }

    }
}
