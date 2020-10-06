using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeBatailleTP1
{
    class Joueur
    {
        public string nomJoueur = "Ordinateur";
        public Carte carteEnJeu = new Carte();
        public int Victoires = 0, compteurDePioche = 0;
        public Paquet paquetEnJeu = new Paquet();

        public void SelectionnerUnNom() 
        {
            while (nomJoueur == "Ordinateur" || nomJoueur == "")
            {
                Console.WriteLine("Veuillez Indiquer Votre Nom Pour Debuter Cette Partie: ");
                nomJoueur = Console.ReadLine();
                if (nomJoueur == "Ordinateur" || nomJoueur == "")
                {
                    Console.WriteLine("Nom Invalide, Veuillez Entrer Un Autre Nom");
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }

        public void PiocherUneCarte()
        {
            carteEnJeu = paquetEnJeu.CartesDansLePaquet[compteurDePioche];
            compteurDePioche++;
            if (compteurDePioche == 52)
            {
                compteurDePioche = 0;
            }
        }

    }
}
