using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetResto.Modèle.Salle
{
    class Rang
    {
        public List<Table> tables;

        public Rang(int rang)
        {
            tables = new List<Table>();

            switch(rang)
            {
                case 1:
                    tables.Add(new Table(54, 117, 4, 1));
                    tables.Add(new Table(168, 74, 4, 2));
                    tables.Add(new Table(311, 108, 4, 3));
                    tables.Add(new Table(444, 61, 4, 4));
                    tables.Add(new Table(591, 81, 8, 5));
                    tables.Add(new Table(741, 73, 4, 6));
                    tables.Add(new Table(874, 88, 8, 7));
                    break;

                case 2:
                    tables.Add(new Table(41, 285, 4, 8));
                    tables.Add(new Table(188, 221, 4, 9));
                    tables.Add(new Table(311, 280, 4, 10));
                    tables.Add(new Table(437, 217, 4, 11));
                    tables.Add(new Table(583, 277, 4, 12));
                    tables.Add(new Table(735, 235, 8, 13));
                    tables.Add(new Table(891, 281, 4, 14));
                    break;

                default:
                    break;
            }
        }
    }
}
