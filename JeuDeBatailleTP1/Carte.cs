using System;
using System.Collections.Generic;
using System.Text;

enum Figure { 

    Coeurs,
    Carreaux,
    Piques,
    Trefles
}

enum Point { 
    Deux,
    Trois,
    Quatre,
    Cinq,
    Six,
    Sept,
    Huit,
    Neuf,
    Dix,
    Jack,
    Reine,
    Roi,
    As
}

namespace JeuDeBatailleTP1
{
    class Carte
    {
        public Figure figure;
        public Point point;

        public void AfficherCarte() 
        {
            Console.WriteLine("{0} de {1}", point, figure);
        }
    }

}
