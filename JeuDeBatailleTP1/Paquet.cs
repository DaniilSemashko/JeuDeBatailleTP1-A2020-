using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDeBatailleTP1
{
    class Paquet
    {
        public List<Carte> CartesDansLePaquet;

        /**Utiliser cette methode pur peupler un paquet de carte qui ne sont pas melange. 
         Cette methode ne fait que creer un paquet de 52 cartes en ordre. **/
        public void CreerUnPaquet()
        {

            CartesDansLePaquet = new List<Carte>(52);
            int place = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int f = 0; i < 13; i++)
                {


                    Carte carte = new Carte();
                    CartesDansLePaquet.Add(carte);
                    CartesDansLePaquet[place].figure = (Figure)i;
                    CartesDansLePaquet[place].point = (Point)f;
                    place++;
                }
            }
        }

        private static Random hasardnum = new Random();

        /** 
         * Melange les cares de mnaniere aleatoire afin de melanger le paquet de carte qui a ete
         * genere en ordre logique ou toutes les cartes se suivent
         */
        public void MelangerPaquet()
        {
            Carte enattente = new Carte();
            int NumeroAuHasard;

            for (int i = 0; i < 52; i++)
            {
                NumeroAuHasard = hasardnum.Next(0, 51);
                enattente = CartesDansLePaquet[i];
                CartesDansLePaquet[i] = CartesDansLePaquet[NumeroAuHasard];
                CartesDansLePaquet[NumeroAuHasard] = enattente;
            }
        }

        public void RegarderPacquet() {

            foreach (var carte in CartesDansLePaquet)
            {
                carte.AfficherCarte();
                
            }

        }

        
    }
}
