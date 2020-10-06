using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeBatailleTP1
{
    static class Jeu
    {
        static public void DemarrageProg(Joueur j1, Joueur j2)
        {
            CreationPaquetsJoueurs.GenererPaquetJoueurs(j1, j2);
            CreationPaquetsJoueurs.DefinirNom(j1);
        }

        static public void MelangerLesPaquetsDesJoueurs(Joueur j1, Joueur j2)
        {
            j1.paquetEnJeu.MelangerPaquet();
            j2.paquetEnJeu.MelangerPaquet();
        }

        static public void PiocherUneCarte(Joueur j1, Joueur j2)
        {
            j1.PiocherUneCarte();
            j2.PiocherUneCarte();
        }

        static public void DeroulementDeLaPartie(Joueur j1, Joueur j2, int numPartie)
        {
            Jeu.PiocherUneCarte(j1, j2);
            //Words.Template(j1,j2, numPartie);
            Jeu.ValiderLaVicotoire(j1, j2);
        }



        static public void ValiderLaVicotoire(Joueur j1, Joueur j2)
        {
            Console.WriteLine("\n");
            if ((int)j1.carteEnJeu.point > (int)j2.carteEnJeu.point)
            {
                j1.Victoires++;
                Console.WriteLine("\nVous avez gagne cette ronde ! Appuyez ENTER pour continuer");
                Console.ReadLine();
                Console.Clear();
            }
            else if ((int)j1.carteEnJeu.point < (int)j2.carteEnJeu.point)
            {
                j2.Victoires++;
                Console.WriteLine("\nVous avez perdu cette ronde ! Appuyez ENTER pour continuer");
                Console.ReadLine();
                Console.Clear();
            }

            else if ((int)j1.carteEnJeu.point == (int)j2.carteEnJeu.point)
            {
                Console.WriteLine("\nBATAILLE !!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
