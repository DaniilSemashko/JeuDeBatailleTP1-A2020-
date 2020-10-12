using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return true;
            }
            else if (!j2.PaquetDeCartes.Any()) //cas ou le j2 n'a plus de cartes dans le paquet
            {
                Console.WriteLine(" Bravo " + j1.NomJoueur + " vous avez gagne, puisque le paquet de cartes de " + j2.NomJoueur + " est termine");

                return true;
            }
            return false; //si les conditions ne sont pas atteintes la partie continue
        }
        /**
         * Methode qui montre l`affichage et le deroulement d`un tour joue par les 2 joueurs
         */
        public void DeroulememtTourJoue()
        {
            Queue<Carte> surTable = new Queue<Carte>();
            var j1carte = j1.PaquetDeCartes.Dequeue();
            var j2carte = j2.PaquetDeCartes.Dequeue();
            surTable.Enqueue(j1carte);
            surTable.Enqueue(j2carte);

            /**
             * Chercher des display methods en ligne plus tard pour voir autres possibiltes
             * de display plus clean
             */

            Console.WriteLine("\n" + j1.NomJoueur + " joue :                         " + j2.NomJoueur + " joue : ");
            Console.WriteLine("  ____________________            ____________________");
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  |                   |    VS     |                   |");
            Console.WriteLine("    " + j1carte.AffichageNomCarteEnJeu + "                      " + j2carte.AffichageNomCarteEnJeu);
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  |                   |           |                   |");
            Console.WriteLine("  ____________________            ____________________");

            while (j1carte.Point == j2carte.Point) 
            {
                Console.WriteLine("\n\n===============B A T A I L L E !===============\n\n");
                if (j1.PaquetDeCartes.Count < 4)
                {
                    j1.PaquetDeCartes.Clear();
                    return;
                }
                if (j2.PaquetDeCartes.Count < 4)
                {
                    j1.PaquetDeCartes.Clear();
                    return;
                }
                surTable.Enqueue(j1.PaquetDeCartes.Dequeue());
                surTable.Enqueue(j1.PaquetDeCartes.Dequeue());
                surTable.Enqueue(j1.PaquetDeCartes.Dequeue());
                surTable.Enqueue(j2.PaquetDeCartes.Dequeue());
                surTable.Enqueue(j2.PaquetDeCartes.Dequeue());
                surTable.Enqueue(j2.PaquetDeCartes.Dequeue());
                j1carte = j1.PaquetDeCartes.Dequeue();
                j2carte = j2.PaquetDeCartes.Dequeue();

                Console.WriteLine("\n"+j1.NomJoueur + " joue :                         " + j2.NomJoueur + " joue : ");
                Console.WriteLine("  ____________________            ____________________");
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  |                   |    VS     |                   |");
                Console.WriteLine("    " + j1carte.AffichageNomCarteEnJeu + "                      " + j2carte.AffichageNomCarteEnJeu);
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  |                   |           |                   |");
                Console.WriteLine("  ____________________            ____________________");
            }

            if (j1carte.Point < j2carte.Point)
            {
                j2.PaquetDeCartes.Enqueue(surTable);
                Console.WriteLine("\n          ********** "+j2.NomJoueur + " Remporte la main *********");

            }
            else 
            {
                j1.PaquetDeCartes.Enqueue(surTable);
                Console.WriteLine("\n          ********** " + j1.NomJoueur + " Remporte la main *********");
            }

            numRonde++;
        }

    }
}
