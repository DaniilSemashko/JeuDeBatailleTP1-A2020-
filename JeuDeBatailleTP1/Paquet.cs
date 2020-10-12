using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuDeBatailleTP1
{
    public static class Paquet
    {
        /**
         * La methode suivante est utilisee pour generer le paquet de cartes initial avec les valeurs de 2 a 14 et les 4 Figures
         * etant coeurs, piques, trefles, carreaux qui sont identifies dans l`enum publique de la classe Carte.Cs
         */
        public static Queue<Carte> GenererPaquetDeCartes()
        {
            Queue<Carte> cartes = new Queue<Carte>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (Figure figure in Enum.GetValues(typeof(Figure)))
                {
                    cartes.Enqueue(new Carte()
                    {
                        Figure = figure,
                        Point = i,
                        AffichageNomCarteEnJeu = ObtenirNom(i, figure)
                    });
                }
            }
            return EffectuerMelange(cartes);
        }

        /**
         * Cette methode a ete prise de https://jamesshinevar.com/2017/05/28/shuffle-a-list-c-fisher-yates-shuffle/
         * Pour effectuer le melange de Fisher-Yates, la methode au complet a ete copie et colle du site web mentionne
         * ci-dessus avec quelques modifications mineures pour etre conforme avec le nom des methodes presente dans mon projet
         */
        private static Queue<Carte> EffectuerMelange(Queue<Carte> paquetDeCartes)
        {
            List<Carte> listeDesCartes = paquetDeCartes.ToList();
            Random numRandom = new Random(DateTime.Now.Millisecond);
            for (int z = listeDesCartes.Count - 1; z > 0; --z)
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
         * End of copyright section
         */


        /**
         * Permet d`obtenir un nom raccourci pour chaque 
         * carte qui est jouee pour pouvoir faire des modifications graphiques
         * par la suite lors de l`affichage les format d`affichage apres
         * Obtenir nom doivent ressembler a 10 de Pique, As de trefle etc.
         */
        private static string ObtenirNom(int valeur, Figure figure)
        {
            string AffichageDesPointes = "";
            if (valeur >= 2 && valeur <= 10)
            {
                AffichageDesPointes = valeur.ToString();
            }
            else if (valeur == 11)
            {
                AffichageDesPointes = "Valet";
            }
            else if (valeur == 12)
            {
                AffichageDesPointes = "Reine";
            }
            else if (valeur == 13)
            {
                AffichageDesPointes = "Roi";
            }
            else if (valeur == 14)
            {
                AffichageDesPointes = "AS";
            }
            return AffichageDesPointes + " de " + Enum.GetName(typeof(Figure), figure);
        }

    }   

}
