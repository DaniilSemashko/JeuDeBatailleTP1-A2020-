using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


/**
 * Enumeration qui contient les 4 figures dans un jeu de carte utilisee pour generer 
 * le paquet de carte et chaque carte
 */
public enum Figure
{
     Coeurs,
     Carreaux,
     Trefles,
     Piques
}

namespace JeuDeBatailleTP1
{
    public class Carte
    {
     
        public string AffichageNomCarteEnJeu { get; set; } //affiche le nom de la carte
        public Figure Figure { get; set; } // definit la figure de l`enum figure pour la carte
        public int Point { get; set; } // donne une valeur de 2 a 14 a la carte
        
    }

}
