using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuDeBatailleTP1
{
    public class Joueurs
    {
        public string NomJoueur { get; set; }
        public Queue<Carte> PaquetDeCartes { get; set; }


        /** Constructeur vide pour un joueur de la partie afin d`y 
         * metre n`importe quelles 
         * valeurs par la suite
         */
        public Joueurs()
        {

        }

        /**
         * Defint un nom pour les joueurs
         */
        public Joueurs(String nomJoueur)
        {
            NomJoueur = nomJoueur;
        }

        /**
         * Definir un paquet de cartes pour chaque joueur sous forme de 
         * paquet de cartes Joueur 1 et paquet de cartes Joueur 2
         */
        public Queue<Carte> DistribuerLesCartes(Queue<Carte> paquetDeCartes)
        {
            Queue<Carte> paquetDeCartesJoueur1 = new Queue<Carte>(); // Creation paquet joueur 1
            Queue<Carte> paquetDeCartesJoueur2 = new Queue<Carte>(); // Creation paquet joueur 2
            int compteurDeJoueurs = 2;
            /** 
             * Loop pour separer le paquet initial en 2 paquets de meme taille.
             */
            do
            {
                if (compteurDeJoueurs % 2 == 0)
                {
                    paquetDeCartesJoueur2.Enqueue(paquetDeCartes.Dequeue());
                }
                else
                {
                    paquetDeCartesJoueur1.Enqueue(paquetDeCartes.Dequeue());
                }
                compteurDeJoueurs++;
            }
            while (paquetDeCartes.Any());

            PaquetDeCartes = paquetDeCartesJoueur1;
            return paquetDeCartesJoueur2;

        }
    }
}


