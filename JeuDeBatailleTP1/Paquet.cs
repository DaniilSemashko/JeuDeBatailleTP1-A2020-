using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuDeBatailleTP1
{
    public static class Paquet
    {
        public static Queue<Carte> GenererPaquetDeCartes()
        {
            Queue<Carte> paquetDeCartes = new Queue<Carte>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (Figure figure in Enum.GetValues(typeof(Figure)))
                {
                    paquetDeCartes.Enqueue(new Carte()
                    {
                        Figure = figure,
                        Point = i,
                        AffichageNomCarteEnJeu = ObtenirNom(i, figure)
                    });
                }  
            }
            return EffectuerMelange(paquetDeCartes);
        }

        /**
         * Cette methode a ete prise de https://jamesshinevar.com/2017/05/28/shuffle-a-list-c-fisher-yates-shuffle/
         * Pour effectuer le melange de Fisher-Yates, la methode au complet a ete copie et colle du site web mentionne
         * ci-dessus avec quelques modifications mineures pour etre conforme avec le nom des methodes presente dans mon projet
         */
        public static Queue<Carte> EffectuerMelange(Queue<Carte> paquetDeCartes)
        {
            List<Carte> listeDesCartes = paquetDeCartes.ToList();
            Random numRandom = new Random();
            for (int z = listeDesCartes.Count; z > 0; --z)
            {
                int r = numRandom.Next(z + 1);
                Carte carteEnAttente = listeDesCartes[z];
                listeDesCartes[z] = listeDesCartes[r];
                listeDesCartes[r] = carteEnAttente;
            }
            Queue<Carte> paquetDeCartesMelanges = new Queue<Carte>();
            foreach (var carte in listeDesCartes) 
            {
                paquetDeCartesMelanges.Enqueue(carte);
            }
            return paquetDeCartesMelanges;
        }
        /**
         * Permet d`obtenir un nom raccourci pour chaque 
         * carte qui est jouee pour pouvoir faire des modifications graphiques
         * par la suite lors de l`affichage
         */
        public static string ObtenirNom(int valeur, Figure figure)
        {
            string AffichageDesPointes = "";
            if (valeur >= 2 && valeur <= 10)
            {
                AffichageDesPointes = valeur.ToString();
            }
            else if (valeur == 11)
            {
                AffichageDesPointes = "J";
            }
            else if (valeur == 12)
            {
                AffichageDesPointes = "Q";
            }
            else if (valeur == 13)
            {
                AffichageDesPointes = "K";
            }
            else if (valeur == 14) 
            {
                AffichageDesPointes = "A";
            }
            return AffichageDesPointes + " de " + Enum.GetName(typeof(Figure), figure)[0];
        }
    }

}
