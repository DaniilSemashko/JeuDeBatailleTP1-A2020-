using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuDeBatailleTP1
{
    public class Jeu
    {
        public int numRonde;
        public Joueurs j1;
        public Joueurs j2;

        /**
         * Premiere methode qui initie la partie entre 2 jouers
         * Puis separe le paquet du jeu en 2 paquet de cartes
         */
        public Jeu(string nomJoueur1, string nomJoueur2) 
        {
            j1 = new Joueurs(nomJoueur1);
            j2 = new Joueurs(nomJoueur2);
            var cartes = Paquet.GenererPaquetDeCartes(); 
            var pqtDeCartes = j1.DistribuerLesCartes(cartes);
            j2.PaquetDeCartes = pqtDeCartes;
        }

        /**
         * Methode qui valide si le jeu est termine ou non en verifiant si il reste des cartes dans 
         * les paquets en jeu
         */
        public bool FinJeu()
        {
            if (!j1.PaquetDeCartes.Any()) // cas ou le j1 n`a plus de cartes dans le paquet
            {
                Console.WriteLine(" Bravo " + j2.NomJoueur + " vous avez gagne, puisque le paquet de cartes de: " + j1.NomJoueur + " est termine");
                Console.WriteLine("Nombre de tours joues: " + numRonde);
                return true;
            }
            else if (!j2.PaquetDeCartes.Any()) //cas ou le j2 n'a plus de cartes dans le paquet
            {
                Console.WriteLine(" Bravo " + j1.NomJoueur + " vous avez gagne, puisque le paquet de cartes de: " + j2.NomJoueur + " est termine");
                Console.WriteLine("Nombre de tours joues: " + numRonde);
                return true;
            }
            return false; //si les conditions ne sont pas atteintes la partie continue
        }
        /**
         * Methode qui montre l`affichage et le deroulement d`un tour joue par les 2 joueurs
         */
        public void DeroulememtTourJoue()
        {
            
        }
    }
}
